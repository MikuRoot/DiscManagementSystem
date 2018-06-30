using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eLoaiDia
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public int ThoiGianChoPhepThue { get; set; }
        public decimal Gia { get; set; }
    }
}
