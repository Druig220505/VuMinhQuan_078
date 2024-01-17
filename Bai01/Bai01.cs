using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Bai01
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NhanVien nv1 = new NhanVien();
            Console.Write("Nhập họ tên:");
            nv1.HoTen = Console.ReadLine();
            Console.Write("Nhập số ngày công:");
            nv1.SoNgayCong =int.Parse(Console.ReadLine());
            Console.Write("Nhập số ngày làm thêm:");
            nv1.SoNgayLamThem = int.Parse(Console.ReadLine());
            Console.Write("Nhập xếp loại(A=1/B=2/C=3):");
            nv1.XepLoai = Console.ReadLine();
            Console.Write("Nhập bộ phận(Trực tiếp/Gián tiếp):");
            nv1.BoPhan = Console.ReadLine();
            nv1.InThongTin();
            NhanVien nv2 = new NhanVien("Nguyễn Văn Tèo",20,4,"1","Trực tiếp");
            nv2.InThongTin();
            Console.ReadLine();
        }
    }
}
