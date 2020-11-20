using LoveAndPets.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.ViewModels.Account
{
    /// <summary>
    /// Модель для добавления новой услуги в базу клиники
    /// </summary>
    public class NewDoctorViewModel
    {
        
        /// <summary>
        /// Имя доктора
        /// </summary>
        [Required(ErrorMessage ="HH")]
        [Display(Name = "Имя доктора")]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия доктора
        /// </summary>
        [Required]
        [Display(Name = "Фамилия доктора")]
        public string Surname { get; set; }

        /// <summary>
        /// Отчество доктора
        /// </summary>
        [Required]
        [Display(Name = "Отчество доктора")]
        public string Patronymic { get; set; }
        

        /// <summary>
        /// Идентификатор услуги, предоставляемой врачом
        /// </summary>
        [Required]
        [Display(Name = "Id услуги")]
        public long Services { get; set; }
    }
}
