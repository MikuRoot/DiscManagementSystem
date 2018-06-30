using System;
using System.Collections.Generic;
using DataAccess;
using Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class DiaBLL
    {
        QuanLyThueDiaDataContext db;
        public DiaBLL()
        {
            db = new QuanLyThueDiaDataContext();
        }
        public List<eDia> GetAllByTitleID(string id)
        {
            List<eDia> listdia = new List<eDia>();
            var dsdia = db.Dias.Where(x => x.IDTuaDe.Equals(id)).ToList();
            foreach(Dia item in dsdia)
            {
                listdia.Add(new eDia()
                {
                    ID = item.MaDia,
                    TinhTrangDia = item.TinhTrangDia,
                    TinhTrangThue = item.TinhTrangThue,
                    MaLoai = item.IDLoaiDia,
                    MaTuaDe = item.IDTuaDe
                });
            }
            return listdia;
        }

        public string GetIDTitle(int id)
        {
            Dia dias = db.Dias.Where(x => x.MaDia == id).FirstOrDefault();
            return dias.IDTuaDe;
        }

        public string GetIDDiscType(int id)
        {
            Dia dias = db.Dias.Where(x => x.MaDia == id).FirstOrDefault();
            return dias.IDLoaiDia;
        }

        public List<eDia> GetAll()
        {
            List<eDia> listdia = new List<eDia>();
            var dsdia = db.Dias.ToList();
            foreach (Dia item in dsdia)
            {
                listdia.Add(new eDia()
                {
                    ID = item.MaDia,
                    TinhTrangDia = item.TinhTrangDia,
                    TinhTrangThue = item.TinhTrangThue,
                    MaLoai = item.IDLoaiDia,
                    MaTuaDe = item.IDTuaDe
                });
            }
            return listdia;
        }
        public void CapNhatTinhTrangDia(int id,string text)
        {
            Dia dia = db.Dias.Where(x => x.MaDia == id).FirstOrDefault();
            dia.TinhTrangDia = text;
            db.SubmitChanges();
        }
    }
}
