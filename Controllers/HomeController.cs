using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            Models.Message message = new Models.Message("Lux calls an animportt meeting, leading Lulu to invite some unexpected guests for a cozy night in. Pajama Guardian skins are now slumber partying it up in the League store for 1350 RP each (discounted if you own the Star Guardian skin)!");
            return View("index",message);
        }

        [HttpGet("numbers")]
        public IActionResult Numberpage()
        {
            int[] array = { 1,2,3,10,43,5 };
            Models.Number numlist = new Models.Number(array);
            return View("numbers", numlist);
        }

        [HttpGet("users")]
        public IActionResult Userspage()
        {
            string[] array = { "Moose Phillips","Sarah","Jerry","Rene Ricky","SBarbarah"};
            Models.User peoplelist = new Models.User(array);
            return View("users", peoplelist);
        }

        [HttpGet("user")]
        public IActionResult Userpage()
        {
            string ppl = "Moose Phillips";
            Models.User person = new Models.User(ppl);
            return View("user", person);
        }

    }
}
