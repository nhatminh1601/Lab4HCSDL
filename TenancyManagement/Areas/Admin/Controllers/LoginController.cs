using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TenancyManagement.Areas.Admin.Common;
using TenancyManagement.Models;

namespace TenancyManagement.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly DatabaseContext _context;

        public LoginController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OnLogin(NhanVien model)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/Admin/Login");
            }
            var result = _context.NhanVien.Count(x => x.Name == model.Name && x.Password == model.Password);
            if (result > 0)
            {
                var nhanvien = _context.NhanVien.SingleOrDefault(x => x.Name == model.Name);
                HttpContext.Session.SetString("NameAdmin", nhanvien.Name);
                HttpContext.Session.SetInt32("IdAdmin", nhanvien.Id);

            }
           
            return Redirect("/Admin/Nhanviens");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("NameAdmin");
            return Redirect("/Admin/Login");
        }
    }
}