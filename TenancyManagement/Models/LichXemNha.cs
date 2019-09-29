using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TenancyManagement.Models
{
    public class LichXemNha
    {
        public int HomeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateView { get; set; }
        public string Comment { get; set; }

        [ForeignKey("CustomerId")]
        public virtual KhachHang Customer { get; set; }

        [ForeignKey("HomeId")]
        public virtual Nha Home { get; set; }

    }
}
