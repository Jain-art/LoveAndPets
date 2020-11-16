using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.ViewModels.Account
{
    /// <summary>
    /// Модель для добавления нового вида животного в базу клиники
    /// </summary>
    public class NewTypeViewModel
    {
        /// <summary>
        /// Название нового типа животного
        /// </summary>
        [Required]
        [Display(Name = "Тип животного")]
        public string Type { get; set; }
        

        /// <summary>
        /// Добавить  новую запись  в базу
        /// </summary>
        [Display(Name = "Добавить данные в базу")]
        public bool RememberMe { get; set; }

    }
}
