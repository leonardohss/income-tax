using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeTax.Entities
{
    class LegalPerson : Person
    {
        public int NumEmployees { get; set; }

        public LegalPerson(string name, double income, int numEmployees) 
            : base(name, income)
        {
            NumEmployees = numEmployees;
        }

        public override double TaxCalc()
        {
            if(NumEmployees < 10)
            {
                return Income * 0.16;
            } else
            {
                return Income * 0.14;
            }
        }
    }
}
