using System;

namespace DataGenerator
{
    public struct ColumnConfig
    {
        public string Name { get; set; }
        public ColumnDataType DataType { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Format { get; set; }

        public ColumnConfig(string[] configs)
        {
            if (configs.Length < 5)
                throw new ArgumentException("Not enough arguments for field");
            Name = configs[0];
            DataType = (ColumnDataType)Enum.Parse(typeof(ColumnDataType), configs[1], true);
            Format = configs[2];
            From = configs[3];
            To = configs[4];
        }
    }
}