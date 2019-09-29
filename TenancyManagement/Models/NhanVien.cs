using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TenancyManagement.Models
{
    public class NhanVien
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public byte Genden { get; set; }
        public DateTime Birthday { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        public string Password { get; set; }

        public virtual ICollection<PhanCong> divisions { get; set; }
        public virtual ICollection<BanKyKet> contractDetail { get; set; }
    }
}
