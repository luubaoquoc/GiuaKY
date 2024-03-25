using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class DanhMuc
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // Constructor
        public DanhMuc(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public static List<DanhMuc>CreateDanhMuc()
        {
            return new List<DanhMuc>
            {
                new DanhMuc(1,"Sach"),
                new DanhMuc(2,"Bao"),
                new DanhMuc(3,"Tap Chi")
            };
        }
    }
}
