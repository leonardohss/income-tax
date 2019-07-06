using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeTax.Entities
{
    class NaturalPerson : Person
    {
        public double HealthSpending { get; set; }

        public NaturalPerson() { }

        public NaturalPerson(string name, double income, double healthSpending) 
            : base(name, income)
        {
            HealthSpending = healthSpending;
        }

        public override double TaxCalc()
        {
            if(Income < 20000.00)
            {
                return (Income * 0.15) - (HealthSpending / 2);
            } else
            {
                return (Income * 0.25) - (HealthSpending * 0.5);
            }
        }
    }
}
