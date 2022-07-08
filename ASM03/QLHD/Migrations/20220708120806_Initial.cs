using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLHD.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTenKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: true),
                    ThanhTien = table.Column<double>(type: "float", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    QuocTich = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DinhMuc = table.Column<int>(type: "int", nullable: true),
                    LoaiKH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKH);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhachHang");
        }
    }
}
