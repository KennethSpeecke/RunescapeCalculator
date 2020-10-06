using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RunescapeCalculators.Controllers
{
    public class RunescapeController : Controller
    {
        [Route("Runescape")]
        [Route("Runescape/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Runescape/Lookup/{username?}")]
        public IActionResult LookupUser(string user) 
        {
            return View();
        }
    }
}
