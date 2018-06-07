using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan.Layout
{
    public partial class FormDichVu : UserControl
    {
        public FormDichVu()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdDV;

        private void bthemdichvu(object sender, EventArgs e)
        {
            SubLayout.FormThemDichVu ftdv = new SubLayout.FormThemDichVu();
            ftdv.ShowDialog();
            DisplayData();
        }

        #region //G.Hải
        public void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            //if (UserInfo.ChucVu == "Quản Lý")
            //{
                adapt = new SqlDataAdapter("select * from dbo.[dichvu]", con);
            //}
            //else
            //{
            //    adapt = new SqlDataAdapter("select * from dbo.[DICHVU] where Del = 0 ", con);
            //}
            adapt.Fill(dt);
            dataDichVu.DataSource = dt;
            con.Close();
        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            DisplayData();
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile(@"..\img\modified.png");
            delbut.Width = 35;
            delbut.HeaderText = "Sửa";
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataDichVu.Columns.Add(delbut);

            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(@"..\img\delicon.png");
            delbut2.Width = 35;
            delbut2.HeaderText = "Xoá";
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataDichVu.Columns.Add(delbut2);
        }

        private void dataDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDichVu.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                if (dataDichVu.CurrentCell != null && dataDichVu.CurrentCell.Value != null)
                {
                    string name = dataDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string ma = dataDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if ((MessageBox.Show("Xác nhận XOÁ dịch vụ: " + name, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        con.Open();
                        //if (UserInfo.ChucVu == "Quản Lý")
                        //{
                            cmdDV = new SqlCommand("EXECUTE IUD_DICHVU '" + ma + "',N'','',N'Delete'", con);
                        //}
                        //else
                        //{
                        //    cmdDV = new SqlCommand("EXECUTE IUD_DICHVU '" + ma + "',N'','',N'Hide'", con);
                        //}
                        cmdDV.ExecuteNonQuery();
                        con.Close();
                        DisplayData();
                    }
                }
            }
            if (dataDichVu.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                con.Open();
                if (dataDichVu.CurrentCell != null && dataDichVu.CurrentCell.Value != null)
                {
                    if ((MessageBox.Show("Cập nhật thông tin dịch vụ " + dataDichVu.Rows[e.RowIndex].Cells[0].Value.ToString(), "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        HotelObject.getDta_DV.UpdateMode = true;
                        HotelObject.getDta_DV.maDV = dataDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
                        HotelObject.getDta_DV.tenDV = dataDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                        HotelObject.getDta_DV.giaDv = dataDichVu.Rows[e.RowIndex].Cells[2].Value.ToString();

                        SubLayout.FormThemDichVu themDV = new SubLayout.FormThemDichVu();
                        themDV.ShowDialog();
                        HotelObject.getDta_DV.UpdateMode = false;
                        con.Close();
                        DisplayData();
                    }
                }
                con.Close();
            }
            //if (dataDichVu.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            //{
            //    if (dataDichVu.CurrentCell != null && dataDichVu.CurrentCell.Value != null)
            //    {
            //        if (dataDichVu.Rows[e.RowIndex].Cells[7].Value.ToString() == "True")
            //        {
            //            if ((MessageBox.Show("Khôi phục dữ liệu bị ẩn", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            //            {
            //                string ma = dataDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
            //                con.Open();
            //                string maNV = dataDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
            //                cmdDV = new SqlCommand("EXECUTE IUD_DICHVU '" + ma + "',N'','',N'Show'", con);
            //                cmdDV.ExecuteNonQuery();
            //                con.Close();
            //                DisplayData();
            //            }
            //        }
            //    }
            //}
        }
        #endregion
    }
}
