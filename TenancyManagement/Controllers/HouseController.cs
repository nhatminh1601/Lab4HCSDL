using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TenancyManagement.Controllers
{
    public class HouseController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}