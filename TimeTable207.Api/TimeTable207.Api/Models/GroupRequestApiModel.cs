namespace TimeTable207.Api.Models
{
    public class GroupRequestApiModel
    {
        /// <summary>
        /// Наименование группы
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Описание группы
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
