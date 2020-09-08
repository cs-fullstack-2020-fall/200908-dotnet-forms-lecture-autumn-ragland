using Lecture.Models;
using Lecture.DAO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Lecture.Controllers
{
    public class HouseParty : Controller
    {
        public IActionResult Index()
        {
            return Content("Sanity");
        }
    }
}