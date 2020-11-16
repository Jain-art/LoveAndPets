using LoveAndPets.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.Domain.Model.Common
{
    /// <summary>
    /// Запись на прием к врачу
    /// </summary>
    public class Notes: Entity
    {
        /// <summary>
        /// Id доктора, к которому записался клиент
        /// </summary>
           
        public long DoctorsEntitys { get; set; }
        [ForeignKey("DoctorsEntitys")]
        public Doctors Doctors { get; set; }
        /// <summary>
        /// Id Клиента, записавшегося наприем
        /// </summary>

        public long EmployeeEntitys { get; set; }
        [ForeignKey("EmployeeEntitys")]
        public Employee Employee { get; set; }
        /// <summary>
        /// Id Животного, нуждающегося в лечении
        /// </summary>

        public long PetsEntitys { get; set; }
        [ForeignKey("PetsEntitys")]
        public Pets Pets { get; set; }
        /// <summary>
        /// Дата назначенного приема
        /// </summary>
        public DateTime DateAppointment { get; set; }
    }
}
