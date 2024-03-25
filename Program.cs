using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            List<DanhMuc> danhMucs236 = DanhMuc.CreateDanhMuc();
            List<TaiLieu> taiLieus236 = new List<TaiLieu>();
            // Thêm sách vào danh sách tài liệu
            taiLieus236.AddRange(Sach.CreateSach());
            taiLieus236.Add(new Sach("XB007", "Lập Trình C#", "NXB A", "Người viết A", 300,1));
            // Thêm báo vào danh sách tài liệu
            taiLieus236.AddRange(Bao.CreateBao());
            taiLieus236.Add(new Bao("XB003", "Báo Thời Đại", "NXB C", new DateTime(2022, 5, 25),2));

            // Thêm tạp chí vào danh sách tài liệu
            taiLieus236.AddRange(TapChi.CreateTapChi());

            // In danh sách tài liệu
            Console.WriteLine("Danh sách tài liệu:");
            foreach (var taiLieu in taiLieus236)
            {
                if (taiLieu is Sach)
                {
                    var sach = taiLieu as Sach;
                    Console.WriteLine($"Loại: Sách, Mã XB: {sach.MaXB}, Tên TL: {sach.TenTL}, Tác giả: {sach.TenTG}, Số trang: {sach.SoTrang}");
                }
                else if (taiLieu is Bao)
                {
                    var bao = taiLieu as Bao;
                    Console.WriteLine($"Loại: Báo, Mã XB: {bao.MaXB}, Tên TL: {bao.TenTL}, Ngày PH: {bao.NgayPH}");
                }
                else if (taiLieu is TapChi)
                {
                    var tapChi = taiLieu as TapChi;
                    Console.WriteLine($"Loại: Tạp chí, Mã XB: {tapChi.MaXB}, Tên TL: {tapChi.TenTL}, Số PH: {tapChi.SoPH}, Tên PH: {tapChi.TenPH}");
                }
            }

            Console.WriteLine("");

            while (true)
            {


                Console.WriteLine("Lựa Chọn");
                Console.WriteLine("1. Tìm kiếm theo danh mục");
                Console.WriteLine("2. Tìm kiếm các báo có ngày phát hành trong tháng 3");
                Console.WriteLine( "");
                Console.Write("Nhập lựa chọn: ");
                int luachon = int.Parse(Console.ReadLine());

                switch (luachon)
                {
                    case 1:
                        // 2.2. Tìm theo danh mục 

                        Console.WriteLine("Nhập mã danh mục:");
                        int input = int.Parse(Console.ReadLine());
                        var result_243 = from tl in taiLieus236
                                         where tl is Bao && (tl as Bao).ID_DM == input
                                            || tl is Sach && (tl as Sach).ID_DM == input
                                            || tl is TapChi && (tl as TapChi).ID_DM == input
                                         select tl;

                        Console.WriteLine("Các tài liệu trong danh mục:");
                        foreach (var tl in result_243)
                        {
                            tl.HienThi();
                        }

                        break;

                    case 2:
                        Console.WriteLine("\n");
                        // Tìm các báo có ngày phát hành trong tháng 3
                        var baoTrongThang3 = from bao in taiLieus236.OfType<Bao>()
                                             where bao.NgayPH.Year == 2024 && bao.NgayPH.Month == 3
                                             select bao;

                        // In danh sách các báo có ngày phát hành trong tháng 3
                        Console.WriteLine("Danh sách báo có ngày phát hành trong tháng 3:");
                        foreach (var bao in baoTrongThang3)
                        {
                            Console.WriteLine($" Mã XB: {bao.MaXB} | Tên TL: {bao.TenTL} | Ngày PH: {bao.NgayPH}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Mã danh mục không tồn tại.");
                        return;
                        
                    default:
                        Console.WriteLine("Chọn sai mời chọn lại");
                        break;



                }
                Console.WriteLine("");

            }
            
            Console.ReadLine();
        }
    }
}
