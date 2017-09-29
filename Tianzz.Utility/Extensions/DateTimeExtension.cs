using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class DateTimeExtension
    {
        public static int ComapreToToday(this DateTime value)
        {
            return value.CompareTo(DateTime.Now);
        }

        /// <summary>
        /// DateTime converter UTC 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long ToInt64(this DateTime value)
        {
            DateTime startTime = TimeZoneInfo.ConvertTimeToUtc(new DateTime(1970, 1, 1), TimeZoneInfo.Utc);

            return (long)((value - startTime).TotalSeconds);
        }

        /// <summary>
        /// UTC converter Datetime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this long value)
        {
            DateTime startTime = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1), TimeZoneInfo.Local);

            return startTime.AddSeconds(value);
        }

    }
}
