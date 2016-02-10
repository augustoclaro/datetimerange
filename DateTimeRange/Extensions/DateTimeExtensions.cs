using System;

namespace DateTimeRange.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTimeRange RangeUntil(this DateTime startDate, DateTime? endDate)
            => DateTimeRange.Create(startDate, endDate);

        public static DateTimeRange RangeUntil(this DateTime? startDate, DateTime? endDate)
            => DateTimeRange.Create(startDate, endDate);

        public static DateTimeRange RangeSince(this DateTime endDate, DateTime? startDate)
            => DateTimeRange.Create(startDate, endDate);

        public static DateTimeRange RangeSince(this DateTime? endDate, DateTime? startDate)
            => DateTimeRange.Create(startDate, endDate);
    }
}