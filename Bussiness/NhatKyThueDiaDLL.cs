using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entity;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class NhatKyThueDiaDLL
    {
        QuanLyThueDiaDataContext db;
        public NhatKyThueDiaDLL()
        {
            db = new QuanLyThueDiaDataContext();
        }
        public bool Save_Disc_Hire_Diary(eNhatKyThueDia newdiary)
        {
            try
            {
                NhatKyThueDia diary = new NhatKyThueDia();
                diary.MaDia = newdiary.MaDia.ToString();
                diary.MaKH = newdiary.MaKhachHang;
                diary.MaTua = newdiary.MaTua;
                diary.NgayChoThue = newdiary.NgayChoThue;
                diary.NgayTraDia = newdiary.NgayTraDia;
                diary.PhiTreHen = newdiary.PhiTreHen;
                diary.SoLuongThue = newdiary.SoLuongThue;
                diary.TienDatCoc = newdiary.TienDatCoc;
                ChinhTrangThaiThueDia(newdiary.MaDia,"Not Available");
                diary.tinhtrangtradia = "Chua tra";
                db.NhatKyThueDias.InsertOnSubmit(diary);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ChinhTrangThaiThueDia(int madia,string status)
        {
            Dia dia = db.Dias.Where(x => x.MaDia == madia).FirstOrDefault();
            dia.TinhTrangThue = status;
            db.SubmitChanges();
        }

        public void GiamSoLuong(string matuade)
        {
            TuaDe tuade = db.TuaDes.Where(x => x.MaTuaDe == matuade).FirstOrDefault();
            tuade.SoLuongDia -= 1;
            db.SubmitChanges();
        }

        public void TangSoLuong(string matuade)
        {
            TuaDe tuade = db.TuaDes.Where(x => x.MaTuaDe == matuade).FirstOrDefault();
            tuade.SoLuongDia += 1;
            db.SubmitChanges();
        }

        public List<eNhatKyThueDia> GetListByID(string id)
        {
            List<NhatKyThueDia> list = db.NhatKyThueDias.Where(x => x.MaKH == id && x.tinhtrangtradia=="Chua tra").ToList();
            List<eNhatKyThueDia> currentlist = new List<eNhatKyThueDia>();
            foreach(NhatKyThueDia item in list)
            {
                currentlist.Add(new eNhatKyThueDia()
                {
                    ID=item.ID,
                    MaDia = Int32.Parse(item.MaDia),
                    MaKhachHang = item.MaKH,
                    NgayChoThue = item.NgayChoThue,
                    MaTua = item.MaTua,
                    SoLuongThue = item.SoLuongThue,
                    TienDatCoc = item.TienDatCoc,
                    PhiTreHen = (decimal)item.PhiTreHen,
                    NgayTraDia = (DateTime)item.NgayTraDia
                });
            }
            return currentlist;
        }

        public List<eNhatKyThueDia> GetList()
        {
            List<NhatKyThueDia> list = db.NhatKyThueDias.Where(x=>x.tinhtrangtradia=="Chua tra").ToList();
            List<eNhatKyThueDia> currentlist = new List<eNhatKyThueDia>();
            foreach (NhatKyThueDia item in list)
            {
                currentlist.Add(new eNhatKyThueDia()
                {
                    ID = item.ID,
                    MaDia = Int32.Parse(item.MaDia),
                    MaKhachHang = item.MaKH,
                    NgayChoThue = item.NgayChoThue,
                    MaTua = item.MaTua,
                    SoLuongThue = item.SoLuongThue,
                    TienDatCoc = item.TienDatCoc,
                    PhiTreHen = (decimal)item.PhiTreHen,
                    NgayTraDia = (DateTime)item.NgayTraDia
                });
            }
            return currentlist;
        }

        public void ThemPhiNoTre(string makh,decimal phitre)
        {
            NhatKyThueDia diary = db.NhatKyThueDias.Where(x => x.MaKH == makh).FirstOrDefault();
            diary.PhiTreHen = phitre;
            db.SubmitChanges();
        }

        public void ChinhSuaTinhTrangTraDia(int manhatky,string text)
        {
            NhatKyThueDia diary = db.NhatKyThueDias.Where(x => x.ID== manhatky).FirstOrDefault();
            diary.tinhtrangtradia = text;
            db.SubmitChanges();
        }
        
        public bool KiemTraMaKhachHangCoThueDiaNayChua(string makh,string matuade)
        {
            NhatKyThueDia nhatkithuedia = db.NhatKyThueDias.Where(x => x.MaKH == makh && x.MaTua == matuade && x.tinhtrangtradia == "Chua tra").FirstOrDefault();
            if (nhatkithuedia != null)
                return true;
            return false;
        }

        public List<eNhatKyThueDia> LayDanhSachKhoanPhiTreCuaKhachHang(string makhachhang)
        {
            List<NhatKyThueDia> list = db.NhatKyThueDias.Where(x => x.tinhtrangtradia == "Chua tra" && x.MaKH == makhachhang && x.PhiTreHen > 0).ToList();
            List<eNhatKyThueDia> currentlist = new List<eNhatKyThueDia>();
            foreach (NhatKyThueDia item in list)
            {
                currentlist.Add(new eNhatKyThueDia()
                {
                    ID = item.ID,
                    MaDia = Int32.Parse(item.MaDia),
                    MaKhachHang = item.MaKH,
                    NgayChoThue = item.NgayChoThue,
                    MaTua = item.MaTua,
                    SoLuongThue = item.SoLuongThue,
                    TienDatCoc = item.TienDatCoc,
                    PhiTreHen = (decimal)item.PhiTreHen,
                    NgayTraDia = (DateTime)item.NgayTraDia
                });
            }
            return currentlist;
        }

        public decimal LayThongTinPhiNoTreCuaKhachHang(string makhachhang)
        {
            List<NhatKyThueDia> nhatkythuedia = db.NhatKyThueDias.Where(x => x.MaKH == makhachhang && x.tinhtrangtradia == "Chua tra" && x.NgayTraDia<DateTime.Now).ToList();
            decimal tongtien = 0;
            foreach(NhatKyThueDia item in nhatkythuedia)
            {
                tongtien += (decimal)0.1* (decimal)item.TienDatCoc;
            }
            return tongtien;
        }
    }
}
