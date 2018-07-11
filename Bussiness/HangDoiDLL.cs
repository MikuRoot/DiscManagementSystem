using System;
using System.Collections.Generic;
using System.Linq;
using Entity;
using DataAccess;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class HangDoiDLL
    {
        QuanLyThueDiaDataContext db;
        public HangDoiDLL()
        {
            db = new QuanLyThueDiaDataContext();
        }
        
        public bool ThemHangDoi(eHangDoi newhangDoi)
        {
            try
            {
                HangDoi hangdoi = new HangDoi();
                hangdoi.MaKhacHangs = newhangDoi.MaKhachHang;
                hangdoi.MaTuaDe = newhangDoi.MaTuaDe;
                hangdoi.ThuTu = newhangDoi.ThuTu;
                hangdoi.SoLuongDat = newhangDoi.SoLuongDat;
                db.HangDois.InsertOnSubmit(hangdoi);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetLastOrder()
        {
            int hangdoi = db.HangDois.ToList().Count;
            return hangdoi;
        }

        public List<string> GetIDCustomerList(string matuade) {

            List<string> idcustomerlist = new List<string>();
            var list = db.HangDois.Where(x=>x.MaTuaDe==matuade).ToList();
            foreach(HangDoi item in list)
            {
                idcustomerlist.Add(item.MaKhacHangs);
            }
            return idcustomerlist;
        }

        public void GoHangDoi(string makh,string matua)
        {
            HangDoi hangdoi = db.HangDois.Where(x => x.MaKhacHangs == makh && x.MaTuaDe == matua).FirstOrDefault();
            db.HangDois.DeleteOnSubmit(hangdoi);
            db.SubmitChanges();
        }

        public void GiamSoLuongDat(string makh,string matua)
        {
            HangDoi hangdoi = db.HangDois.Where(x => x.MaKhacHangs == makh && x.MaTuaDe == matua).FirstOrDefault();
            hangdoi.SoLuongDat -= 1;
            db.SubmitChanges();
        }

        public int LaySoLuongDat(string makh,string matua)
        {
            HangDoi hangdoi = db.HangDois.Where(x => x.MaKhacHangs == makh && x.MaTuaDe == matua).FirstOrDefault();
            if(hangdoi!=null)
                return (int)hangdoi.SoLuongDat;
            return 1;
        }

        public List<string> LayDanhSachMaTuaDe (string makhachhang)
        {
            List<string> IDlist = new List<string>();
            List<HangDoi> listhangdoi = db.HangDois.Where(x => x.MaKhacHangs == makhachhang).ToList();
            foreach(HangDoi hangdoi in listhangdoi)
            {
                IDlist.Add(hangdoi.MaTuaDe);
            }
            return IDlist;
        }

        public bool TangSoLuongDiaDat(string makhachhang, string matuade, int soluong)
        {
            HangDoi hangdoi = db.HangDois.Where(x => x.MaKhacHangs == makhachhang && x.MaTuaDe == matuade).FirstOrDefault();
            try
            {
                hangdoi.SoLuongDat += soluong;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool KhachHangDaDatCho(string makhachhang,string matuade)
        {
            HangDoi hangdoi = db.HangDois.Where(x => x.MaKhacHangs == makhachhang && x.MaTuaDe == matuade).FirstOrDefault();
            if (hangdoi != null)
                return true;
            return false;
        }
    }
}
