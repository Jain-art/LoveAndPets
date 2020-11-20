using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoveAndPets.Domain.DB;
using LoveAndPets.Domain.Model.Common;
using LoveAndPets.Exceptions.Http;
using LoveAndPets.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace LoveAndPets.Controllers
{
    public class BreedController : Controller
    {
        private readonly AnimalDbContext _animalDbContext;

        public BreedController(AnimalDbContext animalDbContext)
        {
            _animalDbContext = animalDbContext ?? throw new ArgumentNullException(nameof(animalDbContext));
        }

        [HttpGet]
        public IActionResult AddBreed()
        {
            ViewBag.ListBreedName = _animalDbContext.Animals
               .Select(x => new BreedItemViewModel { TypeName = x.TypeName, Animals = x.Entitys })
               .ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddBreed(NewBreedViewModel model)
        {
            ViewBag.ListBreedName = _animalDbContext.Animals
              .Select(x => new BreedItemViewModel { TypeName = x.TypeName, Animals = x.Entitys })
              .ToList();

            if (!ModelState.IsValid)
                return View(model);

            var animal = _animalDbContext.Animals
                .FirstOrDefault(x => x.Entitys == model.Animals)
                ?? throw new NotFoundException(typeof(Services), model.Animals);

            var post = new Breeds
            {
                Animals = animal,
                BreedName = model.BreedName
            };

            _animalDbContext.Breeds.Add(post);

            _animalDbContext.SaveChanges();


            return View();
        }

    }
}
