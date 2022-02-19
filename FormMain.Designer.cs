
namespace PacaManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbHangHoa = new System.Windows.Forms.GroupBox();
            this.grvHangHoa = new System.Windows.Forms.DataGridView();
            this.NgayThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatHang = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.grbQuyTaiChinh = new System.Windows.Forms.GroupBox();
            this.txtQuy = new System.Windows.Forms.TextBox();
            this.txtCo = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTenNguoi = new System.Windows.Forms.ComboBox();
            this.grvQuyTaiChinh = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBangCong = new System.Windows.Forms.GroupBox();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbVatTu = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatVT = new System.Windows.Forms.Button();
            this.btnNhapVT = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvHangHoa)).BeginInit();
            this.grbQuyTaiChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuyTaiChinh)).BeginInit();
            this.grbBangCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grbVatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHangHoa
            // 
            this.grbHangHoa.Controls.Add(this.grvHangHoa);
            this.grbHangHoa.Controls.Add(this.btnXuatHang);
            this.grbHangHoa.Controls.Add(this.btnNhapHang);
            this.grbHangHoa.Location = new System.Drawing.Point(12, 88);
            this.grbHangHoa.Name = "grbHangHoa";
            this.grbHangHoa.Size = new System.Drawing.Size(660, 344);
            this.grbHangHoa.TabIndex = 1;
            this.grbHangHoa.TabStop = false;
            this.grbHangHoa.Text = "Hàng hóa";
            // 
            // grvHangHoa
            // 
            this.grvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayThang,
            this.XuatNhap,
            this.TenNguoi,
            this.TenHangHoa,
            this.SoLuong,
            this.TongTien});
            this.grvHangHoa.Location = new System.Drawing.Point(6, 69);
            this.grvHangHoa.Name = "grvHangHoa";
            this.grvHangHoa.Size = new System.Drawing.Size(648, 269);
            this.grvHangHoa.TabIndex = 2;
            // 
            // NgayThang
            // 
            this.NgayThang.HeaderText = "Ngày";
            this.NgayThang.Name = "NgayThang";
            this.NgayThang.Width = 70;
            // 
            // XuatNhap
            // 
            this.XuatNhap.HeaderText = "Xuất/Nhập";
            this.XuatNhap.Name = "XuatNhap";
            this.XuatNhap.Width = 70;
            // 
            // TenNguoi
            // 
            this.TenNguoi.HeaderText = "Tên khách hàng";
            this.TenNguoi.Name = "TenNguoi";
            this.TenNguoi.Width = 120;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.HeaderText = "Hàng hóa";
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 75;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 120;
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.Location = new System.Drawing.Point(578, 19);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(75, 44);
            this.btnXuatHang.TabIndex = 1;
            this.btnXuatHang.Text = "Xuất hàng";
            this.btnXuatHang.UseVisualStyleBackColor = true;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(497, 19);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(75, 44);
            this.btnNhapHang.TabIndex = 0;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            // 
            // grbQuyTaiChinh
            // 
            this.grbQuyTaiChinh.Controls.Add(this.txtQuy);
            this.grbQuyTaiChinh.Controls.Add(this.txtCo);
            this.grbQuyTaiChinh.Controls.Add(this.txtNo);
            this.grbQuyTaiChinh.Controls.Add(this.label4);
            this.grbQuyTaiChinh.Controls.Add(this.label3);
            this.grbQuyTaiChinh.Controls.Add(this.label2);
            this.grbQuyTaiChinh.Controls.Add(this.label1);
            this.grbQuyTaiChinh.Controls.Add(this.cbxTenNguoi);
            this.grbQuyTaiChinh.Controls.Add(this.grvQuyTaiChinh);
            this.grbQuyTaiChinh.Location = new System.Drawing.Point(863, 88);
            this.grbQuyTaiChinh.Name = "grbQuyTaiChinh";
            this.grbQuyTaiChinh.Size = new System.Drawing.Size(475, 344);
            this.grbQuyTaiChinh.TabIndex = 2;
            this.grbQuyTaiChinh.TabStop = false;
            this.grbQuyTaiChinh.Text = "Thanh toán";
            // 
            // txtQuy
            // 
            this.txtQuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtQuy.Location = new System.Drawing.Point(380, 43);
            this.txtQuy.Name = "txtQuy";
            this.txtQuy.ReadOnly = true;
            this.txtQuy.Size = new System.Drawing.Size(72, 20);
            this.txtQuy.TabIndex = 12;
            // 
            // txtCo
            // 
            this.txtCo.Location = new System.Drawing.Point(299, 43);
            this.txtCo.Name = "txtCo";
            this.txtCo.ReadOnly = true;
            this.txtCo.Size = new System.Drawing.Size(70, 20);
            this.txtCo.TabIndex = 11;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(217, 43);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(70, 20);
            this.txtNo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(398, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "QUỸ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CÓ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NỢ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn người cần tìm:";
            // 
            // cbxTenNguoi
            // 
            this.cbxTenNguoi.FormattingEnabled = true;
            this.cbxTenNguoi.Location = new System.Drawing.Point(46, 41);
            this.cbxTenNguoi.Name = "cbxTenNguoi";
            this.cbxTenNguoi.Size = new System.Drawing.Size(121, 21);
            this.cbxTenNguoi.TabIndex = 4;
            // 
            // grvQuyTaiChinh
            // 
            this.grvQuyTaiChinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvQuyTaiChinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.Column2});
            this.grvQuyTaiChinh.Location = new System.Drawing.Point(6, 69);
            this.grvQuyTaiChinh.Name = "grvQuyTaiChinh";
            this.grvQuyTaiChinh.Size = new System.Drawing.Size(457, 269);
            this.grvQuyTaiChinh.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên người";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Phải trả";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Đã thanh toán";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mô tả";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // grbBangCong
            // 
            this.grbBangCong.Controls.Add(this.btnChamCong);
            this.grbBangCong.Controls.Add(this.dataGridView2);
            this.grbBangCong.Location = new System.Drawing.Point(1030, 457);
            this.grbBangCong.Name = "grbBangCong";
            this.grbBangCong.Size = new System.Drawing.Size(308, 279);
            this.grbBangCong.TabIndex = 4;
            this.grbBangCong.TabStop = false;
            this.grbBangCong.Text = "Bảng công";
            // 
            // btnChamCong
            // 
            this.btnChamCong.Location = new System.Drawing.Point(154, 19);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(75, 23);
            this.btnChamCong.TabIndex = 5;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView2.Location = new System.Drawing.Point(6, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(296, 225);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 50;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Tên nhân viên";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Giờ vào";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 50;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Giờ ra";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 50;
            // 
            // grbVatTu
            // 
            this.grbVatTu.Controls.Add(this.dataGridView1);
            this.grbVatTu.Controls.Add(this.btnXuatVT);
            this.grbVatTu.Controls.Add(this.btnNhapVT);
            this.grbVatTu.Location = new System.Drawing.Point(18, 457);
            this.grbVatTu.Name = "grbVatTu";
            this.grbVatTu.Size = new System.Drawing.Size(654, 279);
            this.grbVatTu.TabIndex = 3;
            this.grbVatTu.TabStop = false;
            this.grbVatTu.Text = "Vật Tư";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 204);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Xuất/Nhập";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Hàng hóa";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Tổng Tiền";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 90;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mô tả";
            this.Column1.Name = "Column1";
            this.Column1.Width = 95;
            // 
            // btnXuatVT
            // 
            this.btnXuatVT.Location = new System.Drawing.Point(576, 19);
            this.btnXuatVT.Name = "btnXuatVT";
            this.btnXuatVT.Size = new System.Drawing.Size(75, 44);
            this.btnXuatVT.TabIndex = 3;
            this.btnXuatVT.Text = "Xuất vật tư";
            this.btnXuatVT.UseVisualStyleBackColor = true;
            // 
            // btnNhapVT
            // 
            this.btnNhapVT.Location = new System.Drawing.Point(495, 19);
            this.btnNhapVT.Name = "btnNhapVT";
            this.btnNhapVT.Size = new System.Drawing.Size(75, 44);
            this.btnNhapVT.TabIndex = 2;
            this.btnNhapVT.Text = "Nhập vật tư";
            this.btnNhapVT.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(1263, 12);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 44);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Location = new System.Drawing.Point(678, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 279);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kho vật tư";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn19});
            this.dataGridView3.Location = new System.Drawing.Point(6, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(334, 254);
            this.dataGridView3.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Tên vật tư";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 120;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Số lượng còn";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 80;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Mô tả";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 90;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView4);
            this.groupBox2.Location = new System.Drawing.Point(678, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 344);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kho hàng hóa";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn18});
            this.dataGridView4.Location = new System.Drawing.Point(6, 69);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(173, 269);
            this.dataGridView4.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên vật tư";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Số lượng còn";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 80;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.grbBangCong);
            this.Controls.Add(this.grbVatTu);
            this.Controls.Add(this.grbQuyTaiChinh);
            this.Controls.Add(this.grbHangHoa);
            this.Name = "FormMain";
            this.Text = "Màn hình chính";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grbHangHoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvHangHoa)).EndInit();
            this.grbQuyTaiChinh.ResumeLayout(false);
            this.grbQuyTaiChinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuyTaiChinh)).EndInit();
            this.grbBangCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grbVatTu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHangHoa;
        private System.Windows.Forms.GroupBox grbQuyTaiChinh;
        private System.Windows.Forms.GroupBox grbBangCong;
        private System.Windows.Forms.GroupBox grbVatTu;
        private System.Windows.Forms.Button btnXuatHang;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.DataGridView grvHangHoa;
        private System.Windows.Forms.DataGridView grvQuyTaiChinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTenNguoi;
        private System.Windows.Forms.TextBox txtQuy;
        private System.Windows.Forms.TextBox txtCo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXuatVT;
        private System.Windows.Forms.Button btnNhapVT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}

