using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    public class ColumnType
    {
        public string Name { get; }
        public ColumnDataType DataType { get; }
        public double Range { get; }
        public string Format { get; }
        public bool Negative { get; }
        public double NegativeMin { get; }


        public ColumnType(string name, string dataType, string format, string min, string max)
        {
            Name = name;
            switch(dataType.ToLower())
            {
                case "string":
                    DataType = ColumnDataType.String;
                    break;

                case "int":
                    DataType = ColumnDataType.Integer;
                    NegativeMin = Int32.Parse(min);
                    Range = Int32.Parse(max) - NegativeMin;

                    // check if the min number is negative because the value will be subracted from range once 
                    if(NegativeMin < 0)
                    {
                        Negative = true;
                    }

                    else
                    {
                        Negative = false;
                    }

                    // if the range is negative it means both values are negative numbers so the range needs to be flipped to a positive number.
                    if(Range < 0)
                    {
                        Range = Math.Abs(Range);
                    }

                    break;

                case "float":
                    DataType = ColumnDataType.Float;
                    NegativeMin = Int32.Parse(min);
                    Range = Int32.Parse(max) - NegativeMin;

                    // check if the min number is negative because the value will be subracted from range once 
                    if (NegativeMin < 0)
                    {
                        Negative = true;
                    }

                    else
                    {
                        Negative = false;
                    }

                    // if the range is negative it means both values are negative numbers so the range needs to be flipped to a positive number.
                    if (Range < 0)
                    {
                        Range = Math.Abs(Range);
                    }

                    break;

                case "long":
                    DataType = ColumnDataType.Long;
                    NegativeMin = Int32.Parse(min);
                    Range = Int32.Parse(max) - NegativeMin;

                    // check if the min number is negative because the value will be subracted from range once 
                    if (NegativeMin < 0)
                    {
                        Negative = true;
                    }

                    else
                    {
                        Negative = false;
                    }

                    // if the range is negative it means both values are negative numbers so the range needs to be flipped to a positive number.
                    if (Range < 0)
                    {
                        Range = Math.Abs(Range);
                    }

                    break;

                case "date":
                    DataType = ColumnDataType.Date;
                    Range = (DateTime.Parse(max) - DateTime.Parse(min)).Days;
                    Format = format;
                    break;

                case "datetime":
                    DataType = ColumnDataType.DateTime;
                    Range = (DateTime.Parse(max) - DateTime.Parse(min)).TotalSeconds;
                    Format = format;
                    break;

                case "time":
                    DataType = ColumnDataType.Time;
                    Range = (DateTime.Parse(max) - DateTime.Parse(min)).TotalSeconds;
                    Format = format;
                    break;

                case "timestamp":
                    DataType = ColumnDataType.Timestamp;
                    Range =(DateTime.Parse(max) - DateTime.Parse(min)).TotalMilliseconds;
                    Format = format;
                    break;

                default:
                    throw new NotSupportedException("Format is not supported");
                    
            }
        }
    }
}
