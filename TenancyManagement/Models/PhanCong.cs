using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TenancyManagement.Models
{
    public class PhanCong
    {
        public byte Status { get; set; }
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual NhanVien Employees { get; set; }
        [ForeignKey("BranchId")]
        public virtual ChiNhanh Branch { get; set; }
    }
}
