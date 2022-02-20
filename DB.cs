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
        public string NamSinh { get; set; }
        public Int64 Luong { get; set; }
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
    public class BangCong
    {
        public ObjectId id { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioVao { get; set; }
        public string GioRa { get; set; }
        public Int64 CongViec { get; set; }//1. làm bth  2. bốc xếp 3.trả ứng
        public Int64 PhuPhi { get; set; }
        public Int64 TraGon { get; set; }
        public string MoTa { get; set; }
    }

    public class HangHoaGD
    {
        public ObjectId id { get; set; }
        public string MaKH { get; set; }
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public Int64 SoLuong { get; set; }
        public Int64 DonGia { get; set; }
        public Int64 XuatNhap { get; set; }// 0 la nhap 1 la xuat
        public Int64 PhuPhi { get; set; }
        public Int64 TongTien { get; set; }
        public string MoTa { get; set; }
        public string ThoiGian { get; set; }
    }
    public class VatTuGD
    {
        public ObjectId id { get; set; }
        public string MaKH { get; set; }
        public string MaVT { get; set; }
        public string TenVT { get; set; }
        public Int64 SoLuong { get; set; }
        public Int64 DonGia { get; set; }
        public Int64 XuatNhap { get; set; }// 0 la nhap 1 la xuat
        public Int64 PhuPhi { get; set; }
        public Int64 TongTien { get; set; }
        public string MoTa { get; set; }
        public string ThoiGian { get; set; }
    }

}
