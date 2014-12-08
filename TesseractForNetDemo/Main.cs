using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using Tesseract;

namespace TesseractForNetDemo
{
  public partial class Main : Form
  {
    private string strSelectImgFile = "";

    public Main()
    {
      InitializeComponent();
    }

    private void btn_1_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.InitialDirectory = Application.StartupPath;
      openFileDialog1.Filter = "TIF files(*.tif)|*.tif";
      openFileDialog1.RestoreDirectory = true;
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        strSelectImgFile = openFileDialog1.FileName;
        pictureBox1.Image = Image.FromFile(strSelectImgFile);
      }
    }

    private void btn_2_Click(object sender, EventArgs e)
    {
      if (strSelectImgFile.Length < 1) return;
      try
      {
        using (var engine = new TesseractEngine(@"./tessdata", "normal", EngineMode.Default))
        {
          using (var img = Pix.LoadFromFile(strSelectImgFile))
          {
            using (var page = engine.Process(img))
            {
              string text = page.GetText();
              ArrayList strlist = splittext(text);
              for (int I = 0; I < strlist.Count; I++)
              {
                
                //strlist[I].ToString().i
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private ArrayList splittext(string text)
    {
      ArrayList allstr = new ArrayList();
      string[] strnn = Regex.Split(text, "\n\n", RegexOptions.IgnoreCase);
      foreach (string strs in strnn)
      {
        string temp = strs.Replace(": ", ":").Replace(" :",":").Trim();
        string[] strn = Regex.Split(temp, "\n", RegexOptions.IgnoreCase);
        if (strn.Length > 1)
        {
          foreach (string str in strn)
          {
            Regex rgx = new Regex(@"[\u4e00-\u9fa5]*[:]\S*", RegexOptions.IgnoreCase);
            MatchCollection mc = rgx.Matches(str);
            if (mc.Count>0)
            {
              foreach (Match ma in mc)
              {
                if(ma.Success)
                {
                  allstr.Add(ma.Value.ToString());
                }
              }
            }
            else
            {
              allstr.Add(str);
            }
          }
        }
        else if (temp.Length > 2)
        {
          allstr.Add(temp);
        }
      }
      return allstr;
    }

    private void Main_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“db_Simple_Imgr2DataSet.Imgr2”中。您可以根据需要移动或删除它。
      this.imgr2TableAdapter.Fill(this.db_Simple_Imgr2DataSet.Imgr2);

    }
  }
}
