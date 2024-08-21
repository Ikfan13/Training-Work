
namespace IProductDemo { 
interface IProduct
 {
        public string product_name { get; set; }
        public int product_price { get; set;}
        public string product_category { get; set; }

        void getProductDetails();



 }
}
