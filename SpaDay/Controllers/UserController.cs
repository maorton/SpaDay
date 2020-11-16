using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (verify == newUser.password)
            {
                ViewBag.name = newUser.username;
                return View("Index");
            }
             else
            {
                ViewBag.name = newUser.username;
                ViewBag.email = newUser.email;
                ViewBag.error = "The password does not match";
                return View("Add");
            }
        }
    }
}
