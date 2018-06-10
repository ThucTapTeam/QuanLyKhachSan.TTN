﻿namespace QuanLyKhachSan.Layout
{
    partial class QLNhanVienControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNhanVienControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataNhanVien = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.Check = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.dataSet_NV = new QuanLyKhachSan.DataSet_NV();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QuanLyKhachSan.DataSet_NVTableAdapters.NHANVIENTableAdapter();
            this.mANHANVIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUCVUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVATARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sODIENTHOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Thêm nhân viên";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(20, 76);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(229, 40);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Thêm nhân viên";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.btthemnv_Click);
            // 
            // dataNhanVien
            // 
            this.dataNhanVien.AllowUserToAddRows = false;
            this.dataNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataNhanVien.AutoGenerateColumns = false;
            this.dataNhanVien.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataNhanVien.ColumnHeadersHeight = 30;
            this.dataNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANHANVIENDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.cHUCVUDataGridViewTextBoxColumn,
            this.gIOITINHDataGridViewTextBoxColumn,
            this.aVATARDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.sODIENTHOAIDataGridViewTextBoxColumn,
            this.dELDataGridViewCheckBoxColumn});
            this.dataNhanVien.DataSource = this.nHANVIENBindingSource;
            this.dataNhanVien.DoubleBuffered = true;
            this.dataNhanVien.EnableHeadersVisualStyles = false;
            this.dataNhanVien.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataNhanVien.HeaderForeColor = System.Drawing.Color.White;
            this.dataNhanVien.Location = new System.Drawing.Point(19, 145);
            this.dataNhanVien.Name = "dataNhanVien";
            this.dataNhanVien.ReadOnly = true;
            this.dataNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataNhanVien.Size = new System.Drawing.Size(758, 418);
            this.dataNhanVien.TabIndex = 3;
            this.dataNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dữ liệu bị ẩn";
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.Transparent;
            this.Check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Check.BackgroundImage")));
            this.Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check.Location = new System.Drawing.Point(742, 87);
            this.Check.Name = "Check";
            this.Check.OffColor = System.Drawing.Color.Gray;
            this.Check.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.Check.Size = new System.Drawing.Size(35, 20);
            this.Check.TabIndex = 5;
            this.Check.Value = false;
            this.Check.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // dataSet_NV
            // 
            this.dataSet_NV.DataSetName = "DataSet_NV";
            this.dataSet_NV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dataSet_NV;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mANHANVIENDataGridViewTextBoxColumn
            // 
            this.mANHANVIENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mANHANVIENDataGridViewTextBoxColumn.DataPropertyName = "MANHANVIEN";
            this.mANHANVIENDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.mANHANVIENDataGridViewTextBoxColumn.Name = "mANHANVIENDataGridViewTextBoxColumn";
            this.mANHANVIENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "Tên NV";
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            this.hOTENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cHUCVUDataGridViewTextBoxColumn
            // 
            this.cHUCVUDataGridViewTextBoxColumn.DataPropertyName = "CHUCVU";
            this.cHUCVUDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            this.cHUCVUDataGridViewTextBoxColumn.Name = "cHUCVUDataGridViewTextBoxColumn";
            this.cHUCVUDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHUCVUDataGridViewTextBoxColumn.Width = 60;
            // 
            // gIOITINHDataGridViewTextBoxColumn
            // 
            this.gIOITINHDataGridViewTextBoxColumn.DataPropertyName = "GIOITINH";
            this.gIOITINHDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gIOITINHDataGridViewTextBoxColumn.Name = "gIOITINHDataGridViewTextBoxColumn";
            this.gIOITINHDataGridViewTextBoxColumn.ReadOnly = true;
            this.gIOITINHDataGridViewTextBoxColumn.Width = 80;
            // 
            // aVATARDataGridViewTextBoxColumn
            // 
            this.aVATARDataGridViewTextBoxColumn.DataPropertyName = "AVATAR";
            this.aVATARDataGridViewTextBoxColumn.HeaderText = "Avatar";
            this.aVATARDataGridViewTextBoxColumn.Name = "aVATARDataGridViewTextBoxColumn";
            this.aVATARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            this.nGAYSINHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sODIENTHOAIDataGridViewTextBoxColumn
            // 
            this.sODIENTHOAIDataGridViewTextBoxColumn.DataPropertyName = "SODIENTHOAI";
            this.sODIENTHOAIDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sODIENTHOAIDataGridViewTextBoxColumn.Name = "sODIENTHOAIDataGridViewTextBoxColumn";
            this.sODIENTHOAIDataGridViewTextBoxColumn.ReadOnly = true;
            this.sODIENTHOAIDataGridViewTextBoxColumn.Width = 70;
            // 
            // dELDataGridViewCheckBoxColumn
            // 
            this.dELDataGridViewCheckBoxColumn.DataPropertyName = "DEL";
            this.dELDataGridViewCheckBoxColumn.HeaderText = "Chọn ẩn";
            this.dELDataGridViewCheckBoxColumn.Name = "dELDataGridViewCheckBoxColumn";
            this.dELDataGridViewCheckBoxColumn.ReadOnly = true;
            this.dELDataGridViewCheckBoxColumn.Width = 35;
            // 
            // QLNhanVienControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.dataNhanVien);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.panel1);
            this.Name = "QLNhanVienControl";
            this.Size = new System.Drawing.Size(800, 591);
            this.Load += new System.EventHandler(this.QLNhanVienControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataNhanVien;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuiOSSwitch Check;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DataSet_NV dataSet_NV;
        private DataSet_NVTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANHANVIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHUCVUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVATARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sODIENTHOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dELDataGridViewCheckBoxColumn;
    }
}
