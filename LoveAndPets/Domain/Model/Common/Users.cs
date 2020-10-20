using Microsoft.AspNetCore.Identity;

namespace LoveAndPets.Domain.Model.Common
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class Users : IdentityUser<int>
    {
        /// <summary>
        /// Профиль пользователя
        /// </summary>
        public Employee Employee { get; set; }

    }
}
