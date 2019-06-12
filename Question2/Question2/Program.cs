using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rotorua Thermal Holiday Park User Login Application v1
            //kris Boyte 30016677
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(
                "**************************************\n" +
                "*****Rotorua Thermal Holiday Park*****\n" +
                "**************************************\n" +
                "     *****Employee  Payroll*****      \n" +
                "**************************************\n");
            
            //prompt user for input
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("please enter your annual gross salary: ");
            double grossSalary = double.Parse(Console.ReadLine());
            Console.Write("Please enter your tax rate: ");
            double taxRate = double.Parse(Console.ReadLine());

            //create Employee object
            Employee e01 = new Employee();

            //display output. Call CalcNet method and display result
            Console.WriteLine("{0} earns a gross salary of {1} and is taxed at {2}%\n" +
            "{0}'s net salary is ${3}", name, grossSalary, taxRate, e01.CalcNet(grossSalary, taxRate));
            
            Console.ReadLine();
        }
    }
    class Employee
    {
        private string name;
        private double grossSalary;
        private double taxRate;

        public string Name { get { return name; } set { name = value; } }
        public double GrossSalary { get { return grossSalary; } set { grossSalary = value; } }
        public double TaxRate { get { return taxRate; } set { taxRate = value; } }

        //constructor
        public Employee()
        {            
            Console.WriteLine("Employee record created.\n");
        }
        //method
        public double CalcNet(double grossSalary, double taxRate)
        {
            return grossSalary * (1 - (taxRate/100));
        }

    }
}
