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
    public partial class uclaythongtinphitre : UserControl
    {
        NhatKyGhinoDLL nhatkyghinodll = new NhatKyGhinoDLL();
        KhachHangBLL khachhangbll = new KhachHangBLL();
        TuaDeBll tuadebll = new TuaDeBll();
        LoaiDiaDLL loaidiabll = new LoaiDiaDLL();
        DiaBLL diabll = new DiaBLL();

        public uclaythongtinphitre()
        {
            InitializeComponent();
        }

        private void btnlaydsphitre_Click(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text == "" || txtmakhachhang.Text == "Mã khách hàng" || txtmakhachhang.Text == "Vui lòng cung cấp mã khách hàng")
            {
                txtmakhachhang.Text = "Vui lòng cung cấp mã khách hàng";
            }
            else
            {
                dataGridView1.DataSource = nhatkyghinodll.GetList(txtmakhachhang.Text);
            }
        }

        private void txtmakhachhang_Click(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text == "Mã khách hàng" || txtmakhachhang.Text == "Vui lòng cung cấp mã khách hàng")
            {
                txtmakhachhang.Clear();
            }
        }

        private void txtmakhachhang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtmakhachhang.Text == "" || txtmakhachhang.Text == "Mã khách hàng" || txtmakhachhang.Text == "Vui lòng cung cấp mã khách hàng")
                {
                    txtmakhachhang.Text = "Vui lòng cung cấp mã khách hàng";
                }
                else
                {
                    dataGridView1.DataSource = nhatkyghinodll.GetList(txtmakhachhang.Text);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lbltenkhachhang.Text = khachhangbll.LayTenKhachHang(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                lblsodienthoaikhachhang.Text = khachhangbll.LaySoDienThoaiKhachHang(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                lblmadia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                lbltuade.Text = tuadebll.GetTitleByID(diabll.GetIDTitle((int)dataGridView1.CurrentRow.Cells[2].Value));
                lblloaidia.Text = loaidiabll.GetTenLoaiByID(diabll.GetIDDiscType((int)dataGridView1.CurrentRow.Cells[2].Value));
                lbltongsotienno.Text = nhatkyghinodll.LayTongPhiTre((int)dataGridView1.CurrentRow.Cells[0].Value).ToString();

                pictureBox1.ImageLocation = @"" + tuadebll.GetUrlByID(diabll.GetIDTitle((int)dataGridView1.CurrentRow.Cells[2].Value));
            }
        }
    }
}
