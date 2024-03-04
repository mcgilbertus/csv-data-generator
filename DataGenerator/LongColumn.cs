namespace DataGenerator
{
    public class LongColumn : Column, IColumn
    {
        private readonly long _min;
        private readonly long _max;

        public LongColumn(ColumnConfig config) : base(config.Name)
        {
            _min = long.Parse(config.From);
            _max = long.Parse(config.To);
        }

        public string GenerateValue()
        {
            var n = (long)(r.NextDouble() * (_max - _min));
            return (_min + n).ToString();
        }
    }
}