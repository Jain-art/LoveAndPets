<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
=======
﻿using LoveAndPets.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc

namespace LoveAndPets.ViewModels.Account
{
    /// <summary>
    /// Модель для добавления новой услуги в базу клиники
    /// </summary>
    public class NewDoctorViewModel
    {
<<<<<<< HEAD

        /// <summary>
        /// Имя доктора
        /// </summary>
        [Required(ErrorMessage = "HH")]
=======
        
        /// <summary>
        /// Имя доктора
        /// </summary>
        [Required(ErrorMessage ="HH")]
>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc
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
<<<<<<< HEAD

=======
        
>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc

        /// <summary>
        /// Идентификатор услуги, предоставляемой врачом
        /// </summary>
        [Required]
        [Display(Name = "Id услуги")]
        public long Services { get; set; }
    }
}
