namespace IProductDemo
{

    class Program
    {
        private static void Main(string[] args)
        {
           Shop s = new Shop();
            s.Shop_name = "Ikfan Mobiles";
            s.product_name = "IQ Neo 9 pro";
            s.product_price = 32000;
            s.Outlet_name = "Haran Distributors";
            s.Outlet_city = "Chennai";
            s.Outlet_location = "Australia";
            s.shopname();
            s.getProductDetails();  
            s.getOutletDetails();   



        }
    }
}