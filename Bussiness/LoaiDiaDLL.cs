using System;
using System.Collections.Generic;
using System.Linq;
using Entity;
using DataAccess;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class LoaiDiaDLL
    {
        QuanLyThueDiaDataContext db;
        public LoaiDiaDLL()
        {
            db = new QuanLyThueDiaDataContext();
        }
        public string GetTenLoaiByID(string id)
        {
            LoaiDia loaidia = db.LoaiDias.Where(x => x.MaLoai == id).FirstOrDefault();
            return loaidia.TenLoai;
        }
        public int SoNgayChoPhepThue(string id)
        {
            LoaiDia loaidia = db.LoaiDias.Where(x => x.MaLoai == id).FirstOrDefault();
            return loaidia.ThoiGianChoPhepThue;
        }
        public decimal LayGia(string id)
        {
            LoaiDia loaidia = db.LoaiDias.Where(x => x.MaLoai == id).FirstOrDefault();
            return loaidia.GiaThue;
        }
    }
}
