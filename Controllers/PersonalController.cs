using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using fisrtApplication.Models;

namespace fisrtApplication.Controllers
{
    public class PersonalController : Controller
    {
       

        public IActionResult Index ()
    { 
       Personal Personal = new Personal();
        Personal.name = "Katia";
        Personal.lastname = "Orellana";
        Personal.age = 20;
        Personal.number = 60606282;
        Personal.Email ="katia2orellana@gmail.com";
        Personal.address ="Santa Rosa de Lima , La Unión";
    
        return View(Personal);
        
     }   
    }
}