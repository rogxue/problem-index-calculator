using System;
using System.Globalization;

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
        public double rty
        {
            get;
            set;
        }
        public double oba
        {
            get;
            set;
        }
        public int hot
        {
            get;
            set;
        }
        public double agrr
        {
            get;
            set;
        }
        public DateIndexPair()
        {

        }
        public DateIndexPair(String date, int probIndex)
        {
            this.date = date;
            this.probIndex = probIndex;
            ParseString(date);
        }
        public DateIndexPair(String date, int probIndex, double rty, double oba, int hot, double agrr)
        {
            this.date = date;
            this.probIndex = probIndex;
            this.rty = rty;
            this.oba = oba;
            this.hot = hot;
            this.agrr = agrr;
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
            return dt.ToString("MMM. yyyy");
        }
        public String GetDateDirtyText()
        {
            return date;
        }

    }
}
