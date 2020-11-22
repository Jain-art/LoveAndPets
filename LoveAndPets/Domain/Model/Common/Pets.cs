using LoveAndPets.Model.Common;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc

namespace LoveAndPets.Domain.Model.Common
{
    /// <summary>
    /// Анкета питомцев
    /// </summary>
<<<<<<< HEAD
    public class Pets : Entity
=======
    public class Pets:Entity
>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc
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
<<<<<<< HEAD
=======


>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc
        public long AnimalsEntitys { get; set; }
        [ForeignKey("AnimalsEntitys")]
        public Animals Animals { get; set; }

        /// <summary>
        /// Индентификатор породы животного
        /// </summary>
<<<<<<< HEAD
=======

>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc
        public long BreedsEntitys { get; set; }
        [ForeignKey("BreedsEntitys")]
        public Breeds Breeds { get; set; }

    }
}
