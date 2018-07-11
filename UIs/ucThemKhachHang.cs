using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Entity;
using Bussiness;
using System.Data;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class ucThemKhachHang : UserControl
    {
        KhachHangBLL khachhangbll = new KhachHangBLL();

        public ucThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnthemkhachhang_Click(object sender, EventArgs e)
        {
            Regex kiemtraten = new Regex(@"[a-zA-Z\s]");
            Regex kiemtrasodienthoai = new Regex(@"^(09|01[2|6|8|9])+([0-9]{8})\b$");
            if (!kiemtraten.IsMatch(txttenkhachhang.Text))
            {
                txttenkhachhang.Text = "Tên khách hàng không hợp lệ";
                txttenkhachhang.ForeColor = Color.Red;
            }
            if (!kiemtrasodienthoai.IsMatch(txtsodienthoai.Text))
            {
                txtsodienthoai.Text = "Số điện thoại không hợp lệ,xin vui lòng nhập lại";
                txtsodienthoai.ForeColor = Color.Red;
            }
            if (kiemtraten.IsMatch(txttenkhachhang.Text) && kiemtrasodienthoai.IsMatch(txtsodienthoai.Text))
            {
                eKhachHang khachhang = new eKhachHang();
                string makh = GenerateAnID(RandANumber(0, 1000), "KH");
                khachhang.MaKhachHang = makh;
                khachhang.TenKhachHang = txttenkhachhang.Text;
                khachhang.Phone = txtsodienthoai.Text;
                if (khachhangbll.AddACustomer(khachhang))
                {
                    lblmakhachhang.Text = makh;
                    txtsodienthoai.Clear();
                    txttenkhachhang.Clear();
                }
                else
                    lblmakhachhang.Text = "";
            }
        }

        private int RandANumber(int first, int last)
        {
            Random rand = new Random();
            return rand.Next(first, last);
        }

        private string GenerateAnID(int randnumber, string textkey)
        {
            return textkey + "" + randnumber.ToString();
        }

        private void txttenkhachhang_TextChanged(object sender, EventArgs e)
        {
            if (txttenkhachhang.Text == "" || txttenkhachhang.Text == "Tên khách hàng")
            {
                btnthemkhachhang.Enabled = false;
            }
            else
                btnthemkhachhang.Enabled = true;
        }

        private void txtsodienthoai_TextChanged(object sender, EventArgs e)
        {
            if (txtsodienthoai.Text == "" || txtsodienthoai.Text == "Số điện thoại")
            {
                btnthemkhachhang.Enabled = false;
            }
            else
                btnthemkhachhang.Enabled = true;
        }

        private void txttenkhachhang_Click(object sender, EventArgs e)
        {
            if (txttenkhachhang.Text == "Tên khách hàng" ||txttenkhachhang.Text== "Vui lòng nhập tên khách hàng")
            {
                txttenkhachhang.Clear();
            }
        }

        private void txtsodienthoai_Click(object sender, EventArgs e)
        {
            if (txtsodienthoai.Text == "Số điện thoại" || txtsodienthoai.Text=="Vui lòng nhập số điện thoại")
            {
                txtsodienthoai.Clear();
            }
        }

        private void btnvehome_Click(object sender, EventArgs e)
        {

        }

        private void txttenkhachhang_Leave(object sender, EventArgs e)
        {
            if (txttenkhachhang.Text == "")
            {
                txttenkhachhang.Text = "Vui lòng nhập tên khách hàng";
            }
        }

        private void txtsodienthoai_Leave(object sender, EventArgs e)
        {
            if (txtsodienthoai.Text == "")
            {
                txtsodienthoai.Text = "Vui lòng nhập số điện thoại";
            }
        }
    }
}
