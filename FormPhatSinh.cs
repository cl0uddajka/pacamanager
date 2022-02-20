using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
namespace PacaManager
{
    public partial class FormPhatSinh : Form
    {
        Common cm = new Common();
        public int typePS = 0;// 0 phai tra, 1 da thanh toan
        public FormPhatSinh()
        {
            InitializeComponent();
        }

        private void FormPhatSinh_Load(object sender, EventArgs e)
        {
            List<NhanVat> lstNhanVat = Singleton.Instance.db.GetCollection<NhanVat>("NhanVat").AsQueryable().Where(c => c.LinhVuc == 2).ToList();
            cbxTenNguoi.DataSource = lstNhanVat;
            cbxTenNguoi.ValueMember = "MaNV";
            cbxTenNguoi.DisplayMember = "TenNV";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FormXuatNhap ow = (FormXuatNhap)Owner;
            ow.phuPhi = new ThanhToan();
            ow.phuPhi.MaNV = cbxTenNguoi.ValueMember;
            ow.phuPhi.TenNV = cbxTenNguoi.Text;
            
            Int64 soTien = 0;
            if (!String.IsNullOrEmpty(txtPhaiTra.Text))
            {
                soTien = Convert.ToInt64(txtPhaiTra.Text);
            }
            ow.phuPhi.PhaiTra = soTien;

            soTien = 0;
            if (!String.IsNullOrEmpty(txtDaThanhToan.Text))
            {
                soTien = Convert.ToInt64(txtDaThanhToan.Text);
            }
            ow.phuPhi.DaThanhToan = soTien;

            ow.phuPhi.MoTa = rtbMoTa.Text;
            ow.phuPhi.ThoiGian = DateTime.Now.ToString();
            ow.napPhiPhatSinh();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checknumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
