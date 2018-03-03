using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNETWEB_KCREVOLUTION.Areas.Inform.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DOTNETWEB_KCREVOLUTION.Controllers
{
    [Area("Inform")]
    public class InformController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new InformViewModel();
            return View(model);
        }

        public IActionResult WorshipSeries()
        {
            var model = new WorshipSeriesViewModel();
            return View(model);
        }

        public IActionResult Blog()
        {
            var model = new BlogViewModel();
            return View(model);
        }

        public IActionResult BlogDetail(int id)
        {
            var model = new BlogDetailViewModel(id);
            return View(model);
        }
    }
}
