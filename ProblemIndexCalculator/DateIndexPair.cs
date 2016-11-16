using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemIndexCalculator
{
    public class DateIndexPair
    {
        public string date
        {
            get;
            set;
        }
        public DateTime dt
        {
            get;
            set;
        }
        public int probIndex
        {
            get;
            set;
        }

        public DateIndexPair(String date, int probIndex)
        {
            this.date = date;
            this.probIndex = probIndex;
            ParseString(date);
        }
        private void ParseString(String s)
        {
            dt = DateTime.ParseExact(s.Substring(0, 6), "MMyyyy", CultureInfo.InvariantCulture);
        }
        public String GetDateText()
        {
            return dt.ToString("MMMM yyyy");
        }
        public String GetShortDateText()
        {
            return dt.ToString("MMM yyyy");
        }
        public String GetDateDirtyText()
        {
            return date;
        }

    }
}
