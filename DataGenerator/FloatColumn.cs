using System;

namespace DataGenerator
{
    public class FloatColumn : Column, IColumn
    {
        private readonly double _min;
        private readonly double _max;
        private readonly string _format;

        public FloatColumn(ColumnConfig config) : base(config.Name)
        {
            _min = double.Parse(config.From);
            _max = double.Parse(config.To);
            _format = config.Format;
        }

        public string GenerateValue()
        {
            var n = r.NextDouble() * (_max - _min);
            return string.Format(_format, _min+n);
        }
    }
}