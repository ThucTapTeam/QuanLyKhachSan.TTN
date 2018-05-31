using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Controller
{
    class DatPhongController
    {
        public void DatPhong()
        {
            
            ChuanHoa ch = new ChuanHoa();
            HotelObject.KhachHangHo kh = new HotelObject.KhachHangHo();
            HotelObject.ThuePhongHo tp = new HotelObject.ThuePhongHo();
            HotelObject.PhongHo p = new HotelObject.PhongHo();
            string day, month, year;
            string day1, month1, year1;
            string day2, month2, year2;
            
            ch.ChuanHoaDate(DateTime.Now.ToString(), out day2, out month2, out year2);
            Connection cn = new Connection();
            
        }
    }
}
