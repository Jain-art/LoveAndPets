using LoveAndPets.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.ViewModels.Account
{
    public class DoctorItemViewModel
    {
        /// <summary>
        /// Идентификатор услуги, предоставляемой врачом
        /// </summary>
        [Required]
        [Display(Name = "Id услуги")]
        public long Service { get; set; }

        /// <summary>
        /// Название услуги, предоставляемой врачом
        /// </summary>
        [Required]
        [Display(Name = "Название  услуги")]

        public string ServiceName { get; set; }
    }
}
