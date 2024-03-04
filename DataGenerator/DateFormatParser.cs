using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    class DateFormatParser
    {
        private bool year;
        private bool month;
        private bool day;
        private bool hour;
        private bool minutes;
        private bool seconds;
        private string dataType;

        public DateFormatParser(string dataType)
        {
            year = true;
            month = true;
            day = true;
            hour = true;
            minutes = true;
            seconds = true;
            this.dataType = dataType;
        }

        public void parseFormat(string format)
        {
            if(dataType.Contains("date"))
            {
                if(!format.Contains("YYYY"))
                {
                    year = false;
                }

                if(!format.Contains("MM"))
                {
                    month = false;
                }

                if(!format.Contains("DD"))
                {
                    day = false;
                }
            }

            if(dataType.Contains("time"))
            {
                if(!format.Contains("HH"))
                {
                    hour = false;
                }

                if(!format.Contains("mm"))
                {
                    minutes = false;
                }

                if(!format.Contains("SS"))
                {
                    seconds = false;
                }
            }
        }
    }
}
