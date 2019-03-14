using System;

namespace Layley.Common.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Converts date and time of a particular timezone to UTC timezone.
        /// </summary>
        /// <param name="dateTimeValue">Date and time value to be converted to UTC timezone.</param>
        /// <param name="currentTimeZone">Timezone of the date time value provided.</param>
        /// <returns>Returns date and time converted in UTC timezone.</returns>
        public static DateTime ConvertToUTCTimeZone(this DateTime dateTimeValue, string currentTimeZone)
        {
            DateTime dtDateTime;

            if (currentTimeZone != "GMT Standard Time")
            {
                TimeZoneInfo tziCurrent = TimeZoneInfo.FindSystemTimeZoneById(currentTimeZone);
                dtDateTime = TimeZoneInfo.ConvertTime(dateTimeValue, tziCurrent, TimeZoneInfo.Utc);
                return dtDateTime;
            }
            else
            {
                return dateTimeValue;
            }
        }
    }
}
