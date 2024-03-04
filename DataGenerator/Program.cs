using System;

namespace DataGenerator
{
    class Program
    {
        // args[0] is file input path, args[1] is the number of records to be casted into int format, args[2] is the file output path
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                throw new Exception("Usage: DataGenerator <config file> <nbr of records> <output file>");
            }
            //var inputFile = @"..\..\..\config1.json";
			//var Json = new JsonParser(inputFile);

           
            var inputParser = new JsonInputParser(args[0]);
            var records = long.Parse(args[1]);
            var outputFile = args[2];
            var generator = new Generator( outputFile, records, inputParser);
            Console.WriteLine($"Creating file {outputFile} with {records} records");
            generator.Generate();
            Console.WriteLine("All done!");
        }
    }
}