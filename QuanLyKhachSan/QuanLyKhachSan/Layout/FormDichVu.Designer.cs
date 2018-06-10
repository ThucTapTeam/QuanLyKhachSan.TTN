namespace QuanLyKhachSan.Layout
{
    partial class FormDichVu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDichVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataDichVu = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataSet_DICHVU = new QuanLyKhachSan.DataSet_DICHVU();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dICHVUTableAdapter = new QuanLyKhachSan.DataSet_DICHVUTableAdapters.DICHVUTableAdapter();
            this.mADICHVUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDICHVUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIATIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DICHVU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxX1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(537, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 31);
            this.panel2.TabIndex = 7;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerDiameter = 9;
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(39, 1);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(200, 26);
            this.textBoxX1.TabIndex = 5;
            this.textBoxX1.WatermarkText = "Tìm kiếm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "DỊCH VỤ";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Thêm dịch vụ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(21, 75);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(229, 40);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Thêm dịch vụ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bthemdichvu);
            // 
            // dataDichVu
            // 
            this.dataDichVu.AllowUserToAddRows = false;
            this.dataDichVu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataDichVu.AutoGenerateColumns = false;
            this.dataDichVu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataDichVu.ColumnHeadersHeight = 25;
            this.dataDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mADICHVUDataGridViewTextBoxColumn,
            this.tENDICHVUDataGridViewTextBoxColumn,
            this.gIATIENDataGridViewTextBoxColumn,
            this.dELDataGridViewCheckBoxColumn});
            this.dataDichVu.DataSource = this.dICHVUBindingSource;
            this.dataDichVu.DoubleBuffered = true;
            this.dataDichVu.EnableHeadersVisualStyles = false;
            this.dataDichVu.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataDichVu.HeaderForeColor = System.Drawing.Color.White;
            this.dataDichVu.Location = new System.Drawing.Point(21, 143);
            this.dataDichVu.Name = "dataDichVu";
            this.dataDichVu.ReadOnly = true;
            this.dataDichVu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDichVu.Size = new System.Drawing.Size(758, 418);
            this.dataDichVu.TabIndex = 9;
            this.dataDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDichVu_CellClick);
            // 
            // dataSet_DICHVU
            // 
            this.dataSet_DICHVU.DataSetName = "DataSet_DICHVU";
            this.dataSet_DICHVU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.dataSet_DICHVU;
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // mADICHVUDataGridViewTextBoxColumn
            // 
            this.mADICHVUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mADICHVUDataGridViewTextBoxColumn.DataPropertyName = "MADICHVU";
            this.mADICHVUDataGridViewTextBoxColumn.HeaderText = "Mã dịch vụ";
            this.mADICHVUDataGridViewTextBoxColumn.Name = "mADICHVUDataGridViewTextBoxColumn";
            this.mADICHVUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENDICHVUDataGridViewTextBoxColumn
            // 
            this.tENDICHVUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tENDICHVUDataGridViewTextBoxColumn.DataPropertyName = "TENDICHVU";
            this.tENDICHVUDataGridViewTextBoxColumn.HeaderText = "Tên dịch vụ";
            this.tENDICHVUDataGridViewTextBoxColumn.Name = "tENDICHVUDataGridViewTextBoxColumn";
            this.tENDICHVUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIATIENDataGridViewTextBoxColumn
            // 
            this.gIATIENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIATIENDataGridViewTextBoxColumn.DataPropertyName = "GIATIEN";
            this.gIATIENDataGridViewTextBoxColumn.HeaderText = "Giá tiền";
            this.gIATIENDataGridViewTextBoxColumn.Name = "gIATIENDataGridViewTextBoxColumn";
            this.gIATIENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dELDataGridViewCheckBoxColumn
            // 
            this.dELDataGridViewCheckBoxColumn.DataPropertyName = "DEL";
            this.dELDataGridViewCheckBoxColumn.HeaderText = "Đã ẩn";
            this.dELDataGridViewCheckBoxColumn.Name = "dELDataGridViewCheckBoxColumn";
            this.dELDataGridViewCheckBoxColumn.ReadOnly = true;
            this.dELDataGridViewCheckBoxColumn.Width = 50;
            // 
            // FormDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataDichVu);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.panel1);
            this.Name = "FormDichVu";
            this.Size = new System.Drawing.Size(800, 591);
            this.Load += new System.EventHandler(this.FormDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DICHVU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataDichVu;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private DataSet_DICHVU dataSet_DICHVU;
        private DataSet_DICHVUTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADICHVUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDICHVUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIATIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dELDataGridViewCheckBoxColumn;
    }
}
