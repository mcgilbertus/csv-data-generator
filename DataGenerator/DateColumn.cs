using System;

namespace DataGenerator
{
    public class DateColumn : DateTimeColumn
    {
        public DateColumn(ColumnConfig config) : base(config) { }

        public override string GenerateValue()
        {
            var days = r.Next(TimeBetween.Days);
            return From.AddDays(days).ToString(Format);
        }
    }
}