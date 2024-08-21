//public delegate void calloutmyname(string username);
//class publisher
//{
//    public event calloutmyname callname;
//    public void raiseEvent(string username)
//    {
//        callname(username);
//    }
//}
//class subcriberDemo
//{
//    public void subcribedcallname(string username)
//    {
//        Console.WriteLine("Good Morning : " + username);
//    }
//    public void connect()
//    {
//        publisher p = new publisher();
//        p.callname += subcribedcallname;
//        p.raiseEvent("Nirmal Raj");
//        p.raiseEvent("Sandhya");
//    }
//}

//class DelegateDemo
//{
//    public void Add(int a, int b)
//    {
//        int c = a + b;
//        Console.WriteLine("Addition of: " + a + "+" + b + " is " + c);
//    }

//    public void Sub(int a, int b)
//    {
//        int c = a - b;
//        Console.WriteLine("Subtraction of: " + a + "-" + b + " is " + c);
//    }

//    public void Mul(int a, int b)
//    {
//        int c = a * b;
//        Console.WriteLine("Multiplication of: " + a + "*" + b + " is " + c);
//    }

//    public void Div(int a, int b)
//    {
//        int c = a / b;
//        Console.WriteLine("Division of: " + a + "/" + b + " is " + c);
//    }
//}
//public delegate void numberoperations(int a, int b);


//class Program
//{
//    private static void Main(string[] args)
//    {
//        subcriberDemo sc = new subcriberDemo();
//        sc.connect();
//        //numberoperations no;
//        //DelegateDemo dd = new DelegateDemo();
//        //no = dd.Add;
//        //no += dd.Sub;
//        //no += dd.Mul;
//        //no += dd.Div;
//        //no(20, 30);
//    }
//}
using System.Diagnostics.Tracing;
using System.Security.Cryptography;public delegate void incrementDelegate(int x, int y);class PublisherDemo{    public event incrementDelegate incrementevent;    public int x = 0, y = 10;    public void increment()    {        x += 5;        y += 10;        incrementevent(x, y);    }}class SubscriberDemo{    public void doIncrement()    {        PublisherDemo demo = new PublisherDemo();        demo.incrementevent += (a, b) =>        {            int c = a + b;            Console.WriteLine("result after ato increment " + c);        };        demo.increment();

    }}internal class Program{    private static void Main(string[] args)    {        SubscriberDemo sd = new SubscriberDemo();        sd.doIncrement();        var numbers = new int[] { 2, 3, 5, 7, 9, 5 };        var count = numbers.Count(x => x == 5);        Console.WriteLine(count);        List<int> numbers1 = new List<int> { 2, 7, 5, 8, 1, 6, 5, 8, 9, 1 };        int count1 = numbers1.Count(x => x == 5);        Console.WriteLine(count1);    }}