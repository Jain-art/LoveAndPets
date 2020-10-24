using Microsoft.AspNetCore.Identity;

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
        public Employee Employee { get; set; }

    }
}
