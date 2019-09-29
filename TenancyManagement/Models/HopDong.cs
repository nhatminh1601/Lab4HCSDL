using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TenancyManagement.Models
{
    public class HopDong
    {
        public int Id { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int HomeId { get; set; }

        [ForeignKey("HomeId")]
        public virtual Nha Home { get; set; }
        public virtual BanKyKet contractDetail { get; set; }
    }
}
