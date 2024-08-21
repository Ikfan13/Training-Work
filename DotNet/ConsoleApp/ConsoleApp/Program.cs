using Microsoft.VisualBasic;


























internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();
        //Console.Clear();
        //Console.WriteLine("Welcome to the DotNet");
        //Console.ReadKey();


        //sbyte a = 10;
        //byte b = 20;
        //short c = 30;
        //ushort d = 40;
        //int e=50;
        //uint f=60;
        //long g=70;
        //ulong h=80;
        //float i=9.4f;
        //double j=60.755875;
        //decimal k=66.8M;


        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
        //Console.WriteLine(d);
        //Console.WriteLine(e);
        //Console.WriteLine(f);
        //Console.WriteLine(g);
        //Console.WriteLine(h);
        //Console.WriteLine(i);
        //Console.WriteLine(j);
        //Console.WriteLine(k);


        //int min = int.MinValue;
        //int max = int.MaxValue;

        //Console.WriteLine(min);
        //Console.WriteLine(max);

        //char ch = 'A';
        //Console.WriteLine(ch);

        //string str = "Hello 1234@";
        //Console.WriteLine(str);

        //bool isAdult = true;
        //Console.WriteLine(isAdult);




        //double num1 = 10, num2 = 20;
        //Console.WriteLine(num1 + num2);
        //Console.WriteLine(num1 - num2);
        //Console.WriteLine(num1 * num2);
        //Console.WriteLine(num1 / num2);
        //Console.WriteLine(num1 % num2);

        //Console.WriteLine(num1 += num2);
        //Console.WriteLine(num1 -= num2);
        //Console.WriteLine(num1 *= num2);
        //Console.WriteLine(num1 /= num2);
        //Console.WriteLine(num1 %= num2);

        //int x = 10, y = 20, z = 10;
        //bool result1 = ((x==y) && (x==z));
        //Console.WriteLine(result1);
        //bool result2 = ((x == y) || (x == z));
        //Console.WriteLine(result2);
        //bool result3 = !result1;
        //Console.WriteLine(result3);

        //int n = 21;

        //if(n%2==0)
        //{
        //    Console.WriteLine("Even");
        //}
        //else
        //{
        //    Console.WriteLine("odd");
        //}

        //int year = 2025;
        //if ((year % 400 == 0) || ((year % 4 == 0 && year % 100 != 0)))
        //{
        //    Console.WriteLine(year + "  is leap year");
        //}
        //else
        //{
        //    Console.WriteLine(year + "  is not leap year");
        //}

        //int marks = 76;
        //if (marks >= 75)
        //{
        //    Console.WriteLine("Distinction");
        //}
        //else if (marks >= 60 && marks < 75)
        //{
        //    Console.WriteLine("First Class");
        //}
        //else if (marks >= 50 && marks < 60)
        //{
        //    Console.WriteLine("Second Class");
        //}
        //else if (marks >= 35 && marks < 50)
        //{
        //    Console.WriteLine("Third Class");
        //}
        //else
        //{
        //    Console.WriteLine("Fail");
        //}

        //int num1 = 20, num2 = 40, num3 = 50;
        //if (num1>num2 && num1>num3)
        //{
        //    Console.WriteLine(num1 + " is greater");
        //}
        //else if (num2 > num1 && num2 > num3)
        //{
        //    Console.WriteLine(num2 + " is greater");
        //}
        //else
        //{
        //    Console.WriteLine(num3 + " is greater");
        //}




        // int monthno = 7;
        // string monthname="";

        // switch (monthno)
        // {
        //     case 1:  monthname = "January "; break;
        //     case 2:  monthname = "Febraury"; break;
        //     case 3:  monthname = "March"; break;
        //     case 4:  monthname = "April"; break;
        //     case 5:  monthname = "May"; break;
        //     case 6:  monthname = "June"; break;
        //     case 7:  monthname = "July"; break;
        //     case 8:  monthname = "August"; break;
        //     case 9:  monthname = "September"; break;
        //     case 10: monthname = "October"; break;
        //     case 11: monthname = "November"; break;
        //     case 12: monthname = "December"; break;
        //     default: Console.WriteLine("Entered the Wrong Number"); break;
        // }
        //Console.WriteLine(monthname);
        //int num = 5;
        //int fact = 1;
        //while (num>1)
        //{
        //    fact *= num;
        //    num--;
        //}
        //Console.WriteLine("factorial of 5 is : " + fact);


        //int i = 1;
        //int sumofodds = 0;
        //do
        //{
        //    if (i % 2 != 0)
        //    {
        //        sumofodds += i;
        //    }
        //    i++;
        //} while (i < 100);

        //Console.WriteLine(sumofodds);



        //    int sum = 0;
        //    for(int i = 0; i < 100; i++)
        //    {
        //        if(i%10==0)
        //        {
        //            sum += i;
        //        }
        //    }
        //    Console.WriteLine(sum);


        //    int num1 = 6;
        //    int fact = 1;
        //    for(int i=num1;i>1;i--)

        //    {
        //        fact *= i;

        //    }
        //    Console.WriteLine(fact);

        //int num = 64351;
        //int sum = 0;
        //while (num > 0)
        //{
        //    int num1 = num % 10;
        //    num = num / 10;

        //    sum += num1;
        //}
        //Console.WriteLine("Sum of digits: " + sum);




        int num = 10;
      
        int flag= 0;

        if (num==1)
            {
            Console.WriteLine("1 is neither prime or nor");
        }
        for (int i = 2;i<num/2;i++)
        {
            if(num%2 !=0)
            {
                flag =1;
            }
        }

        if (flag == 1){
            Console.WriteLine(num + " is a prime number");
        }
        else
        {
            Console.WriteLine(num + " is not a prime number");
        }












    }
}