using System;

namespace DataGenerator
{
    public class DateTimeColumn : Column, IColumn
    {
        protected readonly DateTime From;
        protected readonly TimeSpan TimeBetween;
        protected readonly string Format;
        
        public DateTimeColumn(ColumnConfig config): base(config.Name)
        {
            From = DateTime.Parse(config.From);
            var to = DateTime.Parse(config.To);
            TimeBetween = to.Subtract(From);
            Format = config.Format;
        }

        public virtual string GenerateValue()
        {
            var seconds = r.NextDouble() * TimeBetween.TotalSeconds;
            return From.AddSeconds(seconds).ToString(Format);
        }
    }
}