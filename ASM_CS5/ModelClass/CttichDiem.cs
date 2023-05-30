using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("CTTichDiem")]
    public partial class CttichDiem
    {
        public CttichDiem()
        {
           
        }

        [Key]
        public Guid Id { get; set; }
        public int? HeSoTich { get; set; }
        public int? TrangThai { get; set; }


    }
}
