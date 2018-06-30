using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eTuaDe
    {
        public string MaTuaDe { get; set; }
        public int SoLuongDia { get; set; }
        public string NoiDungTuaDe { get; set; }
        public string ImageUrl { get; set; }
        public string MaLoai { get; set; }
    }
}
