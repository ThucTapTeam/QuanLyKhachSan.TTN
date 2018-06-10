using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Layout.SubLayout
{
    public partial class FormThemNV : Form
    {
        public FormThemNV()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        SqlCommand cmdNV;
        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing 
                // a drop shadow around the form 
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void close_Hover(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../img/Close1.png");
        }

        private void close_Leave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../img/Close.png");
        }

        private void mini_Hover(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("../img/Minimize1.png");
        }

        private void mini_Leave(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("../img/Minimize.png");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        string linkavatar = "../img/avatar1.jpg";
        private void btchonanh_Click(object sender, EventArgs e)
        {
            if (fileAvatar.ShowDialog() == DialogResult.OK)
            {
                pbavatar.Image = Image.FromFile(fileAvatar.FileName);
                label8.Text = fileAvatar.SafeFileName;
                linkavatar= fileAvatar.FileName;
            }
        }

        private void btdatphong_Click(object sender, EventArgs e)
        {
            Controller.ThemNVController themnv = new Controller.ThemNVController();
            int transfer;
            themnv.ThemNhanVien(tbhoten, ddGioiTinh, tbpass, tbphone, DPNgaySinh, ddchucvu, linkavatar, out transfer);
            if (transfer == 1)
            {
                this.Hide();
            }
        }

        private void FormThemNV_Load(object sender, EventArgs e)
        {
            if (HotelObject.getDta_NV.UpdateMode == true)
            {
                tbpass.Enabled = false;
                tbhoten.Text = HotelObject.getDta_NV.hoTen;
                if (HotelObject.getDta_NV.gioiTinh == "Nam")
                    ddGioiTinh.selectedIndex = 0;
                else
                    ddGioiTinh.selectedIndex = 1;
                tbphone.Text = HotelObject.getDta_NV.SDT;
                DPNgaySinh.Value = Convert.ToDateTime(HotelObject.getDta_NV.NS);
                if (HotelObject.getDta_NV.chucVu == "Nhân Viên")
                    ddchucvu.selectedIndex = 0;
                else if (HotelObject.getDta_NV.chucVu == "Lễ Tân")
                    ddchucvu.selectedIndex = 1;
                else
                    ddchucvu.selectedIndex = 2;
                pbavatar.Image = Image.FromFile(HotelObject.getDta_NV.avt);
                label8.Text = HotelObject.getDta_NV.avt;
            }
            else
                btnUpdate.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChuanHoa ch = new ChuanHoa();
            if (ch.Check_Phone(tbphone) == false)
            {
                Notification dialog = new Notification("LỖI", "Không được để trống", "Mời bạn nhập đầy đủ họ tên và SDT.");
                dialog.ShowDialog();
            }
            else if (ch.Check_Text_Name(tbhoten) == false)
            {
                MessageBox.Show("Yêu cầu nhập đúng định dạng tên không được kèm số, ký hiệu đặc biệt");
            }
            else
            {
                //if ((MessageBox.Show(", "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                con.Open();
                cmdNV = new SqlCommand("EXECUTE IUD_NHANVIEN '" + HotelObject.getDta_NV.maNV + "',N'" + tbhoten.Text + "',N'" + ddchucvu.selectedValue +
                                        "',N'" + ddGioiTinh.selectedValue + "','" + linkavatar + "','" + DPNgaySinh.Value + "','" + tbphone.Text + "',N'Update'", con);
                cmdNV.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cập nhật thành công");
                this.Hide();
            }
        }
    }
}
