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
    public partial class ucChoThueDia : UserControl
    {
        int thanhtoanmuon_button_click_count = 0;
        List<eDia> listdia;
        List<eTuaDe> listtuade;
        TuaDeBll tuadebll = new TuaDeBll();
        DiaBLL diabll = new DiaBLL();
        KhachHangBLL khachhangbll = new KhachHangBLL();
        LoaiDiaDLL loaidiabll = new LoaiDiaDLL();
        NhatKyThueDiaDLL nhatKyThueDiaDLL = new NhatKyThueDiaDLL();
        NhatKyGhinoDLL nhatkyghinodll = new NhatKyGhinoDLL();

        public ucChoThueDia()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lblmadia.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "Available")
                    lblalert.Text = "Có thể thuê";
                else
                    lblalert.Text = "Không thể thuê";
                txttitle.Text = tuadebll.GetTitleByID(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Good")
                    txttinhtrangdia.Text = "Tốt";
                else
                    txttinhtrangdia.Text = "Không tốt";
                txtgia.Text = loaidiabll.LayGia(dataGridView1.CurrentRow.Cells[4].Value.ToString()).ToString();
                txtloaidia.Text = loaidiabll.GetTenLoaiByID(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                txtthoigianthue.Text = "Cho phép thuê "+ loaidiabll.SoNgayChoPhepThue(dataGridView1.CurrentRow.Cells[4].Value.ToString()).ToString()+" ngày";

                pictureBox1.ImageLocation = @"" + tuadebll.GetUrlByID(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private void LoadComboBox()
        {
            listtuade = tuadebll.GetAll().ToList();
            comboBox1.DataSource = listtuade;
            comboBox1.DisplayMember = "NoiDungTuaDe";
            comboBox1.ValueMember = "MaTuaDe";
        }

        private void LoadAllToDataGridView()
        {
            listdia = diabll.GetAll();
            dataGridView1.DataSource = listdia;
            dataGridView1.Columns["ID"].HeaderText = "Mã đĩa";
            dataGridView1.Columns["TinhTrangThue"].HeaderText = "Tình trạng thuê";
            dataGridView1.Columns["TinhTrangDia"].HeaderText = "Tình trạng đĩa";
            dataGridView1.Columns["MaTuaDe"].HeaderText = "Thuộc về mã tựa đề";
            dataGridView1.Columns["MaLoai"].HeaderText = "Thuộc về mã loại";
        }

        private void LoadDataGridView(string matuade)
        {
            listdia = diabll.GetAllByTitleID(matuade);
            dataGridView1.DataSource = listdia;
            dataGridView1.Columns["ID"].HeaderText = "Mã đĩa";
            dataGridView1.Columns["TinhTrangThue"].HeaderText = "Tình trạng thuê";
            dataGridView1.Columns["TinhTrangDia"].HeaderText = "Tình trạng đĩa";
            dataGridView1.Columns["MaTuaDe"].HeaderText = "Thuộc về mã tựa đề";
            dataGridView1.Columns["MaLoai"].HeaderText = "Thuộc về mã loại";
        }

        private void txtmakhachhang_Click(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text == "Nhập mã khách hàng muốn thuê" || txtmakhachhang.Text == "Không được để trống" || txtmakhachhang.Text== "Vui lòng cung cấp mã khách hàng" || txtmakhachhang.Text== "Mã khách hàng không tồn tại")
            {
                txtmakhachhang.Clear();
            }
            else
            {
                btnluudulieu.Enabled = true;
            }
        }

        private void lblalert_TextChanged(object sender, EventArgs e)
        {
            if (lblalert.Text == "Không thể thuê")
            {
                btnluudulieu.Enabled = false;
                lblalert.ForeColor = Color.Red;
            }
            if (lblalert.Text == "Có thể thuê")
            {
                btnluudulieu.Enabled = true;
                lblalert.ForeColor = Color.Green;
            }
        }

        private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text != "Mã khách hàng muốn thuê" && txtmakhachhang.Text != "" && txtmakhachhang.Text != "Không được để trống" || txtmakhachhang.Text != "Mã khách hàng không tồn tại")
            {
                btnluudulieu.Enabled = true;
                decimal tongtien = nhatkyghinodll.LayTongPhiTreCuaKhachHang(txtmakhachhang.Text);
                if(tongtien!=0)
                {
                    lblthongbaophimuon.Visible = true;
                    lblthongbaophimuon.Text = "Khách hàng có mã " + txtmakhachhang.Text + " đang có tổng phí muộn là " + tongtien;
                    btnthanhtoanphimuon.Enabled = true;
                }
                if (tongtien == 0)
                {
                    lblthongbaophimuon.Text = "";
                    btnthanhtoanphimuon.Enabled = false;
                }
            }
        }

        private void btnluudulieu_Click(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text == "")
            {
                txtmakhachhang.Text = "Không được để trống";
            }
            else if (txtmakhachhang.Text == "Mã khách hàng muốn thuê")
            {
                txtmakhachhang.Text = "Vui lòng cung cấp mã khách hàng";
            }
            else
            {
                if (khachhangbll.KiemTraTonTaiMaKhachHang(txtmakhachhang.Text))
                {
                    eNhatKyThueDia newdiary = new eNhatKyThueDia();
                    newdiary.MaDia = Int32.Parse(lblmadia.Text);
                    newdiary.MaKhachHang = txtmakhachhang.Text;
                    newdiary.MaTua = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    newdiary.NgayChoThue = DateTime.Now;
                    newdiary.NgayTraDia = DateTime.Now.AddDays(1);
                    newdiary.PhiTreHen = 0;
                    newdiary.TienDatCoc = stringtodecimal(lbltongtiendatcoc.Text);
                    newdiary.SoLuongThue = 1;
                    if (nhatKyThueDiaDLL.Save_Disc_Hire_Diary(newdiary))
                    {
                        txtmakhachhang.Clear();
                        nhatKyThueDiaDLL.GiamSoLuong(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        lblalert.Text = "Không thể thuê";
                        dataGridView1.CurrentRow.Cells[1].Value = "Not Available";
                    }
                    else
                    {
                        MessageBox.Show("Việc lưu thông tin thất bại,xin kiểm tra lại mã khách hàng hoặc đĩa đã được thuê");
                    }
                }
                else
                {
                    txtmakhachhang.Text = "Mã khách hàng không tồn tại";
                }
            }
        }

        private void ucChoThueDia_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private decimal stringtodecimal(string text)
        {
            decimal value;
            if (Decimal.TryParse(text, out value))
                return value;
            return 0;
        }

        private void txtgia_TextChanged(object sender, EventArgs e)
        {
            lbltongtiendatcoc.Text = (stringtodecimal(txtgia.Text) * 1).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = comboBox1.SelectedValue.ToString();
            LoadDataGridView(id);
        }

        private void btnthanhtoanphimuon_Click(object sender, EventArgs e)
        {
            thanhtoanmuon_button_click_count++;
            //nhấn một lần sẽ chuyển thành nút thanh toán và hiện ra danh sách các khoản phí trễ
            //của khách hàng
            btnthanhtoanphimuon.Text = "Thanh toán";
            groupBox1.Visible = true;
            dataGridView2.DataSource = nhatkyghinodll.GetList(txtmakhachhang.Text);
            if (thanhtoanmuon_button_click_count > 1 )
            {
                //nhấn lần nữa là nhiều hơn một lần => sẽ tiến hành thanh toán các khoản đã chọn
                nhatkyghinodll.ThanhToanMuon(txtmakhachhang.Text);
                dataGridView2.DataSource= nhatkyghinodll.GetList(txtmakhachhang.Text);
            }
            
        }

        private void lblthongbaophimuon_TextChanged(object sender, EventArgs e)
        {
            if (lblthongbaophimuon.Text == "")
            {
                btnthanhtoanphimuon.Enabled = false;
            }   
        }

        private void txtmakhachhang_Leave(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text == "")
            {
                txtmakhachhang.Text = "Nhập mã khách hàng muốn thuê";
            }
        }

        private void txtmakhachhang_MouseLeave(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text == "")
            {
                txtmakhachhang.Text = "Nhập mã khách hàng muốn thuê";
            }
        }
    }
}
