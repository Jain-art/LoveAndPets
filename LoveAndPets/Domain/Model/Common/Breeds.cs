using LoveAndPets.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoveAndPets.Domain.Model.Common
{
    public class Breeds : Entity
    {
        /// <summary>
        /// Id типа животного
        /// </summary>

   
        [ForeignKey("AnimalsEntitys")]
        public long AnimalsEntitys { get; set; }
        public Animals Animals { get; set; }
        /// <summary>
        /// название породы животных, принимаемых в клинике
        /// </summary>
        public string BreedName { get; set; }
    }
}
