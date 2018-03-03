using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNETWEB_KCREVOLUTION.Areas.Connect.Models;
using DOTNETWEB_KCREVOLUTION.Areas.Connect.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DOTNETWEB_KCREVOLUTION.Controllers
{
    [Area("Connect")]
    public class ConnectController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new ConnectViewModel();
            return View(model);
        }

        public IActionResult Calendar()
        {
            var model = new CalendarViewModel();
            return View(model);
        }

        public IActionResult SmallGroups()
        {
            var model = new SmallGroupsViewModel();
            return View(model);
        }

        public IActionResult RevKids()
        {
            var model = new RevKidsViewModel();
            return View(model);
        }
    }
}
