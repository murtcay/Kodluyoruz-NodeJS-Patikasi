using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment
            int y = 12;
            Console.WriteLine(y);

            // Compound Assignment
            int x = 1;
            x += 3;
            Console.WriteLine(x);
            x *= 3;
            Console.WriteLine(x);
            x -= 3;
            Console.WriteLine(x);
            x /= 3;
            Console.WriteLine(x);

            // Logical Operators: ||, &&, !
            bool t = true;
            bool f = false;
            Console.WriteLine((t&&f));
            Console.WriteLine((t||f));
            Console.WriteLine((!t) +" " + (!f));

            // Comparison opertors: <, >, <=, >=, ==, !=
            int num1 = 1;
            int num2 = 2;
            Console.WriteLine(num1 + " < " + num2 + " : " + (num1 < num2));
            Console.WriteLine(num1 + " <= " + num2 + " : " + (num1 <= num2));
            Console.WriteLine(num1 + " > " + num2 + " : " + (num1 > num2));
            Console.WriteLine(num1 + " >= " + num2 + " : " + (num1 >= num2));
            Console.WriteLine(num1 + " == " + num2 + " : " + (num1 == num2));
            Console.WriteLine(num1 + " != " + num2 + " : " + (num1 != num2));

            // Arithmetic operators: +, -, /, *, %
            Console.WriteLine(num1 + " + " + num2 + " : " + (num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " : " + (num1 - num2));
            Console.WriteLine(num1 + " / " + num2 + " : " + (num1 / num2));
            Console.WriteLine(num1 + " * " + num2 + " : " + (num1 * num2));
            Console.WriteLine(num1 + " % " + num2 + " : " + (num1 % num2));
            int num3 = ++num1;
            Console.WriteLine("prefix increment, num1: " + num1 + ", num3:" + num3);
            num3 = num1++;
            Console.WriteLine("postfix increment, num1: " + num1 + ", num3:" + num3);

            num3 = --num1;
            Console.WriteLine("prefix decrement, num1: " + num1 + ", num3:" + num3);
            num3 = num1--;
            Console.WriteLine("postfix decrement, num1: " + num1 + ", num3:" + num3);

        }
    }
}
