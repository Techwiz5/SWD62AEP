using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class SupportController : Controller
    {
        //this method will be called using a get and its prupose is to load the page
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string email,string query)
        {
            //ViewData,ViewBag
            if (string.IsNullOrEmpty(query))
            {
                ViewData["feedback"] = "Query was left empty";
            }
            else
            {
                ViewData["feedback"] = "Thank you for your query, we will get back to you soon";
            }
            // ViewBag.feedback = "";
            return View();
        }
    }
}
