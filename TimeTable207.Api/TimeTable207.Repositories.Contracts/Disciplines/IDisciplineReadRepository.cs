using TimeTable207.Context.Contracts.Models;

namespace TimeTable207.Repositories.Contracts.Disciplines
{
    internal interface IDisciplineReadRepository
    {
        /// <summary>
        /// Получает список <see cref="Discipline"/>
        /// </summary>
        Task<IReadOnlyCollection<Discipline>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получает <see cref="Discipline"/> по идентификатору
        /// </summary>
        Task<Discipline> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
