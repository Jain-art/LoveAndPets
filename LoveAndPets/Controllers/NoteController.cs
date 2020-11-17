using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoveAndPets.Domain.DB;
using LoveAndPets.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace LoveAndPets.Controllers
{
    public class NoteController : Controller
    {
        private readonly AnimalDbContext _animalDbContext;

        public NoteController(AnimalDbContext animalDbContext)
        {
            _animalDbContext = animalDbContext ?? throw new ArgumentNullException(nameof(animalDbContext));
        }

        [HttpGet]
        public IActionResult AddNote()
        {
            ViewBag.ListDoctorAndService = _animalDbContext.Doctors
                .Select(x => new NoteItemViewModel { DoctorName = x.FullName, Doctor = x.Entitys, Service=x.ServicesEntitys })
                .ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddNote(NewNoteViewModel model)
        {


            return View();
        }
        }
}
