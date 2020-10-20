using LoveAndPets.Model.Common;

namespace LoveAndPets.Domain.Model.Common
{
    public class Services : Entity
    {
        /// <summary>
        /// название услуг, оказываемые врачами
        /// </summary>
        public string ServiceName { get; set; }

    }
}
