﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KieuSP")]
    [Index(nameof(Ma), Name = "UQ__KieuSP__3214CC9E50424F78", IsUnique = true)]
    public partial class KieuSp
    {
        public KieuSp()
        {
            //ChiTietKieuSps = new HashSet<ChiTietKieuSp>();
            //InverseIdChaNavigation = new HashSet<KieuSp>();
        }

        [Key]
        public Guid Id { get; set; }
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }
    
        //public virtual KieuSp IdChaNavigation { get; set; }
        //[InverseProperty(nameof(ChiTietKieuSp.IdKieuSpNavigation))]
        //public virtual ICollection<ChiTietKieuSp> ChiTietKieuSps { get; set; }
        //[InverseProperty(nameof(KieuSp.IdChaNavigation))]
        //public virtual ICollection<KieuSp> InverseIdChaNavigation { get; set; }

        public KieuSp(Guid id, string ma, string ten, int? trangThai)
        {
            Id = id;
            Ma = ma;
            Ten = ten;
            TrangThai = trangThai;
        }
    }
}
