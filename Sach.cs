using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class Sach: TaiLieu
    {
        public string TenTG { get; set; }
        public int SoTrang { get; set; }
        public int ID_DM { get; set; }

        // Constructor
        public Sach(string maXB, string tenTL, string nhaPH, string tenTG, int soTrang, int ID_DM)
            : base(maXB, tenTL, nhaPH)
        {
            this.TenTG = tenTG;
            this.SoTrang = soTrang;
            this.ID_DM = ID_DM;
        }
        public static List<Sach> CreateSach()
        {
            return new List<Sach>
            {
                new Sach("XB001", "Lập Trình C#", "NXB A", "Người viết A", 300, 1),
                new Sach("XB002", "Toán Cao Cấp", "NXB B", "Người viết B", 250,1)
        };
        } 
    }
}
