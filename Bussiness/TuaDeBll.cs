using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entity;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class TuaDeBll
    {
        QuanLyThueDiaDataContext db;
        public TuaDeBll()
        {
            db = new QuanLyThueDiaDataContext();
        }

        public List<eTuaDe> GetBasicInf()
        {
            List<eTuaDe> listtuade = new List<eTuaDe>();
            var dstuade = db.TuaDes.ToList<TuaDe>();
            foreach(TuaDe item in dstuade)
            {
                listtuade.Add(new eTuaDe()
                {
                    MaTuaDe = item.MaTuaDe,
                    NoiDungTuaDe = item.NoiDungTuaDe,
                    SoLuongDia = (int)item.SoLuongDia,
                    ImageUrl=item.ImageUrl,
                    MaLoai=item.MaLoai
                });
            }
            return listtuade;
        }

        public List<eTuaDe> GetAll()
        {
            List<eTuaDe> listtuade = new List<eTuaDe>();
            var dsdia = db.TuaDes.ToList<TuaDe>();
            foreach (TuaDe item in dsdia)
            {
                listtuade.Add(new eTuaDe()
                {
                    MaTuaDe = item.MaTuaDe,
                    NoiDungTuaDe=item.NoiDungTuaDe,
                    ImageUrl=item.ImageUrl,
                    SoLuongDia=(int)item.SoLuongDia
                });
            }
            return listtuade;
        }

        public string GetTitleByID(string matuade)
        {
            TuaDe tuade = db.TuaDes.Where(x => x.MaTuaDe == matuade).FirstOrDefault();
            return tuade.NoiDungTuaDe;
        }

        public string GetUrlByID(string matuade)
        {
            TuaDe tuade = db.TuaDes.Where(x => x.MaTuaDe == matuade).FirstOrDefault();
            return tuade.ImageUrl;
        }

        public string LayMaLoaiDia(string matuade)
        {
            TuaDe tua = db.TuaDes.Where(x => x.MaTuaDe == matuade).FirstOrDefault();
            return tua.MaLoai;
        }
        public int SoLuongDiaCuaTuaDe(string matuade)
        {
            List<TuaDe> listtua = db.TuaDes.Where(x => x.MaTuaDe == matuade).ToList();
            return listtua.Count;
        }

        public List<eTuaDe> LayDanhSachTuaDeBoiDanhSachMaTuaDe(List<string> DanhSachMaTuaDe)
        {
            List<eTuaDe> list = new List<eTuaDe>();
            foreach(string item in DanhSachMaTuaDe)
            {
                TuaDe tuade = db.TuaDes.Where(x => x.MaTuaDe == item).FirstOrDefault();
                list.Add(new eTuaDe()
                {
                    MaTuaDe = tuade.MaTuaDe,
                    SoLuongDia = (int)tuade.SoLuongDia,
                    NoiDungTuaDe = tuade.NoiDungTuaDe,
                    ImageUrl = tuade.ImageUrl,
                    MaLoai = tuade.MaLoai
                });
            }
            return list;
        }

        public string LayMaTua(string NoiDungTuaDe)
        {
            TuaDe tuade = db.TuaDes.Where(x => x.NoiDungTuaDe == NoiDungTuaDe).FirstOrDefault();
            return tuade.MaTuaDe;
        }

    }
}
