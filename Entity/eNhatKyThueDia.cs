using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eNhatKyThueDia
    {
        public int ID { get; set; }
        public int MaDia { get; set; }
        public string MaKhachHang { get; set; }
        public DateTime NgayChoThue { get; set; }
        public string MaTua { get; set; }
        public int SoLuongThue { get; set; }
        public decimal TienDatCoc { get; set; }
        public decimal PhiTreHen { get; set; }
        public DateTime NgayTraDia { get; set; }
    }
}
