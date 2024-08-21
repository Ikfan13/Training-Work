namespace OopsAdvanceDemo
{

   public  class Person
    {
       

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public Person(string Fn,string ln,string gen)
        {
            FirstName = Fn;
            LastName = ln;
            Gender = gen;
        }



        public void DisplayDetails()
        {
            Console.WriteLine("Employee FirstName : " + this.FirstName);
            Console.WriteLine("Employee LastName : " + this.LastName);
            Console.WriteLine("Employee Gender : " + this.Gender);
          
        }
    }
}