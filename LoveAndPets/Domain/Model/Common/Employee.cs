using LoveAndPets.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveAndPets.Domain.Model.Common
{
    public class Employee:Entity
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string Surname{ get; set; }
        /// <summary>
        /// Отчество пользователя
        /// </summary>
        public string Patronymic { get; set; }
      


    }
}
