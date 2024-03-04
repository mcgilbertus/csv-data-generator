using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataGenerator
{
    public class JsonParser
    {
        private readonly List<IColumn> _columns;
        private readonly string _configFilePath;

        public JsonParser(string configFilePath)
        {
            _columns = new List<IColumn>();
            _configFilePath = configFilePath;
            Initialize();
        }

        public void Initialize()
        {
            var jsonString = File.ReadAllText(_configFilePath);
            JsonDocument json = JsonDocument.Parse(jsonString);
            var root = json.RootElement;
            var data = root.GetProperty("schema");
            JsonElement.ArrayEnumerator configLines = data.EnumerateArray();
            while (configLines.MoveNext())
            {
                var element = configLines.Current;
              
            }
            foreach(var line in configLines)
            {
                // need to convert all the property values to string as it is a of JSON type. All values in JSON file need to be in a string format.
                var configLine = new ColumnConfig(new string[] { line.GetProperty("fieldName").GetString(), line.GetProperty("dataType").GetString(), 
                    line.GetProperty("format").GetString(), line.GetProperty("from").GetString(), line.GetProperty("to").GetString() });

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
    }
}
