using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    public class Employee
    {

        public int id;
        public string name;
        public double salary;
        private static int count;


        public Employee(string name, int salary) 
        { 
            this.name = name;
            this.salary = salary;
            id = count;
            count++;

        }

       
        public override string ToString()
        {
            return $"ID : {id} Name : {name} Salary : {salary}"; 
        }


    }
}
