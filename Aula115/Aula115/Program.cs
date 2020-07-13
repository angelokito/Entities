using Aula115.Entities;
using System;
using Aula115.Entities.Enums;
using System.Globalization;


namespace Aula115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department 's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many Contracts to this worker?  ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);

            }


            Console.WriteLine("");
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY):  ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year =  int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Nome: "  +worker.name) ;




        }
    }
}
