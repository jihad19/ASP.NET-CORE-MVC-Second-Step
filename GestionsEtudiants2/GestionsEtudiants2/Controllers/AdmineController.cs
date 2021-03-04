using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionsEtudiants2.Controllers
{
    public class AdmineController : Controller
    {
        [Authorize(Roles="Admine")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
