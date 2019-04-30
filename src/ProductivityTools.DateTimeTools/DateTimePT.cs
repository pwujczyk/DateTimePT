using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.DateTimeTools
{
    public class DateTimePT : IDateTimePT
    {
        public System.DateTime Now => System.DateTime.Now;
    }
}
