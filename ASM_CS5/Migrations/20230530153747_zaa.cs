using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASM_CS5.Migrations
{
    public partial class zaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatLieu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HinhThucMH",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhThucMH", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KichCo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Size = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CM = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KichCo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KieuSP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdCha = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuSP", x => x.Id);
                    table.ForeignKey(
                        name: "FK11",
                        column: x => x.IdCha,
                        principalTable: "KieuSP",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PTThanhToan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PTThanhToan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    LoaiHinhKM = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MucGiam = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    MoTa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdCV = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sdt = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CCCD = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    MatKhau = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TaiKhoan = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK__NhanVien__IdCV__489AC854",
                        column: x => x.IdCV,
                        principalTable: "ChucVu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKichCo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdTeam = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaQR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BaoHanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoLuongTon = table.Column<int>(type: "int", nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    GiaBan = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    TrangThaiKhuyenMai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSP", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ChiTietSP__IdCha__51300E55",
                        column: x => x.IdChatLieu,
                        principalTable: "ChatLieu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__ChiTietSP__IdKic__4F47C5E3",
                        column: x => x.IdKichCo,
                        principalTable: "KichCo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__ChiTietSP__IdMau__4E53A1AA",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__ChiTietSP__IdSP__4D5F7D71",
                        column: x => x.IdSP,
                        principalTable: "SanPham",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IDTichDiem = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sdt = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    IDNV = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK__KhachHang__IDNV__58D1301D",
                        column: x => x.IDNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Anh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdChiTietSp = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenAnh = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DuongDan = table.Column<byte[]>(type: "image", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anh", x => x.Id);
                    table.ForeignKey(
                        name: "FK9",
                        column: x => x.IdChiTietSp,
                        principalTable: "ChiTietSP",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietKieuSP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdKieuSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietKieuSP", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ChiTietKi__IdChi__55F4C372",
                        column: x => x.IdChiTietSP,
                        principalTable: "ChiTietSP",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__ChiTietKi__IdKie__55009F39",
                        column: x => x.IdKieuSP,
                        principalTable: "KieuSP",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdSale = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSale", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ChiTietSa__IdChi__540C7B00",
                        column: x => x.IdChiTietSP,
                        principalTable: "ChiTietSP",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__ChiTietSa__IdSal__531856C7",
                        column: x => x.IdSale,
                        principalTable: "Sale",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPTTT = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdHT = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdUDTichDiem = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayShip = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayNhan = table.Column<DateTime>(type: "datetime", nullable: true),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sdt = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    GiamGia = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    HinhThucGiamGia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    SoTienGiam = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    TienKhachDua = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    TienChuyenKhoan = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    TienShip = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    COD = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    TrangThaiGiaoHang = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK__HoaDon__IdHT__4C6B5938",
                        column: x => x.IdHT,
                        principalTable: "HinhThucMH",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__HoaDon__IdKH__498EEC8D",
                        column: x => x.IdKH,
                        principalTable: "KhachHang",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__HoaDon__IdNV__4A8310C6",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__HoaDon__IdPTTT__4B7734FF",
                        column: x => x.IdPTTT,
                        principalTable: "PTThanhToan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    DonGia = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK1",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK2",
                        column: x => x.IdChiTietSP,
                        principalTable: "ChiTietSP",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anh_IdChiTietSp",
                table: "Anh",
                column: "IdChiTietSp");

            migrationBuilder.CreateIndex(
                name: "UQ__ChatLieu__3214CC9EF6F76785",
                table: "ChatLieu",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKieuSP_IdChiTietSP",
                table: "ChiTietKieuSP",
                column: "IdChiTietSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKieuSP_IdKieuSP",
                table: "ChiTietKieuSP",
                column: "IdKieuSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdChiTietSP",
                table: "ChiTietSale",
                column: "IdChiTietSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdSale",
                table: "ChiTietSale",
                column: "IdSale");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdChatLieu",
                table: "ChiTietSP",
                column: "IdChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdKichCo",
                table: "ChiTietSP",
                column: "IdKichCo");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdMauSac",
                table: "ChiTietSP",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdSP",
                table: "ChiTietSP",
                column: "IdSP");

            migrationBuilder.CreateIndex(
                name: "UQ__ChucVu__3214CC9EC28D9F1A",
                table: "ChucVu",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__HinhThuc__3214CC9E0CA7194D",
                table: "HinhThucMH",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdHT",
                table: "HoaDon",
                column: "IdHT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKH",
                table: "HoaDon",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNV",
                table: "HoaDon",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdPTTT",
                table: "HoaDon",
                column: "IdPTTT");

            migrationBuilder.CreateIndex(
                name: "UQ__HoaDon__3214CC9E1D92A4A8",
                table: "HoaDon",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdChiTietSP",
                table: "HoaDonChiTiet",
                column: "IdChiTietSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_IDNV",
                table: "KhachHang",
                column: "IDNV");

            migrationBuilder.CreateIndex(
                name: "UQ__KhachHan__3214CC9EE6E79646",
                table: "KhachHang",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__KichCo__3214CC9E8648EBAF",
                table: "KichCo",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KieuSP_IdCha",
                table: "KieuSP",
                column: "IdCha");

            migrationBuilder.CreateIndex(
                name: "UQ__KieuSP__3214CC9E50424F78",
                table: "KieuSP",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__MauSac__3214CC9EFCAA9610",
                table: "MauSac",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCV",
                table: "NhanVien",
                column: "IdCV");

            migrationBuilder.CreateIndex(
                name: "UQ__NhanVien__3214CC9E5CF6BCD3",
                table: "NhanVien",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__NhanVien__A9D10534E6EA6CEB",
                table: "NhanVien",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__NhanVien__D5B8C7F006557263",
                table: "NhanVien",
                column: "TaiKhoan",
                unique: true,
                filter: "[TaiKhoan] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__PTThanhT__3214CC9E12765A5B",
                table: "PTThanhToan",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Sale__3214CC9E964BE275",
                table: "Sale",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__SanPham__3214CC9E43B12A9B",
                table: "SanPham",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anh");

            migrationBuilder.DropTable(
                name: "ChiTietKieuSP");

            migrationBuilder.DropTable(
                name: "ChiTietSale");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "KieuSP");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "ChiTietSP");

            migrationBuilder.DropTable(
                name: "HinhThucMH");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "PTThanhToan");

            migrationBuilder.DropTable(
                name: "ChatLieu");

            migrationBuilder.DropTable(
                name: "KichCo");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
