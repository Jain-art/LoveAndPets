namespace LoveAndPets.Model.Common
{
    /// <summary>
    /// Интерфейс модели сущности предметной области
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// создание экземпляра модели мущности предметной области
        /// </summary>
        protected Entity() { }

        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        public virtual long Id { get; set; }
    }
}
