internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> empdetails;
        empdetails = new Dictionary<int, string>();
        empdetails.Add(100, "Parag");
        empdetails.Add(102, "Prachi");
        empdetails.Add(103, "Manas");

        string ename = empdetails[102];
        Console.WriteLine(ename);

        SortedList<string, int> Marks;
        Marks = new SortedList<string, int>();
        Marks.Add("Maths", 80);
        Marks.Add("Physics", 90);
        Marks.Add("English", 65);
        Marks.Add("Chemistry", 75);

        foreach (string key in Marks.Keys)
        {
            Console.WriteLine(Marks[key]);
        }



        if (Marks.TryGetValue("Maths", out int value))
        {
            Console.WriteLine(value); // Outputs 
        }

        //Product p1, p2, p3;
        //p1 = new Product() { Id = 1, Name = "shirts", Price = 250 };
        //p2 = new Product() { Id = 2, Name = "Trousers", Price = 300 };
        //p3 = new Product() { Id = 3, Name = "T-Shirts", Price = 450 };

        //List<Product> cartlist = new List<Product>();
        //List<Product> products = new List<Product>() { p1, p2, p3 };
        //for (int i = 0; i < products.Count; i++)
        //{
        //    Product product = products[i];
        //    if (product.Price >= 300)
        //    {
        //        cartlist.Add(product);
        //    }

        //}
        //for (int i = 0; i < cartlist.Count; i++)
        //{
        //    Product product = cartlist[i];
        //    Console.WriteLine(product.Name + " " + product.Price);
    }
    //    List<int> ints = new List<int> { 10, 20, 33, 40, 55 };
    //    List<int> evenlist = new List<int>();

    //    evenlist = (from item in ints where (item % 2 == 0) select item).ToList();

    //    foreach (int i in evenlist)
    //    {
    //        Console.WriteLine(i);
    //    }
    //List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese" };
    //List<string> isavail = new List<string>();
    //Console.WriteLine("Enter the Product :");
    //string product = Console.ReadLine();
    //isavail = (from pro in products where (pro == product) select pro).ToList();
    //string Value = isavail.Count==0 ? "Product Does Not Exists" : "Product Exists";
    //Console.WriteLine(Value);


}


