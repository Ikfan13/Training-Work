
namespace OopsAdvanceDemo
{

    class Program
    {
        private static void Main(string[] args)
        {



            BMW b=new BMW();
            b.brand = "BMW";
            b.model = "5-Series";
            b.specialfeatures = "Massage Seats";
            Console.WriteLine( b.getCarDetails());


            Mercedez m=new Mercedez();
            m.brand = "Mercedez-Benz";
            m.model = "CLE Coupe";
            m.mileage = "15 Km";
            Console.WriteLine(m.getCarDetails());
            //Console.WriteLine("Hello, World!");
            //Person p = new Person("Mohamed", "Ikfan M ", "Male");
            //p.FirstName = "Mohamed";
            //p.LastName = "Ikfan M ";
            //p.Gender = "Male";

            ////Console.WriteLine("Name : "+ p.FirstName+" "+p.LastName);
            ////Console.WriteLine("Gender : " +p.Gender);


            //Console.WriteLine("*******************************STUDENT************************");

            //Student s = new Student("Mohamed", "Ikfan", "Male",45,98);
            ////s.FirstName = "Mohamed";
            ////s.LastName = "Ikfan";
            ////s.Gender = "Male";
            ////s.sid = 45;
            ////s.marks = 98;

            ////Console.WriteLine("Name : " + s.FirstName + " " + s.LastName);
            ////Console.WriteLine("Gender : " + s.Gender);
            ////Console.WriteLine("Student Id : " + s.sid);
            ////Console.WriteLine("Marks : " + s.marks);
            //s.DisplayStudentDetails();

            //Console.WriteLine("*******************************Employee************************");

            //Employee e = new Employee("Mohamed", "Ikfan", "Male",11,79999);
            ////e.FirstName = "Mohamed";
            ////e.LastName = "Ikfan";
            ////e.Gender = "Male";
            ////e.empid = 11;
            ////e.Salary = 79999;


            ////Console.WriteLine("Name : " + e.FirstName + " " + e.LastName);
            ////Console.WriteLine("Gender : " + e.Gender);
            ////Console.WriteLine("Employee Id : " + e.empid);
            ////Console.WriteLine("Salary : " + e.Salary);

            //e.DisplayEmployeeDetails();
        }
    }

}