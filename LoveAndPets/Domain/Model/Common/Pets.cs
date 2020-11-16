using LoveAndPets.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.Domain.Model.Common
{
    /// <summary>
    /// Анкета питомцев
    /// </summary>
    public class Pets:Entity
    {
        /// <summary>
        /// Кличка животого
        /// </summary>
        public string PetName { get; set; }
        /// <summary>
        /// Индентификатор хозяина животного
        /// </summary>
        public long EmployeeEntitys { get; set; }
        [ForeignKey("EmployeeEntitys")]
        public Employee Employee { get; set; }

        /// <summary>
        /// Индентификатор типа животного
        /// </summary>


        public long AnimalsEntitys { get; set; }
        [ForeignKey("AnimalsEntitys")]
        public Animals Animals { get; set; }

        /// <summary>
        /// Индентификатор породы животного
        /// </summary>

        public long BreedsEntitys { get; set; }
        [ForeignKey("BreedsEntitys")]
        public Breeds Breeds { get; set; }

    }
}
