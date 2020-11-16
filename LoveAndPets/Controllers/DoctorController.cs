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
    public class DoctorController : Controller
    {
        private readonly AnimalDbContext _animalDbContext;

        public DoctorController(AnimalDbContext animalDbContext)
        {
            _animalDbContext = animalDbContext ?? throw new ArgumentNullException(nameof(animalDbContext));
        }

        [HttpGet]
        public IActionResult AddDoctor()
        {
            ViewBag.ListServiseName = _animalDbContext.Services
                .Select(x => new DoctorItemViewModel { ServiceName = x.ServiceName, Service = x.Entitys })
                .ToList();

            return View();
        }


        [HttpPost]
        public IActionResult AddDoctor(NewDoctorViewModel model)
        {
            ViewBag.ListServiseName = _animalDbContext.Services
                .Select(x => new DoctorItemViewModel { ServiceName = x.ServiceName, Service = x.Entitys })
                .ToList();

            if (!ModelState.IsValid)
                return View(model);

            var service = _animalDbContext.Services
                .FirstOrDefault(x => x.Entitys == model.Services)
                ?? throw new NotFoundException(typeof(Services), model.Services);

            var post = new Doctors
            {
                FirstName = model.FirstName,
                Surname = model.Surname,
                Patronymic = model.Patronymic,
                Services = service
            };

            _animalDbContext.Doctors.Add(post);

            _animalDbContext.SaveChanges();


            return View();
        }
    }
}
