
using TimeTable207.Services.Contracts.Models;

namespace TimeTable207.Services.Contracts
{
    /// <summary>
    /// Работа с дисциплинами
    /// </summary>
    public interface IDisciplineService
    {
        /// <summary>
        /// Получает список <see cref="DisciplineModel"/>
        /// </summary>
        Task<IReadOnlyCollection<DisciplineModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получает <see cref="DisciplineModel"/> по идентификатору
        /// </summary>
        Task<DisciplineModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
