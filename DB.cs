using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacaManager
{
    class DB
    {
    }
    public class NhanVat
    {
        public ObjectId id { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public Int64 LinhVuc { get; set; }
        public string NganHang { get; set; }
        public string SoTaiKhoan { get; set; }
        public string GhiChu { get; set; }
        public Int64 QuyTien { get; set; }


    }
    public class KhoVatTu
    {
        public ObjectId id { get; set; }
        public string MaVT { get; set; }
        public string TenVT { get; set; }
        public Int64 SoLuong { get; set; }
        public string GhiChu { get; set; }

    }
    public class ThanhToan
    {
        public ObjectId id { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public Int64 PhaiTra { get; set; }
        public Int64 DaThanhToan { get; set; }
        public string ThoiGian { get; set; }
        public string MoTa { get; set; }


    }

}
