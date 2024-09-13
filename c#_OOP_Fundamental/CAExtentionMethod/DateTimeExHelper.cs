using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExtentionMethod
{
    public static class DateTimeExHelper
    {
        public static bool IsWeekEnd(this DateTime value)
        {
  // this represent the method extention from DateTime its take us to can reusable method related DateTime Class
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday ; 
        
        }
        public static bool ISWeekDay(this DateTime value)

        {
            return !IsWeekEnd(value);
          
        }
        
    }
}
