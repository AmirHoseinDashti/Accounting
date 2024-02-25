using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Utility.Convertor
{
   public static class DateConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar ps = new PersianCalendar();
            return ps.GetYear(value) + "/" + ps.GetMonth(value).ToString("00") + "/" +
                   ps.GetDayOfMonth(value).ToString("00");
        }
        public static DateTime ToMiladi(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new System.Globalization.PersianCalendar());
        }
    }
}
