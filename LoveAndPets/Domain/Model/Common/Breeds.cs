using LoveAndPets.Model.Common;

namespace LoveAndPets.Domain.Model.Common
{
    public class Breeds : Entity
    {
        /// <summary>
        /// название породы животных, принимаемых в клинике
        /// </summary>
        public string BreedName { get; set; }
    }
}
