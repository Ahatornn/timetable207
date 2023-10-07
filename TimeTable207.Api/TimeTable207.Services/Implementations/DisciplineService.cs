using TimeTable207.Repositories.Contracts.Disciplines;
using TimeTable207.Services.Contracts;
using TimeTable207.Services.Contracts.Models;

namespace TimeTable207.Services.Implementations
{
    public class DisciplineService : IDisciplineService
    {
        private readonly IDisciplineReadRepository repository;

        public DisciplineService(IDisciplineReadRepository repository)
        {
            this.repository = repository;
        }

        async Task<IReadOnlyCollection<DisciplineModel>> IDisciplineService.GetAllAsync(CancellationToken cancellationToken)
        {
            var items = await repository.GetAllAsync(cancellationToken);
            return items.Select(x => new DisciplineModel { Id = x.Id, Name = x.Name, Description = x.Description, }).ToArray();
        }

        async Task<DisciplineModel?> IDisciplineService.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var item = await repository.GetByIdAsync(id, cancellationToken);
            if (item == null)
            {
                return null;
            }

            return new DisciplineModel { Id = item.Id, Name = item.Name, Description = item.Description, };
        }
    }
}
