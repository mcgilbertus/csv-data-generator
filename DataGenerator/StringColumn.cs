namespace DataGenerator
{
    public class StringColumn : Column, IColumn
    {
        private readonly string _format;
        private readonly long _min;
        private readonly long _max;

        public StringColumn(ColumnConfig config) : base(config.Name)
        {
            _min = string.IsNullOrEmpty(config.From) ? 1 : int.Parse(config.From);
            _max = string.IsNullOrEmpty(config.To) ? int.MaxValue : int.Parse(config.To);
            _format = config.Format;
        }

        public string GenerateValue()
        {
            var n = (long)(r.NextDouble() * (_max-_min));
            return $"\"{string.Format(_format, n).Replace("\"","\\\"")}\"";
        }
    }
}