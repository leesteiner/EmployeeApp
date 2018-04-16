using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Encapsulation *****");
            Employee emp = new Employee("Marvin", 456, 30_000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            emp.Name = "Marv";
            Console.WriteLine($"Employee is named {emp.Name}");
            //Use the get/set methods to interact with the object.
            //emp.SetName("Marv");
            //Console.WriteLine($"Employee is named {emp.GetName()}");

            Console.ReadLine();

            Employee joe = new Employee("Joe", 35, 123, 30000);
            for (int i = 0; i < 10; i++)
            {
                joe.Age++;
                if (i % 2 == 0)
                {
                    joe.GiveBonus(5000);
                    Console.WriteLine($"{joe.Name} is {joe.Age} and just got a bonus. He now makes {joe.Pay}");
                }
            }
            Console.WriteLine($"{joe.Name} is {joe.Age} years old. He makes {joe.Pay} dollars a year");

        }
    }
}
