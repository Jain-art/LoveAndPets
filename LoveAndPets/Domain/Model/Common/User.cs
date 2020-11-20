using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoveAndPets.Domain.Model.Common

{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User : IdentityUser<int>
    {
        /// <summary>
        /// Профиль пользователя
        /// </summary>
        /// 
        public long EmployeeEntitys { get; set; }
        [ForeignKey("EmployeeEntitys")]     
        public Employee Employee { get; set; }

    }
}
