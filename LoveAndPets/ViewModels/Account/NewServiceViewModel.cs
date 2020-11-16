using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.ViewModels.Account
{
    /// <summary>
    /// Модель для добавления нового врача
    /// </summary>
    public class NewServiсeViewModel
    {
        /// <summary>
        /// Название новой услуги
        /// </summary>
        [Required]
        [Display(Name = "Название услуги")]
        public string Serviсe { get; set; }


        /// <summary>
        /// Добавить  новую запись  в базу
        /// </summary>
        [Display(Name = "Довавить данные в базу")]
        public bool RememberMe { get; set; }
    }
}