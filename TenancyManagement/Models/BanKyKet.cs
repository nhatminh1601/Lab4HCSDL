using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TenancyManagement.Models
{
    public class BanKyKet
    {
        public int ContractId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int Status { get; set; }
        public DateTime ExtensionDate { get; set; }

        [ForeignKey("ContractId")]
        public virtual HopDong Contract { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual NhanVien Employee { get; set; }
        [ForeignKey("CustomerId")]
        public virtual KhachHang Customer { get; set; }

    }
}
