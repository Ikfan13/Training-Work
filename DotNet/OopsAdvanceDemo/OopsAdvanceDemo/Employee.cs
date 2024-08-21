using System.Security.Cryptography;

namespace OopsAdvanceDemo
{
    class Employee : Person
    {
        public Employee(string FirstName, string LastName, string Gender, int empid, int salary) :base(FirstName, LastName, Gender)
        {
            this.Salary = salary;
            this.empid = empid;
        }

        public int empid { get; internal set; }
        public int Salary { get; internal set; }


        public void DisplayEmployeeDetails()
        {
            base.DisplayDetails();
            //Console.WriteLine("Employee FirstName : " + base.FirstName);
            //Console.WriteLine("Employee LastName : " + base.LastName);
            //Console.WriteLine("Employee Gender : " + base.Gender);
            Console.WriteLine("Employee Id : " + empid);
            Console.WriteLine("Employee FirstName : " + Salary);
        }
    }
}