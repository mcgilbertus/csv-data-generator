using System;

namespace DataGenerator
{
    public class TimeColumn : DateTimeColumn
    {
        public TimeColumn(ColumnConfig config) : base(config) { }

        public override string GenerateValue()
        {
            var seconds = r.NextDouble() * TimeBetween.TotalSeconds;
            return From.AddSeconds(seconds).ToString(Format);
        }
    }
}