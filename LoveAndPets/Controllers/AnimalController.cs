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
    /// <summary>
    /// Контроллер для добавления вида животного
    /// </summary>
    public class AnimalController : Controller
    {
        private readonly AnimalDbContext _animalDbContext;

        public AnimalController(AnimalDbContext animalDbContext)
        {
            _animalDbContext = animalDbContext ?? throw new ArgumentNullException(nameof(animalDbContext));
        }
        
        [HttpGet]
        public IActionResult AddType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddType(NewTypeViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            //if (!ModelState.IsValid) return View();

            var post = new Animals
            {
                TypeName = model.Type
            };

            _animalDbContext.Animals.Add(post);

            _animalDbContext.SaveChanges();

            //return View();
            return View();
        }
    }
}
