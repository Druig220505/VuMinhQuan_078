using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class NhanVien
    {
        private string Hoten;
        private int _SoNgayCong;
        private int _SoNgayLamThem;
        private string _XepLoai;
        private string _BoPhan;    
        public NhanVien()
        { }
        public NhanVien(string HoTen,int SoNgayCong,int SoNgayLamThem,string XepLoai,string BoPhan)
        {
            this.Hoten = HoTen;
            this._SoNgayCong = SoNgayCong;
            this._SoNgayLamThem = SoNgayLamThem;
            this._XepLoai = XepLoai;
            this._BoPhan = BoPhan;
        }
        public string HoTen
        {
           get { return Hoten; }
            set { Hoten = value; }
        }
        public int SoNgayCong
        {
            get { return _SoNgayCong; }
            set { _SoNgayCong = value; }
        }
        public int SoNgayLamThem
        {
            get { return _SoNgayLamThem; }
            set { _SoNgayLamThem = value; }
        }
        public string XepLoai
        {
            get { return _XepLoai; }
            set { _XepLoai = value; }
        }
        public string BoPhan
        {     
            get { return _BoPhan; }
            set { _BoPhan = value; }
        }
        public double TinhLuong()
        {
            double phanTramTang = (BoPhan == "TrucTiep") ? 3.0 : 2.0;
            double luong1ngay = 100000;
            return (SoNgayCong + SoNgayLamThem * (phanTramTang/100)) * luong1ngay;
        }
        public double TinhThuNhap()
        {
            switch(XepLoai)
            {
                case "1":
                    return 1.5 * TinhLuong();
                case "2":
                    return 1.2 * TinhLuong();
                case "3":
                    return TinhLuong();
                default:
                    return 0;
            }    
        }
        public void InThongTin()
        {
            Console.WriteLine("Họ tên:{0}", HoTen);
            Console.WriteLine("Bộ phận:{0}", BoPhan);
            Console.WriteLine("Thu nhập:{0}", TinhThuNhap());
        }
    }
}
