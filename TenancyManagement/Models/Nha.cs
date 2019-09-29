using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TenancyManagement.Models
{
    public class Nha
    {
        public int Id { get; set; }
        public int Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int Room { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int HouseOwnerId { get; set; }
        public int CategoryHomeId { get; set; }

        [ForeignKey("HouseOwnerId")]
        public virtual ChuNha HouseOwner { get; set; }

        [ForeignKey("CategoryHomeId")]
        public virtual LoaiNha CategoryHome { get; set; }

        public virtual ICollection<LichXemNha> ScheduleHome { get; set; }
    }
}
