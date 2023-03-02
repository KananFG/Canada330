using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class330
{
    class Cars
    {
        public string brand;
        public string model;
        public int year;

        public void Scan()
        {
            Console.WriteLine($"{brand} {model} {year}");
        }
    }
}
