using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using Entity;
using Bussiness;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class ucDatCho : UserControl
    {
        TuaDeBll tuadedll = new TuaDeBll();
        HangDoiDLL hangdoidll = new HangDoiDLL();
        LoaiDiaDLL loaidiadll = new LoaiDiaDLL();
        NhatKyThueDiaDLL nhatkithuediadll = new NhatKyThueDiaDLL();

        public ucDatCho()
        {
            InitializeComponent();
            Load();
        }
        
        private void Load()
        {
            dgvtuade.DataSource = tuadedll.GetBasicInf();
        }

        private void dgvtuade_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvtuade.SelectedRows.Count > 0)
            {
                pictureBox1.ImageLocation = @"" + tuadedll.GetUrlByID(dgvtuade.CurrentRow.Cells[0].Value.ToString());
                lblnoidungtuade.Text = dgvtuade.CurrentRow.Cells[2].Value.ToString();
                lblsoluongdiaconlai.Text = dgvtuade.CurrentRow.Cells[1].Value.ToString();
                lblloaidia.Text = loaidiadll.GetTenLoaiByID(tuadedll.LayMaLoaiDia(dgvtuade.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void dgvtuade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvtuade.SelectedRows.Count > 0)
            {
                pictureBox1.ImageLocation = @"" + tuadedll.GetUrlByID(dgvtuade.CurrentRow.Cells[0].Value.ToString());
                lblnoidungtuade.Text = dgvtuade.CurrentRow.Cells[1].Value.ToString();
                lblsoluongdiaconlai.Text = dgvtuade.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void lblsoluongdiaconlai_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(lblsoluongdiaconlai.Text) > 0)
            {
                lbltrangthai.Text = "Đĩa vẫn còn,không cần phải đặt chỗ. Bạn có thể thuê đĩa ";
                btndatcho.Enabled = false;
                txtmakhachhang.Visible = false;
            }
            else
            {
                lbltrangthai.Text = "Đã hết đĩa,vui lòng đặt chỗ";
                btndatcho.Enabled = true;
                txtmakhachhang.Visible = true;
            }
        }

        private void btnthuedia_Click(object sender, EventArgs e)
        {
            
        }

        private void btndatcho_Click(object sender, EventArgs e)
        {
            if(txtmakhachhang.Text== "Nhập mã khách hàng" || txtmakhachhang.Text == "Không được để trống")
            {
                txtmakhachhang.Text = "Không được để trống";
            }
            else
            {
                if (nhatkithuediadll.KiemTraMaKhachHangCoThueDiaNayChua(txtmakhachhang.Text, dgvtuade.CurrentRow.Cells[0].Value.ToString()))
                {
                    lbltrangthai.Text = "Khách hàng có mã này đã thuê đĩa thuộc tựa đề này,vẫn muốn đặt tiếp chỗ";
                    btntieptucdatcho.Visible = true;
                    btntieptucdatcho.Enabled = true;
                    label4.Visible = true;
                    numericUpDown1.Visible = true;
                    btndatcho.Enabled = false;
                }
                else
                {
                    eHangDoi hangDoi = new eHangDoi();
                    hangDoi.MaKhachHang = txtmakhachhang.Text;
                    hangDoi.MaTuaDe = dgvtuade.CurrentRow.Cells[0].Value.ToString();
                    hangDoi.ThuTu = hangdoidll.GetLastOrder() + 1;
                    hangDoi.SoLuongDat = (int)numericUpDown1.Value;
                    if (hangdoidll.ThemHangDoi(hangDoi))
                    {
                        txtmakhachhang.Clear();
                        numericUpDown1.Value = 0;
                    }
                }
            }
        }

        private void txtmakhachhang_Click(object sender, EventArgs e)
        {
            if(txtmakhachhang.Text== "Nhập mã khách hàng" || txtmakhachhang.Text=="Mã khách hàng không được để trống")
            {
                txtmakhachhang.Clear();
            }
        }

        private void txtmakhachhang_Leave(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text == "")
            {
                txtmakhachhang.Text = "Nhập mã khách hàng";
            }
        }

        private void txtmakhachhang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtmakhachhang.Text == "Nhập mã khách hàng" || txtmakhachhang.Text == "Mã khách hàng không được để trống" || txtmakhachhang.Text == "")
                {
                    txtmakhachhang.Text = "Mã khách hàng không được để trống";
                }
                else
                {
                    eHangDoi hangDoi = new eHangDoi();
                    hangDoi.MaKhachHang = txtmakhachhang.Text;
                    hangDoi.MaTuaDe = dgvtuade.CurrentRow.Cells[0].Value.ToString();
                    hangDoi.ThuTu = hangdoidll.GetLastOrder() + 1;
                    if (hangdoidll.ThemHangDoi(hangDoi))
                    {
                        txtmakhachhang.Clear();
                    }
                }
            }
        }

        private void txtmakhachhang_MouseLeave(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text == "")
            {
                txtmakhachhang.Text = "Nhập mã khách hàng";
            }
        }

        private void btntieptucdatcho_Click(object sender, EventArgs e)
        {
            eHangDoi hangDoi = new eHangDoi();
            hangDoi.MaKhachHang = txtmakhachhang.Text;
            hangDoi.MaTuaDe = dgvtuade.CurrentRow.Cells[0].Value.ToString();
            hangDoi.ThuTu = hangdoidll.GetLastOrder() + 1;
            hangDoi.SoLuongDat = (int)numericUpDown1.Value;
            if (hangdoidll.ThemHangDoi(hangDoi))
            {
                txtmakhachhang.Clear();
                numericUpDown1.Value = 0;
            }
        }
    }
}
