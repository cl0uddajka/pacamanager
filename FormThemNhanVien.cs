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
    public partial class FormThemNhanVien : Form
    {
        Common cm = new Common();
        public FormThemNhanVien()
        {
            InitializeComponent();
        }
        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {

            List<NhanVat> lstNhanVat = Singleton.Instance.db.GetCollection<NhanVat>("NhanVat").AsQueryable().ToList();
            cbxTenNguoi.DataSource = lstNhanVat;
            cbxTenNguoi.ValueMember = "MaNV";
            cbxTenNguoi.DisplayMember = "TenNV";

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<NhanVat> lstNhanVat = Singleton.Instance.db.GetCollection<NhanVat>("NhanVat").AsQueryable().ToList();
            var nvTmp = lstNhanVat.AsQueryable().Where(c => c.TenNV == cbxTenNguoi.Text).FirstOrDefault();
            if (nvTmp != null)
            {
                var filter = Builders<NhanVat>.Filter.Eq(s => s.TenNV, nvTmp.TenNV);
                nvTmp.DiaChi = txtDiaChi.Text;
                nvTmp.TenNV = cbxTenNguoi.Text;
                nvTmp.Luong = Convert.ToInt64(txtLuong.Text);
                nvTmp.SoDienThoai = txtSDT.Text;
                nvTmp.NamSinh = txtNamSinh.Text;
                var result = Singleton.Instance.db.GetCollection<NhanVat>("NhanVat").ReplaceOneAsync(filter, nvTmp);
            }
            else
            {

                NhanVat nv = new NhanVat();
                string maNv = cm.checkMaID(lstNhanVat.Count + 1);
                nv.MaNV = maNv;
                nv.DiaChi = txtDiaChi.Text;
                nv.LinhVuc = 2;
                nv.TenNV = cbxTenNguoi.Text;
                nv.Luong = Convert.ToInt64(txtLuong.Text);
                nv.SoDienThoai = txtSDT.Text;
                nv.NamSinh = txtNamSinh.Text;
                Singleton.Instance.db.GetCollection<NhanVat>("NhanVat").InsertOneAsync(nv);
            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxTenNguoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<NhanVat> lstNhanVat = Singleton.Instance.db.GetCollection<NhanVat>("NhanVat").AsQueryable().ToList();
            var nvTmp = lstNhanVat.AsQueryable().Where(c => c.TenNV == cbxTenNguoi.Text).FirstOrDefault();
            if (nvTmp != null)
            {

                txtDiaChi.Text = nvTmp.DiaChi;
                cbxTenNguoi.Text = nvTmp.TenNV;
                txtLuong.Text = nvTmp.Luong.ToString();
                txtSDT.Text = nvTmp.SoDienThoai;
                txtNamSinh.Text = nvTmp.NamSinh;
            }
        }
    }
}
