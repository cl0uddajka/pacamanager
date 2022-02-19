using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
