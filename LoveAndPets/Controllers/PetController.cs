﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.Controllers
{
    public class PetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
