using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.ViewModels.Account
{
    public class NewBreedViewModel
    {
        /// <summary>
        /// Название породы животного
        /// </summary>
        [Required]
        [Display(Name = "Название породы животного")]
        public string BreedName { get; set; }


        /// <summary>
        /// Идентификатор вида животного
        /// </summary>
        [Required]
        [Display(Name = "Название вида животного")]
        public long Animals { get; set; }
    }
}
