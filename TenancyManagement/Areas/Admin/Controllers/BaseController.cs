using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace TenancyManagement.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var sess = HttpContext.Session.GetString("NameAdmin");
            if (sess == null)
            {
                var redirectTarget = new RouteValueDictionary
                 {{"action", "Index"}, {"controller", "Login"},{"Area","Admin"} };

                context.Result = new RedirectToRouteResult(redirectTarget);
            }
            base.OnActionExecuted(context);
        }
    }
}