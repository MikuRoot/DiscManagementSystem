using System;
using System.Collections.Generic;
using System.Linq;
using Entity;
using DataAccess;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class NhatKyGhinoDLL
    {
        QuanLyThueDiaDataContext db;
        public NhatKyGhinoDLL()
        {
            db = new QuanLyThueDiaDataContext();
        }
        public List<eNhatKyGhiNo> GetList(string makh)
        {
            List<eNhatKyGhiNo> list = new List<eNhatKyGhiNo>();
            var listgot = db.NhatKyGhiNos.Where(x => x.IDKhachHang == makh).ToList<NhatKyGhiNo>();
            foreach(NhatKyGhiNo item in listgot)
            {
                list.Add(new eNhatKyGhiNo()
                {
                    ID = item.ID,
                    IDDia = (int)item.IDDia,
                    IDKhachHang = item.IDKhachHang,
                    SoTienNo = item.SoTienNo
                });
            }
            return list;
        }

        public decimal LayTongPhiTre(int id)
        {
            NhatKyGhiNo nhatkyghinos = db.NhatKyGhiNos.Where(x => x.ID == id).FirstOrDefault();
            return nhatkyghinos.SoTienNo;
        }

        public bool SuaThongTinNo(eNhatKyGhiNo diary)
        {
            try
            {
                NhatKyGhiNo olddiary = db.NhatKyGhiNos.Where(x => x.IDKhachHang == diary.IDKhachHang).FirstOrDefault();
                olddiary.SoTienNo = diary.SoTienNo;
                db.SubmitChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool ThemThongTinNo(eNhatKyGhiNo diary)
        {
            NhatKyGhiNo nhatKy = db.NhatKyGhiNos.Where(x => x.IDKhachHang == diary.IDKhachHang).FirstOrDefault();
            if (nhatKy.SoTienNo >= 0)
            {
                nhatKy.SoTienNo += diary.SoTienNo;
            }
            else if (nhatKy == null)
            {
                NhatKyGhiNo nhatKyGhiNo = new NhatKyGhiNo();
                nhatKyGhiNo.IDDia = diary.IDDia;
                nhatKyGhiNo.IDKhachHang = diary.IDKhachHang;
                nhatKyGhiNo.SoTienNo = diary.SoTienNo;
                db.NhatKyGhiNos.InsertOnSubmit(nhatKyGhiNo);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool ThanhToanMuon(string makhachhang)
        {
            try
            {
                NhatKyGhiNo nhatkyghino = db.NhatKyGhiNos.Where(x => x.IDKhachHang == makhachhang).FirstOrDefault();
                db.NhatKyGhiNos.DeleteOnSubmit(nhatkyghino);
                db.SubmitChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public decimal LayTongPhiTreCuaKhachHang(string makhachhang)
        {
            try
            {
                NhatKyGhiNo nhatkyghino = db.NhatKyGhiNos.Where(x => x.IDKhachHang == makhachhang).FirstOrDefault();
                return nhatkyghino.SoTienNo;
            }
            catch(Exception)
            {
                return 0;
            }
        }
    }
}
