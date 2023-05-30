﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

#nullable disable

namespace ASM_CS5.Migrations
{
    [DbContext(typeof(FpolyDBContext))]
    [Migration("20230530153747_zaa")]
    partial class zaa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1.DAL.DomainClass.Anh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<byte[]>("DuongDan")
                        .HasColumnType("image");

                    b.Property<Guid?>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenAnh")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdChiTietSp");

                    b.ToTable("Anh");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChatLieu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ__ChatLieu__3214CC9EF6F76785")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("ChatLieu");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietKieuSp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdChiTietSP");

                    b.Property<Guid?>("IdKieuSp")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdKieuSP");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdChiTietSp");

                    b.HasIndex("IdKieuSp");

                    b.ToTable("ChiTietKieuSP");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietSale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdChiTietSP");

                    b.Property<Guid?>("IdSale")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdChiTietSp");

                    b.HasIndex("IdSale");

                    b.ToTable("ChiTietSale");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietSp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("BaoHanh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("GiaBan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("GiaNhap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<Guid?>("IdChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKichCo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSp")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdSP");

                    b.Property<Guid?>("IdTeam")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaQr")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("MaQR");

                    b.Property<string>("MoTa")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TrangThaiKhuyenMai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdChatLieu");

                    b.HasIndex("IdKichCo");

                    b.HasIndex("IdMauSac");

                    b.HasIndex("IdSp");

                    b.ToTable("ChiTietSP");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ__ChucVu__3214CC9EC28D9F1A")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HinhThucMh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ__HinhThuc__3214CC9E0CA7194D")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("HinhThucMH");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<decimal?>("Cod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("COD")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("GiamGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("HinhThucGiamGia")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid?>("IdHt")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdHT");

                    b.Property<Guid?>("IdKh")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdKH");

                    b.Property<Guid?>("IdNv")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdNV");

                    b.Property<Guid?>("IdPttt")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdPTTT");

                    b.Property<Guid?>("IdUdtichDiem")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdUDTichDiem");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayNhan")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayShip")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("datetime");

                    b.Property<string>("Sdt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal?>("SoTienGiam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("TenNguoiNhan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("TienChuyenKhoan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("TienKhachDua")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("TienShip")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("TongTien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TrangThaiGiaoHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdHt");

                    b.HasIndex("IdKh");

                    b.HasIndex("IdNv");

                    b.HasIndex("IdPttt");

                    b.HasIndex(new[] { "Ma" }, "UQ__HoaDon__3214CC9E1D92A4A8")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<decimal?>("DonGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<Guid?>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdChiTietSP");

                    b.Property<Guid?>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SoLuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdChiTietSp");

                    b.HasIndex("IdHoaDon");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid?>("Idnv")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDNV");

                    b.Property<Guid?>("IdtichDiem")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDTichDiem");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Sdt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("Idnv");

                    b.HasIndex(new[] { "Ma" }, "UQ__KhachHan__3214CC9EE6E79646")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KichCo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<decimal?>("Cm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("CM")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Size")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ__KichCo__3214CC9E8648EBAF")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("KichCo");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KieuSp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("IdCha")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdCha");

                    b.HasIndex(new[] { "Ma" }, "UQ__KieuSP__3214CC9E50424F78")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("KieuSP");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ__MauSac__3214CC9EFCAA9610")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Cccd")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("CCCD");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("GioiTinh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ho")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid?>("IdCv")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdCV");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MatKhau")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime");

                    b.Property<string>("Sdt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TaiKhoan")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TenDem")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdCv");

                    b.HasIndex(new[] { "Ma" }, "UQ__NhanVien__3214CC9E5CF6BCD3")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.HasIndex(new[] { "Email" }, "UQ__NhanVien__A9D10534E6EA6CEB")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex(new[] { "TaiKhoan" }, "UQ__NhanVien__D5B8C7F006557263")
                        .IsUnique()
                        .HasFilter("[TaiKhoan] IS NOT NULL");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.PtthanhToan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ__PTThanhT__3214CC9E12765A5B")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("PTThanhToan");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("LoaiHinhKm")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("LoaiHinhKM");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("MucGiam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("NgayBatDau")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ__Sale__3214CC9E964BE275")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ__SanPham__3214CC9E43B12A9B")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.Anh", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.ChiTietSp", "IdChiTietSpNavigation")
                        .WithMany("Anhs")
                        .HasForeignKey("IdChiTietSp")
                        .HasConstraintName("FK9");

                    b.Navigation("IdChiTietSpNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietKieuSp", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.ChiTietSp", "IdChiTietSpNavigation")
                        .WithMany("ChiTietKieuSps")
                        .HasForeignKey("IdChiTietSp")
                        .HasConstraintName("FK__ChiTietKi__IdChi__55F4C372");

                    b.HasOne("_1.DAL.DomainClass.KieuSp", "IdKieuSpNavigation")
                        .WithMany("ChiTietKieuSps")
                        .HasForeignKey("IdKieuSp")
                        .HasConstraintName("FK__ChiTietKi__IdKie__55009F39");

                    b.Navigation("IdChiTietSpNavigation");

                    b.Navigation("IdKieuSpNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietSale", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.ChiTietSp", "IdChiTietSpNavigation")
                        .WithMany("ChiTietSales")
                        .HasForeignKey("IdChiTietSp")
                        .HasConstraintName("FK__ChiTietSa__IdChi__540C7B00");

                    b.HasOne("_1.DAL.DomainClass.Sale", "IdSaleNavigation")
                        .WithMany("ChiTietSales")
                        .HasForeignKey("IdSale")
                        .HasConstraintName("FK__ChiTietSa__IdSal__531856C7");

                    b.Navigation("IdChiTietSpNavigation");

                    b.Navigation("IdSaleNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietSp", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.ChatLieu", "IdChatLieuNavigation")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IdChatLieu")
                        .HasConstraintName("FK__ChiTietSP__IdCha__51300E55");

                    b.HasOne("_1.DAL.DomainClass.KichCo", "IdKichCoNavigation")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IdKichCo")
                        .HasConstraintName("FK__ChiTietSP__IdKic__4F47C5E3");

                    b.HasOne("_1.DAL.DomainClass.MauSac", "IdMauSacNavigation")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IdMauSac")
                        .HasConstraintName("FK__ChiTietSP__IdMau__4E53A1AA");

                    b.HasOne("_1.DAL.DomainClass.SanPham", "IdSpNavigation")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IdSp")
                        .HasConstraintName("FK__ChiTietSP__IdSP__4D5F7D71");

                    b.Navigation("IdChatLieuNavigation");

                    b.Navigation("IdKichCoNavigation");

                    b.Navigation("IdMauSacNavigation");

                    b.Navigation("IdSpNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.HinhThucMh", "IdHtNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdHt")
                        .HasConstraintName("FK__HoaDon__IdHT__4C6B5938");

                    b.HasOne("_1.DAL.DomainClass.KhachHang", "IdKhNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKh")
                        .HasConstraintName("FK__HoaDon__IdKH__498EEC8D");

                    b.HasOne("_1.DAL.DomainClass.NhanVien", "IdNvNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdNv")
                        .HasConstraintName("FK__HoaDon__IdNV__4A8310C6");

                    b.HasOne("_1.DAL.DomainClass.PtthanhToan", "IdPtttNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdPttt")
                        .HasConstraintName("FK__HoaDon__IdPTTT__4B7734FF");

                    b.Navigation("IdHtNavigation");

                    b.Navigation("IdKhNavigation");

                    b.Navigation("IdNvNavigation");

                    b.Navigation("IdPtttNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.ChiTietSp", "IdChiTietSpNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdChiTietSp")
                        .HasConstraintName("FK2");

                    b.HasOne("_1.DAL.DomainClass.HoaDon", "IdHoaDonNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdHoaDon")
                        .HasConstraintName("FK1");

                    b.Navigation("IdChiTietSpNavigation");

                    b.Navigation("IdHoaDonNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KhachHang", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.NhanVien", "IdnvNavigation")
                        .WithMany("KhachHangs")
                        .HasForeignKey("Idnv")
                        .HasConstraintName("FK__KhachHang__IDNV__58D1301D");

                    b.Navigation("IdnvNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KieuSp", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.KieuSp", "IdChaNavigation")
                        .WithMany("InverseIdChaNavigation")
                        .HasForeignKey("IdCha")
                        .HasConstraintName("FK11");

                    b.Navigation("IdChaNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.ChucVu", "IdCvNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdCv")
                        .HasConstraintName("FK__NhanVien__IdCV__489AC854");

                    b.Navigation("IdCvNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChatLieu", b =>
                {
                    b.Navigation("ChiTietSps");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietSp", b =>
                {
                    b.Navigation("Anhs");

                    b.Navigation("ChiTietKieuSps");

                    b.Navigation("ChiTietSales");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HinhThucMh", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KichCo", b =>
                {
                    b.Navigation("ChiTietSps");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KieuSp", b =>
                {
                    b.Navigation("ChiTietKieuSps");

                    b.Navigation("InverseIdChaNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.MauSac", b =>
                {
                    b.Navigation("ChiTietSps");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.NhanVien", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("KhachHangs");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.PtthanhToan", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.Sale", b =>
                {
                    b.Navigation("ChiTietSales");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.SanPham", b =>
                {
                    b.Navigation("ChiTietSps");
                });
#pragma warning restore 612, 618
        }
    }
}
