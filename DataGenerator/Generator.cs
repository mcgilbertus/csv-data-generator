using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace DataGenerator
{
    public class Generator
    {
        private readonly List<IColumn> _columns;
        //private readonly string _configFilePath;
        private readonly string _outputFilePath;
        private readonly long _numberOfRecords;
        private readonly IInputParser _inputParser;

        public Generator(string outputFilePath, long numberOfRecords, IInputParser inputParser)
        {
            _columns = new List<IColumn>();
            //_configFilePath = configFilePath;
            _outputFilePath = outputFilePath;
            _numberOfRecords = numberOfRecords;
            _inputParser = inputParser;
            Initialize();
        }

        private void Initialize()
        {
            // parses the config file and creates the list of columns
            

            while (!_inputParser.EndOfFile())
            {
                // Read current line fields, pointer moves to the next line.
                var configLine = _inputParser.ParseNextColumn();
                    
                // config schema is fixed: fieldName, data type, format, from, to
                switch (configLine.DataType)
                {
                    case ColumnDataType.String:
                        _columns.Add(new StringColumn(configLine));
                        break;
                    case ColumnDataType.Long:
                        _columns.Add(new LongColumn(configLine));
                        break;
                    case ColumnDataType.Float:
                        _columns.Add(new FloatColumn(configLine));
                        break;
                    case ColumnDataType.Date:
                        _columns.Add(new DateColumn(configLine));
                        break;
                    case ColumnDataType.DateTime:
                        _columns.Add(new DateTimeColumn(configLine));
                        break;
                    case ColumnDataType.Time:
                        _columns.Add(new TimeColumn(configLine));
                        break;
                    default:
                        throw new Exception($"Data type not supported: {configLine.DataType}");
                }
            }
        }

        public void Generate()
        {
            using StreamWriter file = new(_outputFilePath);
            var header = string.Join(',', _columns.Select(col => '"'+col.Name+'"'));
            file.WriteLine(header);

            for (long i = 1; i <= _numberOfRecords; i++)
            {
                if (i % 100 == 0)
                    Console.WriteLine($"Generated {i} records");
                
                var line = string.Join(',', _columns.Select(col => col.GenerateValue()));
                file.WriteLine(line);
            }
        }
    }
}