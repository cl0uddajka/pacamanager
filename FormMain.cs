using MongoDB.Driver;
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
    public partial class FormMain : Form
    {
        MongoClient client;
       
        public string PACAConnectionString = "mongodb+srv://cl0uddajka:1596842424z@cluster0.yjlz2.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            client = new MongoClient(PACAConnectionString);
            var db = client.GetDatabase("db");
            List<HangHoaGD> lstXuatNhapHang = db.GetCollection<HangHoaGD>("HangHoaGD").AsQueryable().ToList();
            List<VatTuGD> lstXuatNhapVT = db.GetCollection<VatTuGD>("VatTuGD").AsQueryable().ToList();
            List<KhoVatTu> lstKhoVT = db.GetCollection<KhoVatTu>("KhoVatTu").AsQueryable().ToList();
            List<ThanhToan> lstThanhToan = db.GetCollection<ThanhToan>("ThanhToan").AsQueryable().ToList();
            List<BangCong> lstBangCong = db.GetCollection<BangCong>("BangCong").AsQueryable().ToList();

        }
    }
}
