using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDEMO
{
    class employee
    {
        private string empname;
        private int Age;
        private  int Salary;
        private string CompanyName;
        private bool isMarried = false;


        public employee(string empname, int Age, int Salary)
        {
            this.empname = empname; 
            this.Age = Age;
            this.Salary = Salary;
        }
        public employee(string empname, int Age, int Salary,string CompanyName)
        {
            this.empname = empname;
            this.Age = Age;
            this.Salary = Salary;
            this.CompanyName=CompanyName;

        }

        public employee(string empname, int Age, int Salary, string CompanyName,bool ismarried)
        {
            this.empname = empname;
            this.Age = Age;
            this.Salary = Salary;
            this.CompanyName = CompanyName;
            this.isMarried=ismarried;

        }


        public void getdetails()
        {
            Console.WriteLine("Employee Name : " + empname);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Salary :" + Salary);
            if (this.CompanyName != null)
            {
                Console.WriteLine("CompanyName : " + this.CompanyName);
            }
            Console.WriteLine("Is Married : " + this.isMarried);
        }
    }
}
