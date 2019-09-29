using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TenancyManagement.Models
{
    public class ChuNha
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
