using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Bussiness;
using Entity;
using System.Data;
using System.Linq;
using System.Text;
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
}
