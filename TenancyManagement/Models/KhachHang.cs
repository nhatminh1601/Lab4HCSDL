using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TenancyManagement.Models
{
    public class KhachHang
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string Address { get; set; }
        public int BranchId { get; set; }
        public string Password { get; set; }

        [ForeignKey("BranchId")]
        public virtual ChiNhanh Branch { get; set; }
        public virtual ICollection<BanKyKet> contractDetail { get; set; }
        public virtual ICollection<LichXemNha> ScheduleHome { get; set; }
    }
}
