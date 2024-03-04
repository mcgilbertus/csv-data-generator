using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataGenerator
{
    public class JsonInputParser : IInputParser
    {
        public string InputFilePath { get; }
        private readonly JsonElement[] _elements;
        private int _position;

        public JsonInputParser(string inputFilePath)
        {
            InputFilePath = inputFilePath;
             var jsonString = File.ReadAllText(InputFilePath);
            JsonDocument json = JsonDocument.Parse(jsonString);
            var root = json.RootElement;
            var data = root.GetProperty("schema");
            _elements = data.EnumerateArray().ToArray();
            _position = 0;
        }

        public bool EndOfFile()
        {
            return _position == _elements.Length;
        }

        public ColumnConfig ParseNextColumn()
        {
            var current  = _elements[_position];
            _position++;
            return new ColumnConfig(new string[] { current.GetProperty("fieldName").GetString(), current.GetProperty("dataType").GetString(),
                    current.GetProperty("format").GetString(), current.GetProperty("from").GetString(), current.GetProperty("to").GetString() });
        }
    }
}