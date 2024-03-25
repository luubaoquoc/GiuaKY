using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class TapChi: TaiLieu
    {
        public int SoPH { get; set; }
        public string TenPH { get; set; }
        public int ID_DM { get; set; }

        // Constructor
        public TapChi(string maXB, string tenTL, string nhaPH, int soPH, string tenPH, int ID_DM)
            : base(maXB, tenTL, nhaPH)
        {
            this.SoPH = soPH;
            this.TenPH = tenPH;
            this.ID_DM = ID_DM;
        }

        public static List<TapChi> CreateTapChi()
        {
            return new List<TapChi>
            {
                new TapChi("XB005", "Tạp chí Khoa Học", "NXB E", 1, "Tháng 1",3),
                new TapChi("XB006", "Tạp chí Văn Học", "NXB F", 2, "Tháng 3",3)
        };
        }
    }
}
