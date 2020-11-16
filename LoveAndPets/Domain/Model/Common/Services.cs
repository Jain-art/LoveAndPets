using LoveAndPets.Model.Common;
using System;

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
