using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.ViewModels.Account
{
    public class BreedItemViewModel
    {
        /// <summary>
        /// Идентификатор вида животного
        /// </summary>
        [Required]
        [Display(Name = "Id вида животного")]
        public long Animals { get; set; }

        /// <summary>
        /// Название вида животного
        /// </summary>
        [Required]
        [Display(Name = "Название вида животного")]

        public string TypeName { get; set; }
    }
}
