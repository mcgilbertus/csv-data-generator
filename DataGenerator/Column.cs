using System;

namespace DataGenerator
{
    public class Column
    {
        protected readonly Random r;
        public string Name { get; }

        protected Column(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            r = new Random();
        }
    }
}