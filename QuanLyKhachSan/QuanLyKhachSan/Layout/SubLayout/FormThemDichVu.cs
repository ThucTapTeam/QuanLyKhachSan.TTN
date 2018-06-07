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
    public partial class FormThemDichVu : Form
    {
        public FormThemDichVu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        SqlCommand cmdDV;
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

        private void btchapnhan_Click(object sender, EventArgs e)
        {
            int transfer;
            Controller.ThemDVController tdv = new Controller.ThemDVController();
            tdv.ThemDichVu(tbtendv, tbgiatien, out transfer);
            if (transfer == 1)
            {
                this.Hide();
            }
        }

        private void FormThemDichVu_Load(object sender, EventArgs e)
        {
            if (HotelObject.getDta_DV.UpdateMode == true)
            {
                bunifuFlatButton1.Visible = false;
                label3.Text = "Tên trước đó: " + HotelObject.getDta_DV.tenDV;
                label6.Text = "Giá trước đó: " + HotelObject.getDta_DV.giaDv;
                tbtendv.Text = HotelObject.getDta_DV.tenDV;
                tbgiatien.Text = HotelObject.getDta_DV.giaDv;
            }
            else
            {
                btnUpdate.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChuanHoa ch = new ChuanHoa();
            HotelObject.DichVuHo dv = new HotelObject.DichVuHo();
            if (tbtendv.Text.Length == 0 || tbgiatien.Text.Length == 0)
            {
                Notification nf = new Notification("LỖI", "Không được để trống các trường.", "Mời bạn nhập đầy đủ.");
                nf.Show();
            }
            else
            {
                if (ch.Check_Text_Name(tbtendv) == false)
                {
                    Notification nf = new Notification("LỖI", "Tên dịch vụ chứa chữ số.", "Mời bạn nhập lại.");
                    nf.Show();
                }
                else if (ch.Check_Number(tbgiatien) == false)
                {
                    Notification nf = new Notification("LỖI", "Gía tiền chỉ được nhập số.", "Mời bạn nhập lại.");
                    nf.Show();
                }
                else
                {
                    con.Open();
                    cmdDV = new SqlCommand("EXECUTE IUD_DICHVU '" + HotelObject.getDta_DV.maDV + "',N'" + tbtendv.Text + "','" + tbgiatien.Text + "',N'Update'", con);
                    cmdDV.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cập nhật thành công");
                    this.Hide();
                }
            }
        }
    }
}
