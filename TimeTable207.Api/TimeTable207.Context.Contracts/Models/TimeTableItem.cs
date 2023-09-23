﻿namespace TimeTable207.Context.Contracts.Models
{
    /// <summary>
    /// Элемент расписания
    /// </summary>
    public class TimeTableItem : BaseAuditEntity
    {
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// Идентификатор дисциплины
        /// </summary>
        public Guid DisciplineId { get; set; }

        /// <summary>
        /// Идентификатор группы
        /// </summary>
        public Guid GroupId { get; set; }

        /// <summary>
        /// Номер аудитории
        /// </summary>
        public short RoomNumber { get; set; }

        /// <summary>
        /// Преподаватель
        /// </summary>
        public Employee? Teacher { get; set; }
    }
}
