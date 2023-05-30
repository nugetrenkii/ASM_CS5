using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KhachHang")]
    [Index(nameof(Ma), Name = "UQ__KhachHan__3214CC9EE6E79646", IsUnique = true)]
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid Id { get; set; }
        public string Ma { get; set; }
        [StringLength(100)]
        public string Ten { get; set; }
        [StringLength(10)]
        public string Sdt { get; set; }
        [StringLength(500)]
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public int? TrangThai { get; set; }
        [Column("IDNV")]
        public Guid? Idnv { get; set; }

        [ForeignKey(nameof(Idnv))]
        [InverseProperty(nameof(NhanVien.KhachHangs))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
