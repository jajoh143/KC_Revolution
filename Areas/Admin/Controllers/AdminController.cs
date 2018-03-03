using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNETWEB_KCREVOLUTION.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DOTNETWEB_KCREVOLUTION.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            var model = new AdminDashboardViewModel();
            return View(model);
        }

    }
}
