using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        //Field data.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        /* public int age
         {
             get { return empAge; }
             set { empAge = value; }
         }
         */
        public int Age
        {
            get => empAge;
            set => empAge = value;
        }

        //Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15) { Console.WriteLine("Error! Name length exceeds 15 characters!"); }
                else { empName = value; }
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }


        // Updated Constructors
        public Employee() { }
        public Employee(string name, int id, float pay)
        : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }
    }
}
