using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoveAndPets.Domain.DB;
using LoveAndPets.Domain.Model.Common;
using LoveAndPets.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace LoveAndPets.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AnimalDbContext _animalDbContext;

        public ServiceController(AnimalDbContext animalDbContext)
        {
            _animalDbContext = animalDbContext ?? throw new ArgumentNullException(nameof(animalDbContext));
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(NewServiсeViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var post = new Services
            {
                ServiceName = model.Serviсe
            };

            _animalDbContext.Services.Add(post);

            _animalDbContext.SaveChanges();


            return View(model);
        }
    }
}



