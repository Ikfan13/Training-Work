using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDEMO
{
    class MathOperation
    {

        private int num1, num2;

        public MathOperation(int num1, int num2)
        {
            this.num1 = num1; 
            this.num2=num2;
        }

        private int add()
        {
            return num1 + num2;
        }
        private int sub()
        {
            return num1 - num2;
        }
        private int mul()
        {
            return num1 * num2;
        }
        private int div()
        {
            return num1 / num2;
        }

        public void displaymath()
        {
            Console.WriteLine("Add : " + add());
            Console.WriteLine("Sub : " + sub());
            Console.WriteLine("Mul : " + mul());
            Console.WriteLine("Div : " + div());
        }
    }
}
