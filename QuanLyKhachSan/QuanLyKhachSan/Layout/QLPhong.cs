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
    public partial class QLPhong : UserControl
    {
        public QLPhong()
        {
            InitializeComponent();
        }

        public void DisplayData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
            SqlDataAdapter adapt;
            SqlCommand cmdDV;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[phong]", con);
            adapt.Fill(dt);
            dataPhong.DataSource = dt;
            con.Close();
        }

        private void btthemdichvu_Click(object sender, EventArgs e)
        {
            SubLayout.FormThemDichVuPhong ftdvp = new SubLayout.FormThemDichVuPhong();
            ftdvp.ShowDialog();
            DisplayData();
        }

        private void QLPhong_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
