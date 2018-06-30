using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eDia
    {
        public int ID { get; set; }
        public string TinhTrangThue { get; set; }
        public string TinhTrangDia { get; set; }
        public string MaTuaDe { get; set; }
        public string MaLoai { get; set; }
    }
}
