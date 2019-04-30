using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.DateTimeTools
{
    public static class DateTimeExtensions
    {
        public static DateTime SubtrackMinutes(this System.DateTime dt, int minutes)
        {
            return dt.AddMinutes(-1 * minutes);
        }

        public static DateTime SubtrackDays(this DateTime dt, int days)
        {
            return dt.AddDays(-1 * days);
        }

    }
}
