﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Windows.Forms;

namespace QuanLyKhachSan.Controller
{
    public class DoanhThuController
    {
        ChuanHoa ch = new ChuanHoa();
        HotelObject.ThanhToanHo tt = new HotelObject.ThanhToanHo();
        Connection conn = new Connection();
        string sophong = "0";
        public void DoanhThuTong(BunifuiOSSwitch switchdoanhthu, BunifuDatepicker DPDoanhThu, Label lbdtdatphong, Label lbsophong, Label lbdichvu)
        {

            string day, month, year;

            if (switchdoanhthu.Value == true)
            {
                ch.ChuanHoaDate(DPDoanhThu.Value.ToString(), out day, out month, out year);
                tt.ThanhTien = conn.LayBien("EXEC PROC_SELECT_TONGTIEN '" + year + month + day + "'", 0);
                sophong = conn.LayBien("EXEC PROC_SELECT_SOPHONG '" + year + month + day + "'", 0);
                if (tt.ThanhTien == "")
                {
                    tt.ThanhTien = "0";
                }
                lbdtdatphong.Text = (Int32.Parse(tt.ThanhTien) * 1000).ToString();
                lbsophong.Text = sophong;
            }
            else
            {
                tt.ThanhTien = conn.LayBien("EXEC PROC_SELECT_TONGTIEN1", 0);
                sophong = conn.LayBien("EXEC PROC_SELECT_SOPHONG1", 0);
                if (tt.ThanhTien == "")
                {
                    tt.ThanhTien = "0";
                }
                lbdtdatphong.Text = (Int32.Parse(tt.ThanhTien) * 1000).ToString();
                lbsophong.Text = sophong;
            }
        }
        public void DoanhThuTong1(BunifuiOSSwitch switchdoanhthu, BunifuDatepicker DPDoanhThu, Label lbdtdatphong, Label lbsophong, Label lbdichvu)
        {
            string day, month, year;
            if (switchdoanhthu.Value == true)
            {
                ch.ChuanHoaDate(DPDoanhThu.Value.ToString(), out day, out month, out year);
                tt.ThanhTien = conn.LayBien("EXEC PROC_SELECT_TONGTIEN '" + year + month + day + "'", 0);
                sophong = conn.LayBien("EXEC PROC_SELECT_SOPHONG '" + year + month + day + "'", 0);
                if (tt.ThanhTien == "")
                {
                    tt.ThanhTien = "0";
                }
                lbdtdatphong.Text = (Int32.Parse(tt.ThanhTien) * 1000).ToString();
                lbsophong.Text = sophong;
            }
        }
        string day, month, year, month1, year1;
        public void TyLeDatPhong(Label lbphongthuong,Label lbphongvip,BunifuProgressBar PBphongthuong, BunifuProgressBar PBphongvip)
        {
            
            int sophongthangnay = 0, sophongthangnay1 = 0;
            int sophongthangtruoc = 0, sophongthangtruoc1 = 0;
            ch.ChuanHoaDate(DateTime.Now.ToString(), out day, out month, out year);
            if(month=="1")
            {
                month1 = "12";
                year1= (Convert.ToInt32(year) - 1).ToString();
            }
            else
            {
                month1 = (Convert.ToInt32(month) - 1).ToString();
            }
            
            sophongthangnay = Convert.ToInt32(conn.LayBien("EXEC PROC_TYLEDATPHONG 1,'" + month + "','" + year + "'",0));
            sophongthangtruoc= Convert.ToInt32(conn.LayBien("EXEC PROC_TYLEDATPHONG 1,'" + month1 + "','" + year + "'", 0));
            if (sophongthangnay == 0) sophongthangnay = 1;
            if (sophongthangtruoc == 0) sophongthangtruoc = 1;
            if (sophongthangnay>sophongthangtruoc)
            {
                if (sophongthangtruoc != 0)
                {
                    lbphongthuong.Text = "Tăng  " + (sophongthangnay * 100 / sophongthangtruoc).ToString() + "%";
                    PBphongthuong.Value = (sophongthangnay * 100 / sophongthangtruoc);
                }
                else
                {
                    lbphongthuong.Text = "Tăng 100 %";
                    PBphongthuong.Value = 100;
                }             
            }
            else if (sophongthangnay < sophongthangtruoc)
            {
                if (sophongthangtruoc != 0)
                {
                    lbphongthuong.Text = "Giảm  " + (sophongthangtruoc * 100 / sophongthangnay).ToString() + "%";
                    PBphongthuong.Value = (sophongthangtruoc * 100 / sophongthangnay);
                }
                else
                {
                    lbphongthuong.Text = "Giảm 100 %";
                    PBphongthuong.Value = 100;
                }
                
            }
            else if (sophongthangnay == sophongthangtruoc)
            {
                lbphongthuong.Text = "Không đổi";
                PBphongthuong.Value = 0;
            }


            sophongthangnay1 = Convert.ToInt32(conn.LayBien("EXEC PROC_TYLEDATPHONG 2,'" + month + "','" + year + "'", 0));
            sophongthangtruoc1 = Convert.ToInt32(conn.LayBien("EXEC PROC_TYLEDATPHONG 2,'" + month1 + "','" + year + "'", 0));
            if (sophongthangnay1 == 0) sophongthangnay1 = 1;
            if (sophongthangtruoc1 == 0) sophongthangtruoc1 = 1;
            if (sophongthangnay1 > sophongthangtruoc1)
            {
                if (sophongthangtruoc1 != 0)
                {
                    lbphongvip.Text = "Tăng  " + (sophongthangtruoc1 * 100 / sophongthangnay1).ToString() + "%";
                    PBphongvip.Value = (sophongthangtruoc1 * 100 / sophongthangnay1);
                }
                else
                {
                    lbphongvip.Text = "Tăng 100 %";
                    PBphongvip.Value = 100;
                }
                
            }
            else if (sophongthangnay1 < sophongthangtruoc1)
            {
                if (sophongthangtruoc1 != 0)
                {
                    lbphongvip.Text = "Giảm  " + (sophongthangnay1 * 100 / sophongthangtruoc1).ToString() + "%";
                    PBphongvip.Value = (sophongthangnay1 * 100 / sophongthangtruoc1);
                }
                else
                {
                    lbphongvip.Text = "Giảm 100 %";
                    PBphongvip.Value = 100;
                }
                
            }
            else if (sophongthangnay1 == sophongthangtruoc1)
            {
                lbphongvip.Text = "Không đổi";
                PBphongvip.Value = 0;
            }
        }
        public void TyLeSoLuongKhach(Label lbslktthangtruoc,Label lbslktthangnay,Label lbslkhachtang,BunifuProgressBar PBslkhachtang,Label lbsl)
        {
            ch.ChuanHoaDate(DateTime.Now.ToString(), out day, out month, out year);
            int slktthangtruoc = 0;
            int slktthangnay = 0;
            if (month == "1")
            {
                month1 = "12";
                year1 = (Convert.ToInt32(year) - 1).ToString();
            }
            else
            {
                month1 = (Convert.ToInt32(month) - 1).ToString();
            }
            slktthangtruoc = Convert.ToInt32(conn.LayBien("EXEC PROC_TLSOLUONGKHACH '" + month + "','" + year + "'", 0));
            slktthangnay = Convert.ToInt32(conn.LayBien("EXEC PROC_TLSOLUONGKHACH '" + month1 + "','" + year + "'", 0));
            lbslktthangtruoc.Text = slktthangtruoc.ToString();
            lbslktthangnay.Text = slktthangnay.ToString();

            if (slktthangnay > slktthangtruoc)
            {
                lbsl.Text = "Tăng";
                
                if (slktthangtruoc != 0)
                {
                    lbslkhachtang.Text = (slktthangtruoc * 100 / slktthangnay).ToString() + " %";
                    PBslkhachtang.Value = (slktthangtruoc * 100 / slktthangnay);
                }
                else
                {
                    lbslkhachtang.Text = "100 %";
                    PBslkhachtang.Value = 100;

                }
            }
            else if (slktthangnay < slktthangtruoc)
            {
                lbsl.Text = "Giảm";
                if (slktthangnay != 0)
                {
                    lbslkhachtang.Text = (slktthangnay * 100 / slktthangtruoc).ToString() + " %";
                    PBslkhachtang.Value = (slktthangnay * 100 / slktthangtruoc);
                }
                else
                {
                    lbslkhachtang.Text = "100 %";
                    PBslkhachtang.Value = 100;

                }
                
            }
            else if (slktthangnay == slktthangtruoc)
            {
                lbsl.Text = "Không đổi";
                lbslkhachtang.Text = " ";
                PBslkhachtang.Value = 0;
            }
        }
        public void DoanhThuDichVu(Label lbdtdvthangtrc, Label lbdtdvthangnay, BunifuProgressBar Pbdtdv, Label lbPbdoanhthu,Label dtdvtanggiam)
        {
            ch.ChuanHoaDate(DateTime.Now.ToString(), out day, out month, out year);
            int dtdvthangtruoc = 0;
            int dtdvthangnay = 0;
            if (month == "1")
            {
                month1 = "12";
                year1 = (Convert.ToInt32(year) - 1).ToString();
            }
            else
            {
                month1 = (Convert.ToInt32(month) - 1).ToString();
            }
            dtdvthangtruoc = Convert.ToInt32(conn.LayBien("EXEC PROC_DOANHTHUDICHVU '" + month + "','" + year + "'", 0));
            dtdvthangnay = Convert.ToInt32(conn.LayBien("EXEC PROC_DOANHTHUDICHVU '" + month1 + "','" + year + "'", 0));
            lbdtdvthangtrc.Text = dtdvthangtruoc.ToString();
            lbdtdvthangnay.Text = dtdvthangnay.ToString();
            if (dtdvthangnay > dtdvthangtruoc)
            {
                dtdvtanggiam.Text = "Tăng";
                
                if(dtdvthangtruoc!=0)
                {
                    lbPbdoanhthu.Text = (dtdvthangtruoc * 100 / dtdvthangnay).ToString() + " %";
                    Pbdtdv.Value = (dtdvthangtruoc * 100 / dtdvthangnay);
                }
                else
                {
                    lbPbdoanhthu.Text = "100 %";
                    Pbdtdv.Value = 100;

                }
            }
            else if (dtdvthangnay < dtdvthangtruoc)
            {
                dtdvtanggiam.Text = "Giảm";
                
                if (dtdvthangnay != 0)
                {
                    lbPbdoanhthu.Text = (dtdvthangnay * 100 / dtdvthangtruoc).ToString() + " %";
                    Pbdtdv.Value = (dtdvthangnay * 100 / dtdvthangtruoc);
                }
                else
                {
                    lbPbdoanhthu.Text = "100 %";
                    Pbdtdv.Value = 100;

                }
            }
            else if (dtdvthangnay == dtdvthangtruoc)
            {
                dtdvtanggiam.Text = "Không đổi";
                lbPbdoanhthu.Text = " ";
                Pbdtdv.Value = 0;
            }
        }
    }
}
