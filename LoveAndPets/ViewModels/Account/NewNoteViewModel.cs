using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.ViewModels.Account
{
    public class NewNoteViewModel
    {
        /// <summary>
        /// Идентификатор врача, к которому записываются на прием
        /// </summary>
        [Required]
        [Display(Name = "Id врача")]
        public long Doctors { get; set; }

        /// <summary>
        /// Идентификатор животного, которому нужно лечение
        /// </summary>
        [Required]
        [Display(Name = "Id животного")]
        public long Pets { get; set; }

        /// <summary>
        /// Дата, на которую назначен прием
        /// </summary>
        [Required]
        [Display(Name = "Дата приема")]
        public DateTime DateAppointment { get; set; }
    }
    
}
