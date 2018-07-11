using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using Bussiness;
using Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class ucHuyCho : UserControl
    {
        List<eTuaDe> danhsachtuade = new List<eTuaDe>();
        TuaDeBll tuadedll = new TuaDeBll();
        KhachHangBLL khachhangbll = new KhachHangBLL();
        HangDoiDLL hangdoidll = new HangDoiDLL();
        HangDoiDLL hangchodll = new HangDoiDLL();

        public ucHuyCho()
        {
            InitializeComponent();
        }

        private void LoadComboBox(List<eTuaDe> DanhSachTuaDe)
        {
            comboBox1.DataSource = DanhSachTuaDe;
            comboBox1.DisplayMember = "NoiDungTuaDe";
            comboBox1.ValueMember = "MaTuaDe";
        }

        private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text != "Không được bỏ trống" && txtmakhachhang.Text != "Không tìm thấy mã khách hàng" && txtmakhachhang.Text != "")
            {
                LoadComboBox(tuadedll.LayDanhSachTuaDeBoiDanhSachMaTuaDe(hangchodll.LayDanhSachMaTuaDe(txtmakhachhang.Text)));
                btnhuycho.Enabled = true;
            }
        }

        private void txtmakhachhang_Click(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text != "Không được bỏ trống" || txtmakhachhang.Text != "Không tìm thấy mã khách hàng")
            {
                txtmakhachhang.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox1.Text = "-Danh sách tựa đĩa mà khách hàng đã đặt chỗ-";
            }
        }

        private void btnhuycho_Click(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text == ""||!khachhangbll.KiemTraTonTaiMaKhachHang(txtmakhachhang.Text))
            {
                txtmakhachhang.Text = "Vui lòng cung cấp mã khách hàng chính xác";
            }
            if (comboBox1.Text=="")
            {
                comboBox1.Text = "Không có tựa đề nào được đặt bởi khách hàng";
            }
            else if(comboBox1.ValueMember!=null)
            {
                hangdoidll.GoHangDoi(txtmakhachhang.Text, comboBox1.SelectedValue.ToString());
                txtmakhachhang.Clear();
            }
        }
    }
}
