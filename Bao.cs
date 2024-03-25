using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class Bao: TaiLieu
    {
        public DateTime NgayPH { get; set; }
        public int ID_DM { get; set; }

        // Constructor
        public Bao(string maXB, string tenTL, string nhaPH, DateTime ngayPH, int ID_DM)
            : base(maXB, tenTL, nhaPH)
        {
            NgayPH = ngayPH;
            this.ID_DM = ID_DM;
        }

        public static List<Bao> CreateBao()
        {
            return new List<Bao>
            {
                new Bao("XB003", "Báo Thời Đại", "NXB C", new DateTime (2019,3,25), 2),
                new Bao("XB004", "Báo Tuổi Trẻ",  "NXB D", DateTime.Now, 2)
        };
        }
    }
}
