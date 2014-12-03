using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
        pictureBox1.Size = pictureBox1.Image.Size;
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
              var text = page.GetText();

            }
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void Main_Load(object sender, EventArgs e)
    {
      // TODO: 这行代码将数据加载到表“db_Simple_Imgr2DataSet.Imgr2”中。您可以根据需要移动或删除它。
        this.pictureBox1.MouseWheel += new MouseEventHandler(pictureBox1_MouseWheel);
        this.pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
      this.imgr2TableAdapter.Fill(this.db_Simple_Imgr2DataSet.Imgr2);

    }
    private void pictureBox1_MouseEnter(object sender, EventArgs e)
    {
        this.pictureBox1.Focus();
    }

    private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
    {
        double dbScale = 1;
        if (this.pictureBox1.Height > 0)
        {
            dbScale = (double)this.pictureBox1.Width / (double)this.pictureBox1.Height;
        }
        pictureBox1.Width += (int)(e.Delta * dbScale);
        pictureBox1.Height += e.Delta;
    }
  }
}
