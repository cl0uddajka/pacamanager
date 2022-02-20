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
    public sealed class Singleton
    {
        private Singleton() { }

        static readonly Singleton _instance = new Singleton();

        public static Singleton Instance => _instance;

        public MongoClient client;

        public string PACAConnectionString = "mongodb+srv://cl0uddajka:1596842424z@cluster0.yjlz2.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";

        public IMongoDatabase db;


        private int _count = 0;

        public void Increase() => _count++;

        public int Count => _count;
    }
    public partial class FormMain : Form
    {

        //MongoClient client;

        //public string PACAConnectionString = "mongodb+srv://cl0uddajka:1596842424z@cluster0.yjlz2.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Singleton.Instance.client = new MongoClient(Singleton.Instance.PACAConnectionString);
            Singleton.Instance.db = Singleton.Instance.client.GetDatabase("db");
            List<HangHoaGD> lstXuatNhapHang = Singleton.Instance.db.GetCollection<HangHoaGD>("HangHoaGD").AsQueryable().ToList();
            List<VatTuGD> lstXuatNhapVT = Singleton.Instance.db.GetCollection<VatTuGD>("VatTuGD").AsQueryable().ToList();
            List<KhoVatTu> lstKhoVT = Singleton.Instance.db.GetCollection<KhoVatTu>("KhoVatTu").AsQueryable().ToList();
            List<ThanhToan> lstThanhToan = Singleton.Instance.db.GetCollection<ThanhToan>("ThanhToan").AsQueryable().ToList();
            List<BangCong> lstBangCong = Singleton.Instance.db.GetCollection<BangCong>("BangCong").AsQueryable().ToList();
            
        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            FormXuatNhap frm = new FormXuatNhap();

            switch (button.Name)
            {
                case "btnNhapHang":
                    frm.typeXN = 0;
                    break;
                case "btnXuatHang":
                    frm.typeXN = 1;
                    break;
                case "btnNhapVT":
                    frm.typeXN = 2;
                    break;
                case "btnXuatVT":
                    frm.typeXN = 3;
                    break;
                default:
                    break;
            }
            frm.ShowDialog();
        }

        private void MainMenuItem_Click(object sender, EventArgs e)
        {
            FormThemNhanVien frm = new FormThemNhanVien();
            frm.ShowDialog(this);
        }
    }
}

