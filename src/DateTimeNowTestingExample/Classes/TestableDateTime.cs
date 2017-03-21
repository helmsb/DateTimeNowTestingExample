using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateTimeNowTestingExample.Classes
{
    public static class TestableDateTime
    {
        public static Func<DateTime> GetDateTimeNow = () => DateTime.Now;

        public static DateTime GetCurrentDateTime
        {
            get
            {
                return GetDateTimeNow();
            }
        }
    }
}
