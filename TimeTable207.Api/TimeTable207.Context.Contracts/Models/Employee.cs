using TimeTable207.Context.Contracts.Enums;

namespace TimeTable207.Context.Contracts.Models
{
    public class Employee : BaseAuditEntity
    {
        /// <inheritdoc cref="EmployeeTypes"/>
        public EmployeeTypes EmployeeType { get; set; }

        /// <summary>
        /// Идентификатор <inheritdoc cref="Person"/>
        /// </summary>
        public Guid PersonId { get; set; }
    }
}
