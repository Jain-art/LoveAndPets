using LoveAndPets.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.Domain.Model.Common
{
    
    public class Doctors: Entity
    {
        /// <summary>
        /// Имя доктора
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия доктора
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Отчество доктора
        /// </summary>
        public string Patronymic { get; set; }
        
        public string FullName
        {
            get => FirstName + "" + Surname + "" + Patronymic;
        }
        /// <summary>
        /// Индентификатор услуги, которую проводит врач
        /// </summary>
        [ForeignKey("ServicesEntitys")]
        public long ServicesEntitys { get; set; }        

        public Services Services { get; set; }
    }
}
