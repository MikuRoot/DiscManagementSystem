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
    public partial class ucGhiNhanTraDia : UserControl
    {
        int nextbutton_click_count = 0;
        NhatKyThueDiaDLL nhatkythuediadll = new NhatKyThueDiaDLL();
        DiaBLL diadll = new DiaBLL();
        NhatKyGhinoDLL nhatkyghinodll = new NhatKyGhinoDLL();
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        HangDoiDLL hangdoidll = new HangDoiDLL();
        TuaDeBll tuadedll = new TuaDeBll();

        public ucGhiNhanTraDia()
        {
            InitializeComponent();
            Load();
        }

        private void ucGhiNhanTraDia_Load(object sender, EventArgs e)
        {
            Load();
        }

        void Load()
        {
            dataGridView1.DataSource = nhatkythuediadll.GetList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Mã khách hàng" || textBox1.Text == "Không có mã khách hàng")
            {
                textBox1.Clear();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lbltiendatcoc.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                if (DateTime.Now > (DateTime)dataGridView1.CurrentRow.Cells[8].Value)
                {
                    //10% tien dat coc + tien thue = tien phai tra bao gom phi tre :))
                    //phi tre = 10% tien dat coc
                    lbltongtienquykhachphaitra.Text = ((((decimal)0.1 * (decimal)dataGridView1.CurrentRow.Cells[6].Value) + ((decimal)0.2 * ConvertStringToDecimal(lbltiendatcoc.Text)))).ToString();
                    btnkhongthanhtoanphitre.Enabled = true;
                }
                else
                {
                    //Khach hang phai tra tien thue = 20% tien dat coc
                    lbltongtienquykhachphaitra.Text = (((decimal)0.2 * ConvertStringToDecimal(lbltiendatcoc.Text))).ToString();
                }
                textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                lbltua.Text = tuadedll.GetTitleByID(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            }
        }

        private void lbltongtienquykhachphaitra_TextChanged(object sender, EventArgs e)
        {
            decimal tiencoc = ConvertStringToDecimal(lbltiendatcoc.Text);
            decimal tienkhachtra = ConvertStringToDecimal(lbltongtienquykhachphaitra.Text);
            lbltientralaichokhach.Text = ((tiencoc - tienkhachtra) * 1000).ToString() + " đồng";
        }

        private void btnkhongthanhtoanphitre_Click(object sender, EventArgs e)
        {
            lbltongtienquykhachphaitra.Text = ((ConvertStringToDecimal(lbltongtienquykhachphaitra.Text) - (decimal)0.1* ConvertStringToDecimal(lbltiendatcoc.Text))).ToString();
            btnkhongthanhtoanphitre.Enabled = false;
        }

        private void btnluudulieu_Click(object sender, EventArgs e)
        {
            if (rdgood.Checked == true)
            {
                diadll.CapNhatTinhTrangDia((int)dataGridView1.CurrentRow.Cells[1].Value, "Good");
            }
            if (rdnotgood.Checked == true)
            {
                diadll.CapNhatTinhTrangDia((int)dataGridView1.CurrentRow.Cells[1].Value, "Not good");
            }

            nhatkythuediadll.ChinhTrangThaiThueDia((int)dataGridView1.CurrentRow.Cells[1].Value, "Available");
            nhatkythuediadll.TangSoLuong(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            nhatkythuediadll.ChinhSuaTinhTrangTraDia((int)dataGridView1.CurrentRow.Cells[0].Value, "Da tra");

            decimal sotienkhongcophitre = ConvertStringToDecimal(lbltongtienquykhachphaitra.Text);
            decimal sotiencophitre = (((decimal)0.1 * (decimal)dataGridView1.CurrentRow.Cells[6].Value) + ((decimal)0.2 * ConvertStringToDecimal(lbltiendatcoc.Text)));

            if (DateTime.Now > (DateTime)dataGridView1.CurrentRow.Cells[8].Value && sotiencophitre > sotienkhongcophitre)
            {
                nhatkythuediadll.ThemPhiNoTre(dataGridView1.CurrentRow.Cells[2].Value.ToString(), (decimal)0.1 * (decimal)dataGridView1.CurrentRow.Cells[6].Value);
                eNhatKyGhiNo no = new eNhatKyGhiNo();
                no.IDDia = (int)dataGridView1.CurrentRow.Cells[1].Value;
                no.IDKhachHang = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                no.SoTienNo = (decimal)0.1 * (decimal)dataGridView1.CurrentRow.Cells[6].Value;
                nhatkyghinodll.ThemThongTinNo(no);
            }
            if (tuadedll.SoLuongDiaCuaTuaDe(dataGridView1.CurrentRow.Cells[4].Value.ToString()) > 0)
            {
                grbgiucho.Visible = true;
                Load_Basic_Customer_Inf();
            }
            dataGridView1.DataSource = nhatkythuediadll.GetList();
        }
        
        private void Load_Basic_Customer_Inf()
        {
            string matua = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            List<eKhachHang> list = khachHangBLL.LayDSKhachHang(hangdoidll.GetIDCustomerList(matua));
            eKhachHang kh = list.FirstOrDefault();
            if (kh == null)
            {
                lblname.Text = "";
                lblsodienthoai.Text = "";
                lblnext.Text = "";
                label1.Text = "Không có hàng chờ cho tựa đề này";
                label1.Visible = true;
                grbgiucho.Visible = false;
            }
            else
            {
                lblname.Text = kh.TenKhachHang;
                lblsodienthoai.Text = kh.Phone;
                lblsoluongdat.Text = "Đặt "+hangdoidll.LaySoLuongDat(dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString()).ToString()+ " đĩa";
            }
        }

        private void lblnext_Click(object sender, EventArgs e)
        {
            nextbutton_click_count++;
            List<eKhachHang> list = khachHangBLL.LayDSKhachHang(hangdoidll.GetIDCustomerList(dataGridView1.CurrentRow.Cells[4].Value.ToString()));
            eKhachHang kh = list.Skip(1).Take(1).First();
            if (kh == null)
            {
                Load_Basic_Customer_Inf();
                label1.Text = "Chỉ có một khách hàng trong hàng đợi";
                label1.Visible = true;
            }
            else if(kh!=null)
            {
                lblname.Text = kh.TenKhachHang;
                lblsodienthoai.Text = kh.Phone;
            }
            else if (nextbutton_click_count == list.Count - 1)
            {
                Load_Basic_Customer_Inf();
                nextbutton_click_count = 0;
            }
        }

        private void lblprevious_Click(object sender, EventArgs e)
        {
            
        }

        private void btngetlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhatkythuediadll.GetListByID(textBox1.Text);
        }

        private decimal ConvertStringToDecimal(string text)
        {
            decimal value;
            if(Decimal.TryParse(text,out value))
            {
                return value;
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)//quên đặt tên ... đây là nút giữ chỗ cho khách hàng
        {
            string makhachhang = khachHangBLL.LayMakh(lblname.Text, lblsodienthoai.Text);
            string matua = tuadedll.LayMaTua(lbltua.Text);
            hangdoidll.GiamSoLuongDat(makhachhang, matua);
            if (hangdoidll.LaySoLuongDat(makhachhang, matua) == 0)
            {
                hangdoidll.GoHangDoi(khachHangBLL.LayMakh(lblname.Text, lblsodienthoai.Text), matua);
            }
            //task thue dia o day
            eNhatKyThueDia newdiary = new eNhatKyThueDia();
            newdiary.MaDia = (int)dataGridView1.CurrentRow.Cells[1].Value;//sửa lại,thêm vào form label để chứa tạm cái id đĩa và gán label đó vào đây
            newdiary.MaKhachHang = makhachhang;
            newdiary.MaTua = matua;
            newdiary.NgayChoThue = DateTime.Now;
            newdiary.NgayTraDia = DateTime.Now.AddDays(2);
            newdiary.PhiTreHen = 0;
            newdiary.TienDatCoc = (decimal)dataGridView1.CurrentRow.Cells[6].Value;//như trên
            newdiary.SoLuongThue = 1;
            if (nhatkythuediadll.Save_Disc_Hire_Diary(newdiary))
            {
                button1.Enabled = false;
                List<eKhachHang> list = khachHangBLL.LayDSKhachHang(hangdoidll.GetIDCustomerList(dataGridView1.CurrentRow.Cells[4].Value.ToString()));
                eKhachHang kh = list.Skip(1).Take(1).First();
                if (kh == null)
                {
                    Load_Basic_Customer_Inf();
                    label1.Text = "Chỉ có một khách hàng trong hàng đợi";
                    label1.Visible = true;
                }
                else
                {
                    lblname.Text = kh.TenKhachHang;
                    lblsodienthoai.Text = kh.Phone;
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)//hủy đặt chỗ khách hàng
        {
            string matua = tuadedll.LayMaTua(lbltua.Text);
            hangdoidll.GoHangDoi(khachHangBLL.LayMakh(lblname.Text, lblsodienthoai.Text), matua);
            List<eKhachHang> list = khachHangBLL.LayDSKhachHang(hangdoidll.GetIDCustomerList(matua));
            eKhachHang kh = list.Skip(1).Take(1).First();
            if (kh == null)
            {
                Load_Basic_Customer_Inf();
                label1.Text = "Chỉ có một khách hàng trong hàng đợi";
                label1.Visible = true;
            }
            else
            {
                lblname.Text = kh.TenKhachHang;
                lblsodienthoai.Text = kh.Phone;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if(label1.Text == "Chỉ có một khách hàng trong hàng đợi")
            {
                btncancel.Enabled = false;
                button1.Enabled = false;
            }
        }
    }
}
