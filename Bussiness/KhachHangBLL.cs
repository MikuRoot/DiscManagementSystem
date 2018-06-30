using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entity;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class KhachHangBLL
    {
        QuanLyThueDiaDataContext db;

        public KhachHangBLL()
        {
            db = new QuanLyThueDiaDataContext();
        }

        public bool AddACustomer(eKhachHang khachhang)
        {
            try
            {
                KhachHang customer = new KhachHang();
                customer.MaKhachHang = khachhang.MaKhachHang;
                customer.TenKhachHang = khachhang.TenKhachHang;
                customer.SoDienThoai = khachhang.Phone;
                db.KhachHangs.InsertOnSubmit(customer);
                db.SubmitChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public string LayTenKhachHang(string id)
        {
            KhachHang khachhang = db.KhachHangs.Where(x => x.MaKhachHang == id).FirstOrDefault();
            return khachhang.TenKhachHang;
        }

        public string LaySoDienThoaiKhachHang(String id)
        {
            KhachHang khachhang = db.KhachHangs.Where(x => x.MaKhachHang == id).FirstOrDefault();
            return khachhang.SoDienThoai;
        }

        public List<eKhachHang> LayDSKhachHang(List<string> listgot) {

            List<eKhachHang> list = new List<eKhachHang>();

            foreach(string item in listgot)
            {
                KhachHang ItemGotInDB = db.KhachHangs.Where(x => x.MaKhachHang == item).FirstOrDefault();
                list.Add(new eKhachHang()
                {
                    MaKhachHang = ItemGotInDB.MaKhachHang,
                    TenKhachHang = ItemGotInDB.TenKhachHang,
                    Phone = ItemGotInDB.SoDienThoai
                });
            }
            return list;
        }

        public string LayMakh(string name,string sodienthoai)
        {
            KhachHang kh = db.KhachHangs.Where(x => x.TenKhachHang == name && x.SoDienThoai == sodienthoai).FirstOrDefault();
            return kh.MaKhachHang;
        }

        public bool KiemTraTonTaiMaKhachHang(string makh)
        {
            KhachHang khachHang = db.KhachHangs.Where(x => x.MaKhachHang == makh).FirstOrDefault();
            if (khachHang != null)
                return true;
            return false;
        }

        public List<eKhachHang> LayDanhSachKhachHangBangMaHoacTenHoacSDT(string IDNameOrPhoneNumber)
        {
            List<eKhachHang> danhsachkhachhanglayduoc = new List<eKhachHang>();
            List<KhachHang> danhsachkhachhang = db.KhachHangs.Where(x => x.MaKhachHang.Contains(IDNameOrPhoneNumber) || x.TenKhachHang.Contains(IDNameOrPhoneNumber) || x.SoDienThoai.Contains(IDNameOrPhoneNumber)).ToList();
            foreach(KhachHang item in danhsachkhachhang)
            {
                danhsachkhachhanglayduoc.Add(new eKhachHang()
                {
                    MaKhachHang = item.MaKhachHang,
                    TenKhachHang = item.TenKhachHang,
                    Phone = item.SoDienThoai
                });
            }
            return danhsachkhachhanglayduoc;
        }

        public bool ThayDoiThongTinKhachHang(eKhachHang khachhang)
        {
            try
            {
                KhachHang khachhangs = db.KhachHangs.Where(x => x.MaKhachHang == khachhang.MaKhachHang).FirstOrDefault();
                khachhangs.TenKhachHang = khachhang.TenKhachHang;
                khachhangs.SoDienThoai = khachhang.Phone;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
