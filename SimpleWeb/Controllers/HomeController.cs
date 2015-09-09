using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.Configuration;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            this.ViewBag.PublicName = this._configuration["PublicName"];
            this.ViewBag.SecretName = this._configuration["SecretName"];
            return View();
        }
    }
}
