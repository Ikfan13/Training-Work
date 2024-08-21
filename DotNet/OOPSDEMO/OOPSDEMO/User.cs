using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDEMO
{
    class User
    {
        private string username;
        private string password;
        private string message;
        private string address;
        private bool isMarried = false;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User(string username, string password, string message)
        {
            this.username = username;
            this.password = password;
            this.message = message;
        }

        public User(string username, string password, string message, string address)
        {
            this.username = username;
            this.password = password;
            this.message = message;
            this.address = address;

        }

        public User(string username, string password, string message, string address, bool isMarried)
        {
            this.username = username;
            this.password = password;
            this.message = message;
            this.address = address;
            this.isMarried = isMarried;

        }

        public string getMessage()
        {
            return this.message;
        }

        public void getDetails()
        {
            Console.WriteLine("User Name : " + username);
            Console.WriteLine("Password : " + password);
            if (this.address != null)
            {
                Console.WriteLine("Address : " + this.address);
            }
            Console.WriteLine("Is Married : " + this.isMarried);
        }

        public string checkLogin()
        {
            if (this.username == "Admin" && this.password == "Manager")
            {
                if (this.message == null)
                {
                    this.message = "you are logged in as a Admin";
                }
            }
            else if (this.username.StartsWith("User") && this.password == "Pass123")
            {
                if (this.message == null)
                {
                    this.message = "you are logged in as a User";
                }
            }
            else
            {
                if (this.message == null)
                {
                    this.message = "Invalid";
                }
            }
            return this.message;
        }
    }

    //class Demo
    //{
    //    private static void Main(string[] args)
    //    {
    //        User u1, u2, u3, u4;

    //        Console.WriteLine("Enter the user name : ");
    //        string uname = Console.ReadLine();
    //        Console.WriteLine("Enter the password : ");
    //        string upass = Console.ReadLine();
    //        u1 = new User(uname, upass);
    //        string result = u1.checkLogin();
    //        Console.WriteLine(result);
    //        u2 = new User("Sandhya", "Nirmal Raj", "Guest User");
    //        u2.getDetails();
    //        result = u2.checkLogin();
    //        Console.WriteLine(result);

    //        u3 = new User("Ikfan", "ik", "Guest User", "Chennai");
    //        u3.getDetails();
    //        result = u3.checkLogin();
    //        Console.WriteLine(result);

    //        u4 = new User("Nirmal", "Raj", "I am Joker", "chennai", false);

    //        u4.getDetails();
    //        result = u4.checkLogin();
    //        Console.WriteLine(result);
    //    }
    //}
}