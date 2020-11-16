using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.ViewModels.Account
{
    public class IdTypeViewModel
    {
        /// <summary>
        /// Id 
        /// Id  животного
        /// </summary>
        [Required]
        [Display(Name = "Идентификатор животного")]
        public long Id { get; set; }
        /// <summary>
        /// Название типа
        /// </summary>
        [Required]
        [Display(Name = "тип животного")]
        public string TypeName { get; set; }
    }
}
