namespace TesseractForNetDemo
{
  partial class Main
  {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_2 = new System.Windows.Forms.Button();
      this.btn_1 = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.cbo_14 = new System.Windows.Forms.ComboBox();
      this.cbo_13 = new System.Windows.Forms.ComboBox();
      this.cbo_12 = new System.Windows.Forms.ComboBox();
      this.dtp_9 = new System.Windows.Forms.DateTimePicker();
      this.cbo_11 = new System.Windows.Forms.ComboBox();
      this.cbo_8 = new System.Windows.Forms.ComboBox();
      this.cbo_10 = new System.Windows.Forms.ComboBox();
      this.cbo_7 = new System.Windows.Forms.ComboBox();
      this.cbo_6 = new System.Windows.Forms.ComboBox();
      this.cbo_5 = new System.Windows.Forms.ComboBox();
      this.cbo_4 = new System.Windows.Forms.ComboBox();
      this.cbo_1 = new System.Windows.Forms.ComboBox();
      this.dtp_2 = new System.Windows.Forms.DateTimePicker();
      this.txt_3 = new System.Windows.Forms.TextBox();
      this.btn_3 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.trxNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lineItemNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.warehouseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.imgr2BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.db_Simple_Imgr2DataSet = new TesseractForNetDemo.db_Simple_Imgr2DataSet();
      this.lbl_14 = new System.Windows.Forms.Label();
      this.lbl_13 = new System.Windows.Forms.Label();
      this.lbl_12 = new System.Windows.Forms.Label();
      this.lbl_11 = new System.Windows.Forms.Label();
      this.lbl_10 = new System.Windows.Forms.Label();
      this.lbl_9 = new System.Windows.Forms.Label();
      this.lbl_8 = new System.Windows.Forms.Label();
      this.lbl_7 = new System.Windows.Forms.Label();
      this.lbl_6 = new System.Windows.Forms.Label();
      this.lbl_5 = new System.Windows.Forms.Label();
      this.lbl_4 = new System.Windows.Forms.Label();
      this.lbl_3 = new System.Windows.Forms.Label();
      this.lbl_2 = new System.Windows.Forms.Label();
      this.lbl_1 = new System.Windows.Forms.Label();
      this.imgr2TableAdapter = new TesseractForNetDemo.db_Simple_Imgr2DataSetTableAdapters.Imgr2TableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imgr2BindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.db_Simple_Imgr2DataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(760, 225);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_2);
      this.panel1.Controls.Add(this.btn_1);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(760, 34);
      this.panel1.TabIndex = 1;
      // 
      // btn_2
      // 
      this.btn_2.Location = new System.Drawing.Point(343, 6);
      this.btn_2.Name = "btn_2";
      this.btn_2.Size = new System.Drawing.Size(75, 23);
      this.btn_2.TabIndex = 1;
      this.btn_2.Text = "开始识别";
      this.btn_2.UseVisualStyleBackColor = true;
      this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
      // 
      // btn_1
      // 
      this.btn_1.Location = new System.Drawing.Point(3, 3);
      this.btn_1.Name = "btn_1";
      this.btn_1.Size = new System.Drawing.Size(75, 23);
      this.btn_1.TabIndex = 0;
      this.btn_1.Text = "选择图片";
      this.btn_1.UseVisualStyleBackColor = true;
      this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.pictureBox1);
      this.panel2.Location = new System.Drawing.Point(12, 52);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(760, 225);
      this.panel2.TabIndex = 2;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.cbo_14);
      this.panel3.Controls.Add(this.cbo_13);
      this.panel3.Controls.Add(this.cbo_12);
      this.panel3.Controls.Add(this.dtp_9);
      this.panel3.Controls.Add(this.cbo_11);
      this.panel3.Controls.Add(this.cbo_8);
      this.panel3.Controls.Add(this.cbo_10);
      this.panel3.Controls.Add(this.cbo_7);
      this.panel3.Controls.Add(this.cbo_6);
      this.panel3.Controls.Add(this.cbo_5);
      this.panel3.Controls.Add(this.cbo_4);
      this.panel3.Controls.Add(this.cbo_1);
      this.panel3.Controls.Add(this.dtp_2);
      this.panel3.Controls.Add(this.txt_3);
      this.panel3.Controls.Add(this.btn_3);
      this.panel3.Controls.Add(this.dataGridView1);
      this.panel3.Controls.Add(this.lbl_14);
      this.panel3.Controls.Add(this.lbl_13);
      this.panel3.Controls.Add(this.lbl_12);
      this.panel3.Controls.Add(this.lbl_11);
      this.panel3.Controls.Add(this.lbl_10);
      this.panel3.Controls.Add(this.lbl_9);
      this.panel3.Controls.Add(this.lbl_8);
      this.panel3.Controls.Add(this.lbl_7);
      this.panel3.Controls.Add(this.lbl_6);
      this.panel3.Controls.Add(this.lbl_5);
      this.panel3.Controls.Add(this.lbl_4);
      this.panel3.Controls.Add(this.lbl_3);
      this.panel3.Controls.Add(this.lbl_2);
      this.panel3.Controls.Add(this.lbl_1);
      this.panel3.Location = new System.Drawing.Point(12, 283);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(760, 267);
      this.panel3.TabIndex = 3;
      // 
      // cbo_14
      // 
      this.cbo_14.FormattingEnabled = true;
      this.cbo_14.Location = new System.Drawing.Point(74, 143);
      this.cbo_14.Name = "cbo_14";
      this.cbo_14.Size = new System.Drawing.Size(366, 21);
      this.cbo_14.TabIndex = 29;
      // 
      // cbo_13
      // 
      this.cbo_13.FormattingEnabled = true;
      this.cbo_13.Location = new System.Drawing.Point(74, 116);
      this.cbo_13.Name = "cbo_13";
      this.cbo_13.Size = new System.Drawing.Size(366, 21);
      this.cbo_13.TabIndex = 28;
      // 
      // cbo_12
      // 
      this.cbo_12.FormattingEnabled = true;
      this.cbo_12.Location = new System.Drawing.Point(562, 86);
      this.cbo_12.Name = "cbo_12";
      this.cbo_12.Size = new System.Drawing.Size(162, 21);
      this.cbo_12.TabIndex = 27;
      // 
      // dtp_9
      // 
      this.dtp_9.Location = new System.Drawing.Point(562, 62);
      this.dtp_9.Name = "dtp_9";
      this.dtp_9.Size = new System.Drawing.Size(162, 20);
      this.dtp_9.TabIndex = 26;
      // 
      // cbo_11
      // 
      this.cbo_11.FormattingEnabled = true;
      this.cbo_11.Location = new System.Drawing.Point(320, 89);
      this.cbo_11.Name = "cbo_11";
      this.cbo_11.Size = new System.Drawing.Size(121, 21);
      this.cbo_11.TabIndex = 25;
      // 
      // cbo_8
      // 
      this.cbo_8.FormattingEnabled = true;
      this.cbo_8.Location = new System.Drawing.Point(319, 65);
      this.cbo_8.Name = "cbo_8";
      this.cbo_8.Size = new System.Drawing.Size(121, 21);
      this.cbo_8.TabIndex = 24;
      // 
      // cbo_10
      // 
      this.cbo_10.FormattingEnabled = true;
      this.cbo_10.Location = new System.Drawing.Point(74, 89);
      this.cbo_10.Name = "cbo_10";
      this.cbo_10.Size = new System.Drawing.Size(121, 21);
      this.cbo_10.TabIndex = 23;
      // 
      // cbo_7
      // 
      this.cbo_7.FormattingEnabled = true;
      this.cbo_7.Location = new System.Drawing.Point(74, 65);
      this.cbo_7.Name = "cbo_7";
      this.cbo_7.Size = new System.Drawing.Size(121, 21);
      this.cbo_7.TabIndex = 22;
      // 
      // cbo_6
      // 
      this.cbo_6.FormattingEnabled = true;
      this.cbo_6.Location = new System.Drawing.Point(562, 38);
      this.cbo_6.Name = "cbo_6";
      this.cbo_6.Size = new System.Drawing.Size(162, 21);
      this.cbo_6.TabIndex = 21;
      // 
      // cbo_5
      // 
      this.cbo_5.FormattingEnabled = true;
      this.cbo_5.Location = new System.Drawing.Point(319, 38);
      this.cbo_5.Name = "cbo_5";
      this.cbo_5.Size = new System.Drawing.Size(121, 21);
      this.cbo_5.TabIndex = 20;
      // 
      // cbo_4
      // 
      this.cbo_4.FormattingEnabled = true;
      this.cbo_4.Location = new System.Drawing.Point(74, 38);
      this.cbo_4.Name = "cbo_4";
      this.cbo_4.Size = new System.Drawing.Size(121, 21);
      this.cbo_4.TabIndex = 19;
      // 
      // cbo_1
      // 
      this.cbo_1.FormattingEnabled = true;
      this.cbo_1.Location = new System.Drawing.Point(74, 12);
      this.cbo_1.Name = "cbo_1";
      this.cbo_1.Size = new System.Drawing.Size(121, 21);
      this.cbo_1.TabIndex = 18;
      // 
      // dtp_2
      // 
      this.dtp_2.Location = new System.Drawing.Point(319, 10);
      this.dtp_2.Name = "dtp_2";
      this.dtp_2.Size = new System.Drawing.Size(122, 20);
      this.dtp_2.TabIndex = 17;
      // 
      // txt_3
      // 
      this.txt_3.Location = new System.Drawing.Point(562, 13);
      this.txt_3.Name = "txt_3";
      this.txt_3.Size = new System.Drawing.Size(162, 20);
      this.txt_3.TabIndex = 16;
      // 
      // btn_3
      // 
      this.btn_3.Location = new System.Drawing.Point(668, 216);
      this.btn_3.Name = "btn_3";
      this.btn_3.Size = new System.Drawing.Size(75, 23);
      this.btn_3.TabIndex = 15;
      this.btn_3.Text = "确认无误";
      this.btn_3.UseVisualStyleBackColor = true;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trxNoDataGridViewTextBoxColumn,
            this.lineItemNoDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.warehouseCodeDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.imgr2BindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(16, 170);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(570, 85);
      this.dataGridView1.TabIndex = 14;
      // 
      // trxNoDataGridViewTextBoxColumn
      // 
      this.trxNoDataGridViewTextBoxColumn.DataPropertyName = "TrxNo";
      this.trxNoDataGridViewTextBoxColumn.HeaderText = "TrxNo";
      this.trxNoDataGridViewTextBoxColumn.Name = "trxNoDataGridViewTextBoxColumn";
      // 
      // lineItemNoDataGridViewTextBoxColumn
      // 
      this.lineItemNoDataGridViewTextBoxColumn.DataPropertyName = "LineItemNo";
      this.lineItemNoDataGridViewTextBoxColumn.HeaderText = "LineItemNo";
      this.lineItemNoDataGridViewTextBoxColumn.Name = "lineItemNoDataGridViewTextBoxColumn";
      // 
      // productCodeDataGridViewTextBoxColumn
      // 
      this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
      this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
      this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
      // 
      // qtyDataGridViewTextBoxColumn
      // 
      this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
      this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
      this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
      // 
      // warehouseCodeDataGridViewTextBoxColumn
      // 
      this.warehouseCodeDataGridViewTextBoxColumn.DataPropertyName = "WarehouseCode";
      this.warehouseCodeDataGridViewTextBoxColumn.HeaderText = "WarehouseCode";
      this.warehouseCodeDataGridViewTextBoxColumn.Name = "warehouseCodeDataGridViewTextBoxColumn";
      // 
      // imgr2BindingSource
      // 
      this.imgr2BindingSource.DataMember = "Imgr2";
      this.imgr2BindingSource.DataSource = this.db_Simple_Imgr2DataSet;
      // 
      // db_Simple_Imgr2DataSet
      // 
      this.db_Simple_Imgr2DataSet.DataSetName = "db_Simple_Imgr2DataSet";
      this.db_Simple_Imgr2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // lbl_14
      // 
      this.lbl_14.AutoSize = true;
      this.lbl_14.Location = new System.Drawing.Point(13, 142);
      this.lbl_14.Name = "lbl_14";
      this.lbl_14.Size = new System.Drawing.Size(55, 13);
      this.lbl_14.TabIndex = 13;
      this.lbl_14.Text = "入库地址";
      // 
      // lbl_13
      // 
      this.lbl_13.AutoSize = true;
      this.lbl_13.Location = new System.Drawing.Point(13, 119);
      this.lbl_13.Name = "lbl_13";
      this.lbl_13.Size = new System.Drawing.Size(55, 13);
      this.lbl_13.TabIndex = 12;
      this.lbl_13.Text = "出库地址";
      // 
      // lbl_12
      // 
      this.lbl_12.AutoSize = true;
      this.lbl_12.Location = new System.Drawing.Point(490, 92);
      this.lbl_12.Name = "lbl_12";
      this.lbl_12.Size = new System.Drawing.Size(55, 13);
      this.lbl_12.TabIndex = 11;
      this.lbl_12.Text = "单据状态";
      // 
      // lbl_11
      // 
      this.lbl_11.AutoSize = true;
      this.lbl_11.Location = new System.Drawing.Point(258, 92);
      this.lbl_11.Name = "lbl_11";
      this.lbl_11.Size = new System.Drawing.Size(55, 13);
      this.lbl_11.TabIndex = 10;
      this.lbl_11.Text = "配送方式";
      // 
      // lbl_10
      // 
      this.lbl_10.AutoSize = true;
      this.lbl_10.Location = new System.Drawing.Point(13, 92);
      this.lbl_10.Name = "lbl_10";
      this.lbl_10.Size = new System.Drawing.Size(55, 13);
      this.lbl_10.TabIndex = 9;
      this.lbl_10.Text = "调入仓库";
      // 
      // lbl_9
      // 
      this.lbl_9.AutoSize = true;
      this.lbl_9.Location = new System.Drawing.Point(490, 64);
      this.lbl_9.Name = "lbl_9";
      this.lbl_9.Size = new System.Drawing.Size(55, 13);
      this.lbl_9.TabIndex = 8;
      this.lbl_9.Text = "打印时间";
      // 
      // lbl_8
      // 
      this.lbl_8.AutoSize = true;
      this.lbl_8.Location = new System.Drawing.Point(258, 64);
      this.lbl_8.Name = "lbl_8";
      this.lbl_8.Size = new System.Drawing.Size(43, 13);
      this.lbl_8.TabIndex = 7;
      this.lbl_8.Text = "打单员";
      // 
      // lbl_7
      // 
      this.lbl_7.AutoSize = true;
      this.lbl_7.Location = new System.Drawing.Point(13, 64);
      this.lbl_7.Name = "lbl_7";
      this.lbl_7.Size = new System.Drawing.Size(55, 13);
      this.lbl_7.TabIndex = 6;
      this.lbl_7.Text = "调出仓库";
      // 
      // lbl_6
      // 
      this.lbl_6.AutoSize = true;
      this.lbl_6.Location = new System.Drawing.Point(490, 38);
      this.lbl_6.Name = "lbl_6";
      this.lbl_6.Size = new System.Drawing.Size(55, 13);
      this.lbl_6.TabIndex = 5;
      this.lbl_6.Text = "单据类型";
      // 
      // lbl_5
      // 
      this.lbl_5.AutoSize = true;
      this.lbl_5.Location = new System.Drawing.Point(258, 38);
      this.lbl_5.Name = "lbl_5";
      this.lbl_5.Size = new System.Drawing.Size(43, 13);
      this.lbl_5.TabIndex = 4;
      this.lbl_5.Text = "录单员";
      // 
      // lbl_4
      // 
      this.lbl_4.AutoSize = true;
      this.lbl_4.Location = new System.Drawing.Point(13, 38);
      this.lbl_4.Name = "lbl_4";
      this.lbl_4.Size = new System.Drawing.Size(55, 13);
      this.lbl_4.TabIndex = 3;
      this.lbl_4.Text = "调拨单位";
      // 
      // lbl_3
      // 
      this.lbl_3.AutoSize = true;
      this.lbl_3.Location = new System.Drawing.Point(490, 13);
      this.lbl_3.Name = "lbl_3";
      this.lbl_3.Size = new System.Drawing.Size(31, 13);
      this.lbl_3.TabIndex = 2;
      this.lbl_3.Text = "单号";
      // 
      // lbl_2
      // 
      this.lbl_2.AutoSize = true;
      this.lbl_2.Location = new System.Drawing.Point(258, 13);
      this.lbl_2.Name = "lbl_2";
      this.lbl_2.Size = new System.Drawing.Size(55, 13);
      this.lbl_2.TabIndex = 1;
      this.lbl_2.Text = "单据日期";
      // 
      // lbl_1
      // 
      this.lbl_1.AutoSize = true;
      this.lbl_1.Location = new System.Drawing.Point(13, 13);
      this.lbl_1.Name = "lbl_1";
      this.lbl_1.Size = new System.Drawing.Size(55, 13);
      this.lbl_1.TabIndex = 0;
      this.lbl_1.Text = "产品大类";
      // 
      // imgr2TableAdapter
      // 
      this.imgr2TableAdapter.ClearBeforeFill = true;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 562);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "OCR";
      this.Load += new System.EventHandler(this.Main_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imgr2BindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.db_Simple_Imgr2DataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button btn_2;
    private System.Windows.Forms.Label lbl_2;
    private System.Windows.Forms.Label lbl_1;
    private System.Windows.Forms.Label lbl_3;
    private System.Windows.Forms.Label lbl_6;
    private System.Windows.Forms.Label lbl_5;
    private System.Windows.Forms.Label lbl_4;
    private System.Windows.Forms.Label lbl_7;
    private System.Windows.Forms.Label lbl_9;
    private System.Windows.Forms.Label lbl_8;
    private System.Windows.Forms.Label lbl_10;
    private System.Windows.Forms.Label lbl_12;
    private System.Windows.Forms.Label lbl_11;
    private System.Windows.Forms.Label lbl_14;
    private System.Windows.Forms.Label lbl_13;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btn_3;
    private System.Windows.Forms.DateTimePicker dtp_2;
    private System.Windows.Forms.TextBox txt_3;
    private System.Windows.Forms.ComboBox cbo_1;
    private System.Windows.Forms.ComboBox cbo_6;
    private System.Windows.Forms.ComboBox cbo_5;
    private System.Windows.Forms.ComboBox cbo_4;
    private System.Windows.Forms.ComboBox cbo_14;
    private System.Windows.Forms.ComboBox cbo_13;
    private System.Windows.Forms.ComboBox cbo_12;
    private System.Windows.Forms.DateTimePicker dtp_9;
    private System.Windows.Forms.ComboBox cbo_11;
    private System.Windows.Forms.ComboBox cbo_8;
    private System.Windows.Forms.ComboBox cbo_10;
    private System.Windows.Forms.ComboBox cbo_7;
    private db_Simple_Imgr2DataSet db_Simple_Imgr2DataSet;
    private System.Windows.Forms.BindingSource imgr2BindingSource;
    private db_Simple_Imgr2DataSetTableAdapters.Imgr2TableAdapter imgr2TableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn trxNoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lineItemNoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn warehouseCodeDataGridViewTextBoxColumn;
  }
}

