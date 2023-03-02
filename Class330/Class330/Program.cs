
using Class330;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class330
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars ca1 = new Cars()
            {
                brand = "Toyota",
                model = "Camry",
                year = 2021
            };
            Cars ca2 = new Cars()
            {
                brand = "Toyota",
                model = "Rav4",
                year = 2019
            };
            Cars ca3 = new Cars()
            {
                brand = "BMW",
                model = "X7",
                year = 2023
            };
            Cars ca4 = new Cars()
            {
                brand = "Mercedenz",
                model = "GL",
                year = 2008
            };

            ca1.Scan();
            ca2.Scan();
            ca3.Scan();
            ca4.Scan();

        }
    }
}

 