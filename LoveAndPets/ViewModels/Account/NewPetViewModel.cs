
using System.ComponentModel.DataAnnotations;
namespace LoveAndPets.ViewModels.Account
{
    /// <summary>
    /// Регистрация питомца
    /// </summary>
    public class NewPetViewModel
    {
        /// <summary>
        /// Кличка питомца
        /// </summary>
        [Required]
        [Display(Name = "Кличка питомца")]
        public string PetName { get; set; }
        /// <summary>
        /// Индентификатор хозяина животного
        /// </summary>
        [Required]
        [Display(Name = "Id хозяина")]
        public long EmployeeEntitys { get; set; }
        [ForeignKey("EmployeeEntitys")]
        [Required]
        [Display(Name = "Хозяин")]
        public Employee Employee { get; set; }

        /// <summary>
        /// Индентификатор типа питомца
        /// </summary>
        [Required]
        [Display(Name = "Id типа питомца")]
        public long AnimalsEntitys { get; set; }
        [ForeignKey("AnimalsEntitys")]
        public Animals Animals { get; set; }

        /// <summary>
        /// Индентификатор породы животного
        /// </summary>
        [Required]
        [Display(Name = "Id породы питомца")]
        public long BreedsEntitys { get; set; }
        [ForeignKey("BreedsEntitys")]

        [Required]
        [Display(Name = "Название породы")]
        public Breeds Breeds { get; set; }
    }
}
