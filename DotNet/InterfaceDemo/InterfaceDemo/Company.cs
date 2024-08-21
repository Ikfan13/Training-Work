using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Company : IAddress, IContact
    {
        public string Name { get; set; }
        public string addressline1 { get ; set ; }
        public string addressline2 { get ; set ; }
        public string city { get ; set ; }
        public string state { get ; set ; }
        public int postcode { get ; set ; }
        public string country { get ; set ; }
        public string Email { get ; set ; }
        public int ContactNo { get ; set ; }


        public void getAddressDetails()
        {
            Console.WriteLine("CompanyName:" + this.Name);
            Console.WriteLine(this.addressline1+" "+this.addressline2 + " "+this.city+" "+this.state+" " +this.postcode + " " +this.country);
        }

        public void getContactDetails()
        {
            Console.WriteLine("Email : " + this.Email);
            Console.WriteLine("Contact No :" + this.ContactNo);
        }



    }
}
