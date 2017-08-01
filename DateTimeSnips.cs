using System;

namespace dotNetSnips {
    public class DateTimeSnips {
        public DateTime DaylightOffset(string timezone = null) {
            var timezone = timezone || "Pacific Standard Time";
            DateTime utc = DateTime.UtcNow;
            TimeZoneInfo zone = TimeZoneInfo.FindSystemTimeZoneById(timezone);
            return TimeZoneInfo.ConvertTimeFromUtc(utc, zone);
        }
    }
}
