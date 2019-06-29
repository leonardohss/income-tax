using System;
using IncomeTax.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace IncomeTax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int qt = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qt; i++)
            {
                Console.WriteLine($"Tax payer {i} data: ");
                Console.Write("Natural or Legal? (n/l): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (type)
                {
                    case 'n':
                        Console.Write("Health expenditures: ");
                        double hspend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        persons.Add(new NaturalPerson(name, income, hspend));
                        break;
                    case 'l':
                        Console.Write("Number of employees: ");
                        int employees = int.Parse(Console.ReadLine());
                        persons.Add(new LegalPerson(name, income, employees));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double totaltax = 0.0;
            foreach (Person x in persons) {
                Console.WriteLine($"{x.Name}: ${x.TaxCalc().ToString("F2", CultureInfo.InvariantCulture)}");

                totaltax =+ x.TaxCalc();
            }

            Console.WriteLine("Total taxes: " + totaltax);
        }
    }
}
