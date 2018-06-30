using System;
using System.Collections.Generic;
using System.ComponentModel;
using Entity;
using Bussiness;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class frmAdmin : Form
    {
        //LoaiDiaDLL loaidiabll = new LoaiDiaDLL();
        //DiaBLL diabll = new DiaBLL();
        //TuaDeBll tuadebll = new TuaDeBll();

        public frmAdmin()
        {
            InitializeComponent(); navigate(new ucmain
            {
                Location = new Point(0, 0)
            });
        }

        private void btnthemkhachang_Click(object sender, EventArgs e)
        {
            navigate(new ucThemKhachHang
            {
                Location = new Point(0, 0)
            });
        }

        private void Disable_Admin_Feature()
        {
            btnxoakhachhang.Enabled = false;
            btnthemtua.Enabled = false;
            btnxoatua.Enabled = false;
            btnthemdia.Enabled = false;
            btnxoadia.Enabled = false;
            btnhuyphitre.Enabled = false;
            btnbaocaodiaquahan.Enabled = false;
            btnbaocaokhoannokhachhang.Enabled = false;
            btnbaocaothongtincoban.Enabled = false;
            btnbaocaotongsodia.Enabled = false;
        }

        private void Enable_Admin_Feature()
        {
            btnxoakhachhang.Enabled = true;
            btnthemtua.Enabled = true;
            btnxoatua.Enabled = true;
            btnthemdia.Enabled = true;
            btnxoadia.Enabled = true;
            btnhuyphitre.Enabled = true;
            btnbaocaodiaquahan.Enabled = true;
            btnbaocaokhoannokhachhang.Enabled = true;
            btnbaocaothongtincoban.Enabled = true;
            btnbaocaotongsodia.Enabled = true;
        }

        private void btnchothuedia_Click(object sender, EventArgs e)
        {
            navigate(new ucChoThueDia
            {
                Location = new Point(0, 0)
            });
        }

        private void btnghinhantradia_Click(object sender, EventArgs e)
        {
            navigate(new ucGhiNhanTraDia
            {
                Location = new Point(0, 0)
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigate(new ucBaoCaoTinhTrangCuaDia /// cái này chưa làm
            {
                Location = new Point(0, 0)
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            navigate(new ucCapNhatThongTinKhachHang
            {
                Location = new Point(0, 0)
            });
        }

        private void btnxoakhachhang_Click(object sender, EventArgs e)
        {

        }

        private void btnthemtua_Click(object sender, EventArgs e)
        {

        }

        private void btnxoatua_Click(object sender, EventArgs e)
        {

        }

        private void btntraloithongtin_Click(object sender, EventArgs e)
        {

        }

        private void btncapnhatphitre_Click(object sender, EventArgs e)
        {
            navigate(new ucCapnhatphitre
            {
                Location = new Point(0, 0)
            });
        }

        private void btnlaythongtinphitre_Click(object sender, EventArgs e)
        {
            navigate(new uclaythongtinphitre
            {
                Location = new Point(0, 0)
            });
        }

        private void btnhuyphitre_Click(object sender, EventArgs e)
        {

        }

        private void btndatcho_Click(object sender, EventArgs e)
        {
            navigate(new ucDatCho
            {
                Location = new Point(0, 0)
            });
        }

        private void btnhuycho_Click(object sender, EventArgs e)
        {
            navigate(new ucHuyCho
            {
                Location = new Point(0, 0)
            });
        }

        private void btnthemdia_Click(object sender, EventArgs e)
        {

        }

        private void btnxoadia_Click(object sender, EventArgs e)
        {

        }

        private void btnbaocaothongtincoban_Click(object sender, EventArgs e)
        {

        }

        private void btnbaocaotongsodia_Click(object sender, EventArgs e)
        {

        }

        private void btnbaocaodiaquahan_Click(object sender, EventArgs e)
        {

        }

        private void btnbaocaokhoannokhachhang_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            lblroll.Text = "Quản lý";
            btndangnhap.Enabled = false;
            btndangxuat.Enabled = true;
            Enable_Admin_Feature();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            lblroll.Text = "Nhân viên";
            btndangnhap.Enabled = true;
            btndangxuat.Enabled = false;
            Disable_Admin_Feature();
        }

        public void navigate(UserControl userControl)
        {
            panel3.Controls.Clear();
            UserControl x = userControl;
            x.Dock = DockStyle.Fill;
            panel3.Controls.Add(x);
        }
    }
}
