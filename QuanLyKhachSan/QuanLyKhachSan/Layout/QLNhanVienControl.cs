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
    public partial class QLNhanVienControl : UserControl
    {
        public QLNhanVienControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdNV;
        bool status = false;

        private void btthemnv_Click(object sender, EventArgs e)
        {
            SubLayout.FormThemNV themNV = new SubLayout.FormThemNV();
            themNV.ShowDialog();
            DisplayData();
        }

        private void QLNhanVienControl_Load(object sender, EventArgs e)
        {
            DisplayData();
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile(@"..\img\modified.png");
            delbut.Width = 35;
            delbut.HeaderText = "Sửa";
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataNhanVien.Columns.Add(delbut);

            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(@"..\img\delicon.png");
            delbut2.Width = 35;
            delbut2.HeaderText = "Xoá";
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataNhanVien.Columns.Add(delbut2);
        }
        public void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            if (status == true)
            {
                adapt = new SqlDataAdapter("select * from dbo.[NHANVIEN]", con);
            }
            else
            {
                adapt = new SqlDataAdapter("select * from dbo.[NHANVIEN] where Del = 0 ", con);
            }
            adapt.Fill(dt);
            dataNhanVien.DataSource = dt;
            con.Close();
        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataNhanVien.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
            {
                con.Open();
                if (dataNhanVien.CurrentCell != null && dataNhanVien.CurrentCell.Value != null)
                {
                    string del = dataNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if ((MessageBox.Show("Xác nhận XOÁ toàn bộ thông tin của khách hàng: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        cmdNV = new SqlCommand("EXECUTE IUD_NHANVIEN '" + del + "',N'',N'',N'','','','',N'Delete'", con);
                        cmdNV.ExecuteNonQuery();
                    }
                }
                con.Close();
                DisplayData();
            }
            if (dataNhanVien.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                con.Open();
                if (dataNhanVien.CurrentCell != null && dataNhanVien.CurrentCell.Value != null)
                {
                    if ((MessageBox.Show("Cập nhật thông tin nhân viên " + dataNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString(), "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        HotelObject.getDta_NV.UpdateMode = true;
                        HotelObject.getDta_NV.maNV = dataNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                        HotelObject.getDta_NV.hoTen = dataNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                        HotelObject.getDta_NV.chucVu = dataNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                        HotelObject.getDta_NV.gioiTinh = dataNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                        HotelObject.getDta_NV.avt = dataNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                        HotelObject.getDta_NV.NS = dataNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                        HotelObject.getDta_NV.SDT = dataNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();

                        SubLayout.FormThemNV themNV = new SubLayout.FormThemNV();
                        themNV.ShowDialog();
                        HotelObject.getDta_NV.UpdateMode = false;
                        con.Close();
                        DisplayData();
                    }
                }
                con.Close();
            }
            if (dataNhanVien.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (dataNhanVien.CurrentCell != null && dataNhanVien.CurrentCell.Value != null)
                {
                    con.Open();
                    if (dataNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString() == "True")
                    {
                        if ((MessageBox.Show("Khôi phục dữ liệu bị ẩn", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            string maNV = dataNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                            cmdNV = new SqlCommand("EXECUTE IUD_NHANVIEN '" + maNV + "',N'',N'',N'','','','',N'Show'", con);
                            cmdNV.ExecuteNonQuery();
                        }
                        con.Close();
                        DisplayData();
                    }
                    else
                    {
                        if ((MessageBox.Show("Xác nhận ẨN nhân viên", "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            string maNV = dataNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                            cmdNV = new SqlCommand("EXECUTE IUD_NHANVIEN '" + maNV + "',N'',N'',N'','','','',N'Hide'", con);
                            cmdNV.ExecuteNonQuery();
                        }
                        con.Close();
                        DisplayData();
                    }
                }
            }
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (Check.Value == true) status = true;
            else status = false;
            DisplayData();
        }
    }
}
