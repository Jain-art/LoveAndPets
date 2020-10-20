using LoveAndPets.Model.Common;

namespace LoveAndPets.Domain.Model.Common
{
    public class Animals : Entity
    {
        /// <summary>
        /// название типа животного, принимаемого в клинике
        /// </summary>
        public string TypeName { get; set; }
    }
}
