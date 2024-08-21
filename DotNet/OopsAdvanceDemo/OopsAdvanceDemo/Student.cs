namespace OopsAdvanceDemo
{
     class Student : Person
    {
     

        

        public int sid { get; internal set; }
        public int marks { get; internal set; }

        public Student(string FirstName,string LastName,string Gender,int sid,int marks):base(FirstName,LastName,Gender)
        {
            this.sid = sid;
            this.marks = marks;
        }



        public void DisplayStudentDetails()
        {
            //Console.WriteLine("Student FirstName : " + base.FirstName);
            //Console.WriteLine("Student LastName : " + base.LastName);
            //Console.WriteLine("Student Gender : " + base.Gender);
            base.DisplayDetails();
            Console.WriteLine("Student Id : " + sid);
            Console.WriteLine("Student FirstName : " + marks);
        }
    }
}