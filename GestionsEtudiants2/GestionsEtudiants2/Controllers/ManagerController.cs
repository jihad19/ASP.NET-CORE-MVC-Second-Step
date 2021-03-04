using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionsEtudiants2.Controllers
{
    public class ManagerController : Controller
    {
        [Authorize(Roles= "Manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
