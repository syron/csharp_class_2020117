using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int longitude { get; set; }
        public int latitude { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
