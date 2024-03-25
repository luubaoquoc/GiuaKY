using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class TaiLieu
    {
        public string MaXB { get; set; }
        public string TenTL { get; set; }
        public string NhaPH { get; set; }

        // Constructor
        public TaiLieu(string maXB, string tenTL, string nhaPH)
        {
            MaXB = maXB;
            TenTL = tenTL;
            NhaPH = nhaPH;
        }
        public virtual void HienThi()
        {
            Console.WriteLine($" MaXB: {MaXB} | Tên: {TenTL} | NhaPH: {NhaPH}");
        }
    }
}
