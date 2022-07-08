using System;
using System.Collections.Generic;

namespace BillObject.Models
{
    public partial class KhachHang
    {
        public int? MaKh { get; set; }
        public string HoTenKh { get; set; }
        public double? DonGia { get; set; }
        public double? ThanhTien { get; set; }
        public int? SoLuong { get; set; }
        public string QuocTich { get; set; }
        public int? DinhMuc { get; set; }
        public string? LoaiKh { get; set; }

        public string? DiaChi { get; set; }
    }
}
