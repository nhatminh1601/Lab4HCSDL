using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TenancyManagement.Models
{
    public class YeuCau
    {
        public int CategoryHomeId { get; set; }
        public int CustomerId { get; set; }
        public string Require { get; set; }

        [ForeignKey("CategoryHomeId")]
        public virtual LoaiNha CategoryHome { get; set; }
        [ForeignKey("CustomerId")]
        public virtual KhachHang Customer { get; set; }
    }
}
