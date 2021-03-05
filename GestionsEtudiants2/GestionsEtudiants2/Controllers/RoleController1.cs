using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionsEtudiants2.Controllers
{
    public class RoleController1 : Controller
    {
        RoleManager<IdentityRole> _roleManager;
        public RoleController1(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList(); 
            return View(roles);
        }
        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            return View(new IdentityRole());
            await _roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
    }
}
