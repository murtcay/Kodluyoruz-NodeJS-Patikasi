using System;

namespace type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion: There is no need to Conver tor parse
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int i = a + b + c;
            Console.WriteLine("i: " + i);
            long l = i;
            Console.WriteLine("l: " + l);
            float f = l;
            Console.WriteLine("f: " + f);
            string s = "number";
            char ch = 'c';
            object obj = s + ch + f;
            Console.WriteLine("obj: " + obj);

            // Explicit Conversion: Needs to Convert or parse or ToString

            int x = 100;
            float y = 10.3f;
            Console.WriteLine("(byte)x: " + (byte)x);
            Console.WriteLine("(byte)y: " + (byte)y);
            Console.WriteLine("x.ToString(): " + x.ToString());
            Console.WriteLine("10.3f.ToString(): " + 10.3f.ToString());
            Console.WriteLine("Convert.ToInt32('12'): " + Convert.ToInt32("12"));
            Console.WriteLine("Int32.Parse('12'): " + Int32.Parse("12"));
            Console.WriteLine("Double.Parse('12.34'): " + Double.Parse("12.34"));
        }
    }
}
