﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Layout.SubLayout
{
    public partial class FormThanhToan : Form
    {
        string laytenphong;
        public FormThanhToan(string tenphong,int sotang)
        {
            InitializeComponent();
            
        }
        Connection conn = new Connection();
        private void btthanhtoan_Click(object sender, EventArgs e)
        {
            
            this.Hide();     
        }

    }
}
