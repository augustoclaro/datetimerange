using System;

namespace DateTimeRange
{
    public class DateTimeRange
    {
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public TimeSpan Duration => EndDate - StartDate;

        private DateTimeRange(DateTime? startDate, DateTime? endDate)
        {
            StartDate = startDate ?? DateTime.MinValue;
            EndDate = endDate ?? DateTime.MaxValue;
        }

        public static DateTimeRange Create(DateTime? startDate = null, DateTime? endDate = null)
            => new DateTimeRange(startDate, endDate);

        public bool HasDate(DateTime date)
            => StartDate <= date && EndDate >= date;

        public bool HasDate(DateTime? date)
            => date != null && HasDate(date.Value);

        public bool HasRange(DateTimeRange range)
            => HasDate(range.StartDate) || HasDate(range.EndDate)
                || range.HasDate(StartDate) || range.HasDate(EndDate);

        public bool HasRange(DateTime? startDate, DateTime? endDate)
            => HasRange(Create(startDate, endDate));
    }
}