namespace InterfaceDemo
{



    class Program
    {
        private static void Main(string[] args)
        {
            Company c=new Company();
            c.Name = "Changepond Technologies";
            c.addressline1 = "XXXXXXX";
            c.addressline2 = "YYYYYYYY";
            c.city = "Chennai";
            c.state = "TamilNadu";
            c.postcode = 600073;
            c.country = "India";
            c.getAddressDetails();

        }
    }
}