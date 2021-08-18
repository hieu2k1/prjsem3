using DemoProjectSem3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Web.Mvc;
using DemoProjectSem3.Context;

namespace DemoProjectSem3.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private DemoContext obj = new DemoContext();

        public ActionResult Index()
        {
            return View();
        }
        
    }
}