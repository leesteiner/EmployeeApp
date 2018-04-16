using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        

        //Methods
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }


        //Updated DisplayStats() now accounts for age
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Pay);
        }

        //Accessor (get method).
        public string GetName()
        {
            return Name;
        }

        //Mutator (set method)
        public void SetName(string name)
        {
            //Do a check on incoming value before making assignment.
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else { Name = name; }
            
        }
    }
}
