using LoveAndPets.Model.Common;
using System;
using System.Collections.Generic;
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
        /// Индентификатор хозяина животного
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// Индентификатор типа животного
        /// </summary>
        public long AnimalId { get; set; }
        /// <summary>
        /// Индентификатор породы животного
        /// </summary>
        public long BreedId { get; set; }

    }
}
