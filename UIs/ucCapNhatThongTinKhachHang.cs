using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Bussiness;
using Entity;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class ucCapNhatThongTinKhachHang : UserControl
    {
        KhachHangBLL khachhangbll = new KhachHangBLL();

        public ucCapNhatThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void LoadDataGridView(string Name_Id_Or_PhoneNumber)
        {
            dataGridView1.DataSource = khachhangbll.LayDanhSachKhachHangBangMaHoacTenHoacSDT(Name_Id_Or_PhoneNumber);
        }

        private void txttenhoacmakhachhang_TextChanged(object sender, EventArgs e)
        {
            if (txttenhoacmakhachhang.Text != "" && txttenhoacmakhachhang.Text != "Vùng nhập liệu không có dữ liệu cần thiết để thực hiện" && txttenhoacmakhachhang.Text != "Không được để trống")
            {
                LoadDataGridView(txttenhoacmakhachhang.Text);
                btnluu.Enabled = true;
            }
        }

        private void txttenhoacmakhachhang_Click(object sender, EventArgs e)
        {
            if (txttenhoacmakhachhang.Text == "" || txttenhoacmakhachhang.Text == "Vùng nhập liệu không có dữ liệu cần thiết để thực hiện" || txttenhoacmakhachhang.Text == "Không được để trống")
            {
                txttenhoacmakhachhang.Clear();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            lblmakhachhang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttenkhachhang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsodienthoai.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnluu_Click(object sender, EventArgs e)
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
                txtsodienthoai.Text = "Số điện thoại không hợp lệ";
                txtsodienthoai.ForeColor = Color.Red;
            }
            if (kiemtraten.IsMatch(txttenkhachhang.Text) && kiemtrasodienthoai.IsMatch(txtsodienthoai.Text))
            {
                eKhachHang khachhang = new eKhachHang();
                khachhang.MaKhachHang = lblmakhachhang.Text;
                khachhang.TenKhachHang = txttenkhachhang.Text;
                khachhang.Phone = txtsodienthoai.Text;
                if (khachhangbll.ThayDoiThongTinKhachHang(khachhang))
                {
                    dataGridView1.CurrentRow.Cells[2].Value = txtsodienthoai.Text;
                }
            }
            
        }

        private void txttenkhachhang_Click(object sender, EventArgs e)
        {
            if(txttenkhachhang.Text== "Tên khách hàng không hợp lệ")
            {
                txttenkhachhang.Clear();
            }
        }

        private void txtsodienthoai_Click(object sender, EventArgs e)
        {
            if(txtsodienthoai.Text== "Số điện thoại không hợp lệ")
            {
                txtsodienthoai.Clear();
            }
        }

        private void txttenkhachhang_TextChanged(object sender, EventArgs e)
        {
            if (txttenkhachhang.Text == "")
            {
                btnluu.Enabled = false;
            }
            if (txttenkhachhang.Text != "" && txtsodienthoai.Text != "")
            {
                btnluu.Enabled = true;
            }
        }

        private void txtsodienthoai_TextChanged(object sender, EventArgs e)
        {
            if (txtsodienthoai.Text == "")
            {
                btnluu.Enabled = false;
            }
            if (txttenkhachhang.Text != "" && txtsodienthoai.Text != "")
            {
                btnluu.Enabled = true;
            }
        }
    }
}
