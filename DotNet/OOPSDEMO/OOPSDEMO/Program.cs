namespace OOPSDEMO
{
    internal class Program
    {
        //class Age
        //{
        //    private readonly int _year;
        //    public Age(int year)
        //    {
        //        this._year = year;
        //    }
        //    public void getAge()
        //    {

        //        Console.WriteLine(this._year);
        //    }
        //}
        private static void Main(string[] args)
        {
            Student s1, s2;
            s1 = new Student() { studentId = 1, studentname = "Nirmal", marks = 100 };
            s1.Age = 25;

            s2 = new Student() { studentId = 2, studentname = "Raj", marks = 90 };
            Console.WriteLine("Student: " + s1.studentId);
            Console.WriteLine("Name: " + s1.studentname);
            Console.WriteLine("Marks: " + s1.marks);
            Console.WriteLine("Age: " + s1.Age);

            Console.WriteLine("Student: " + s2.studentId);
            Console.WriteLine("Name: " + s2.studentname);
            Console.WriteLine("Marks: " + s2.marks);
            Console.WriteLine("Age: " + s2.Age);




            //employee e1, e2, e3;

            //e1 = new employee("Ikfan",24,50000);
            //e1.getdetails();
            //e2 = new employee("Ikfan", 24, 50000,"ChangePond Technlogies");
            //e2.getdetails();

            //User u1, u2, u3, u4;

            //Console.WriteLine("Enter the user name : ");
            //string uname = Console.ReadLine();
            //Console.WriteLine("Enter the password : ");
            //string upass = Console.ReadLine();
            //u1 = new User(uname, upass);
            //string result = u1.checkLogin();
            //Console.WriteLine(result);
            //u2 = new User("Sandhya", "Nirmal Raj", "Guest User");
            //u2.getDetails();
            //result = u2.checkLogin();
            //Console.WriteLine(result);

            //u3 = new User("Ikfan", "ik", "Guest User", "Chennai");
            //u3.getDetails();
            //result = u3.checkLogin();
            //Console.WriteLine(result);

            //u4 = new User("Nirmal", "Raj", "I am Joker", "chennai", false);

            //u4.getDetails();
            //result = u4.checkLogin();
            //Console.WriteLine(result);
            //MathOperation m1;
            //Console.WriteLine("Enter the Numberv1 : ");
            //int num1 =int.Parse( Console.ReadLine());
            //Console.WriteLine("Enter the Number 2 : ");
            //int num2 = int.Parse(Console.ReadLine());

            //m1=new MathOperation(num1,num2);
            //m1.displaymath();


            //User u1;
            //for (int i=0;i<3;i++)
            //{
            //    Console.WriteLine("Enter the user name : ");
            //    string uname=Console.ReadLine();
            //    Console.WriteLine("Enter the password : ");
            //    string upass=Console.ReadLine();
            //    u1 = new User(uname, upass);
            //    string result=u1.checkLogin();
            //    Console.WriteLine(result);

            //}
            //    Age a = new Age(1990);
            //    a.getAge();

            //Console.WriteLine("Hello, World!");
            //Student s1, s2;
            //s1= new Student();
            //s2= new Student();
            //Student.collegename = "Sairam";
            //s1.studentid = 1;
            //s1.studentname = "Ikfan";
            //s1.marks = 80;

            //s2.studentid = 2;
            //s2.studentname = "Mohamed";
            //s2.marks = 90;


            //Console.WriteLine("Student Id :"+ s1.studentid);
            //Console.WriteLine("Student Name :" + s1.studentname);
            //Console.WriteLine("Student Marks :" + s1.marks);
            //Console.WriteLine("College Name :" + Student.collegename);
            //Console.WriteLine("**************************************************************");
            //Console.WriteLine("Student Id :" + s2.studentid);
            //Console.WriteLine("Student Name :" + s2.studentname);
            //Console.WriteLine("Student Marks :" + s2.marks);
            //Console.WriteLine("College Name :" + Student.collegename);


            //    employee e1;

            //    e1=new employee();
            //    employee.CompanyName = "ChangePond Technologies";
            //    e1.empname = "Mohamed Ikfan";
            //    e1.Age = 25;
            //    e1.Salary = 79999;



            //    Console.WriteLine("Employee Name :"+ e1.empname);
            //    Console.WriteLine("Employee Age : "+ e1.Age);
            //    Console.WriteLine("Employee Salary : "+ e1.Salary);
            //    Console.WriteLine("Company Name : " + employee.CompanyName);

            //}
        }
    }
}