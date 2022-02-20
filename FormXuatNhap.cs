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
    public partial class FormXuatNhap : Form
    {
        /// <summary>
        /// 0 = nhập hàng
        /// 1 = xuất hàng
        /// 2 = nhập vật tư
        /// 3 = xuất vật tư
        /// </summary>
        public int typeXN = 0;
        Common cm = new Common();
        public ThanhToan phuPhi;
        public FormXuatNhap()
        {
            InitializeComponent();
        }

        private void FormXuatNhap_Load(object sender, EventArgs e)
        {
            switch (typeXN)
            {
                case 0:
                    lblTieuDe.Text = "Nhập Hàng";
                    this.Text = lblTieuDe.Text;
                    List<NhanVat> lstNhanVat = Singleton.Instance.db.GetCollection<NhanVat>("NhanVat").AsQueryable().Where(c => c.LinhVuc == 1).ToList();
                    cbxNguoiXN.DataSource = lstNhanVat;
                    cbxNguoiXN.ValueMember = "MaNV";
                    cbxNguoiXN.DisplayMember = "TenNV";

                    List<KhoVatTu> lstKho = Singleton.Instance.db.GetCollection<KhoVatTu>("KhoVatTu").AsQueryable().Where(c => c.Loai == 1).ToList();
                    cbxHangHoa.DataSource = lstKho;
                    cbxHangHoa.ValueMember = "MaVT";
                    cbxHangHoa.DisplayMember = "TenVT";
                    break;
                case 1:
                    lblTieuDe.Text = "Xuất Hàng";
                    this.Text = lblTieuDe.Text;
                    break;
                case 2:
                    lblTieuDe.Text = "Nhập Vật Tư";
                    this.Text = lblTieuDe.Text;
                    lblNguoiXN.Text = "Tên người bán:";
                    break;
                case 3:
                    lblTieuDe.Text = "Xuất Vật Tư";
                    this.Text = lblTieuDe.Text;
                    lblNguoiXN.Text = "Tên người nhận:";

                    break;
                default:
                    break;
            }
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

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            int phatSinh = 0;
            if (!String.IsNullOrEmpty(txtPhatSinh.Text))
            {
                phatSinh = Convert.ToInt32(txtPhatSinh.Text);
            }
            if (!String.IsNullOrEmpty(txtThanhTien.Text))
            {
                txtTongTien.Text = (Convert.ToInt64(txtThanhTien.Text) + phatSinh).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPhatSinh ps = new FormPhatSinh();
            ps.ShowDialog(this);
        }
        public void napPhiPhatSinh()
        {
            txtPhatSinh.Text = phuPhi.PhaiTra.ToString();
            Int64 thanhTien = 0;
            if (!String.IsNullOrEmpty(txtThanhTien.Text))
            {
                thanhTien = Convert.ToInt64(txtThanhTien.Text);
            }
            txtTongTien.Text = (thanhTien + phuPhi.PhaiTra).ToString();
        }
    }
}
