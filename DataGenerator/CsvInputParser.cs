using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace DataGenerator
{
    public class CsvInputParser : IInputParser
    {
        public string InputFilePath { get; }
        private readonly TextFieldParser _csvParser;

        public CsvInputParser(string inputFilePath)
        {
            InputFilePath = inputFilePath;

            _csvParser = new TextFieldParser(InputFilePath);
            _csvParser.CommentTokens = new string[] { "#" };
            _csvParser.SetDelimiters(new string[] { "," });
            _csvParser.HasFieldsEnclosedInQuotes = true;
        }

        public bool EndOfFile()
        {
            return _csvParser.EndOfData;
        }

        public ColumnConfig ParseNextColumn()
        {
            return new ColumnConfig(_csvParser.ReadFields());
        }
    }
}
