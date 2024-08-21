namespace IProductDemo
{



interface IOutlet
 {
        public string Outlet_name { get; set; }
        public string Outlet_city { get; set; }

        public string Outlet_location { get; set; }

        void getOutletDetails();

 }
}