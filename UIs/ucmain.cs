using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Entity;
using Bussiness;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class ucmain : UserControl
    {
        List<eDia> listdia;
        List<eTuaDe> listtuade;
        LoaiDiaDLL loaidiabll = new LoaiDiaDLL();
        DiaBLL diabll = new DiaBLL();
        TuaDeBll tuadebll = new TuaDeBll();

        public ucmain()
        {
            InitializeComponent();
            LoadComboBox();
            LoadAll();
        }

        private void dgvdia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvdia.SelectedRows.Count > 0)// chắc chắn người dùng ít nhất phải chọn một hàng
            {
                lblmadia.Text = dgvdia.CurrentRow.Cells[0].Value.ToString();
                if (dgvdia.CurrentRow.Cells[1].Value.ToString() == "Available")
                    label4.Text = "Có thể thuê";
                else
                    label4.Text = "Không thể thuê";
                txttitle.Text = tuadebll.GetTitleByID(dgvdia.CurrentRow.Cells[3].Value.ToString());
                if (dgvdia.CurrentRow.Cells[2].Value.ToString() == "Good")
                    txttinhtrangdia.Text = "Tốt";
                else
                    txttinhtrangdia.Text = "Không tốt";
                txtgia.Text = loaidiabll.LayGia(dgvdia.CurrentRow.Cells[4].Value.ToString()).ToString();
                txtloaidia.Text = loaidiabll.GetTenLoaiByID(dgvdia.CurrentRow.Cells[4].Value.ToString());
                txtthoigianthue.Text = "Cho thuê "+loaidiabll.SoNgayChoPhepThue(dgvdia.CurrentRow.Cells[4].Value.ToString()).ToString() + " ngày";

                pictureBox1.ImageLocation = @"" + tuadebll.GetUrlByID(dgvdia.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private void cbtuade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string id = cbtuade.SelectedValue.ToString();
            Load_disc_to_table(id);
        }

        private void cbtuade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbtuade.SelectedValue.ToString();
            Load_disc_to_table(id);
        }

        private void LoadComboBox()
        {
            listtuade = tuadebll.GetAll().ToList();
            cbtuade.DataSource = listtuade;
            cbtuade.DisplayMember = "NoiDungTuaDe";
            cbtuade.ValueMember = "MaTuaDe";
        }

        private void Load_disc_to_table(string matuade)
        {
            listdia = diabll.GetAllByTitleID(matuade);
            dgvdia.DataSource = listdia;
            dgvdia.Columns["ID"].HeaderText = "Mã đĩa";
            dgvdia.Columns["TinhTrangThue"].HeaderText = "Tình trạng thuê";
            dgvdia.Columns["TinhTrangDia"].HeaderText = "Tình trạng đĩa";
            dgvdia.Columns["MaTuaDe"].HeaderText = "Thuộc về mã tựa đề";
            dgvdia.Columns["MaLoai"].HeaderText = "Thuộc về mã loại";
        }

        private void LoadAll()
        {
            listdia = diabll.GetAll();
            dgvdia.DataSource = listdia;
            dgvdia.Columns["ID"].HeaderText = "Mã đĩa";
            dgvdia.Columns["TinhTrangThue"].HeaderText = "Tình trạng thuê";
            dgvdia.Columns["TinhTrangDia"].HeaderText = "Tình trạng đĩa";
            dgvdia.Columns["MaTuaDe"].HeaderText = "Thuộc về mã tựa đề";
            dgvdia.Columns["MaLoai"].HeaderText = "Thuộc về mã loại";
        }
    }
}
