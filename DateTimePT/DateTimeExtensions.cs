using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePT
{
    public static class DateTimeExtensions
    {
        public static DateTime SubtrackMinutes(this DateTime dt, int minutes)
        {
            return dt.AddMinutes(-1 * minutes);
        }

    }
}
