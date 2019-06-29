using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeTax.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Person() { }

        public Person(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double TaxCalc();
    }
}
