using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            string variable = " ";
            byte b = 5;     // 0 to 255, 1 byte
            sbyte c = 5;    // -128 to 127, 1byte
            short s = 5;    // 2 bytes, signed
            ushort us = 5;  // 2bytes, unsigned

            int i = 2;      // 4 bytes
            Int16 i16 = 2;  // 2 bytes
            Int32 i32 = 2;  // 4 bytes
            Int64 i64 = 2;  // 8 bytes

            uint ui = 2;    // 4 bytes
            long l = 4;     // 8 bytes
            ulong ul = 4;   // 8 bytes
            
            float f = 5;    // 4 bytes, real numbers
            double d = 5;   // 8 bytes, real numbers

            decimal de = 5; // 16 bytes, real numbers

            char ch = 'a';              // 2 bytes
            string str = "string_s";    // 

            bool bf = false;
            bool bt = true;

            DateTime dt = DateTime.Now;

            object obj_string = "x";
            object obj_char = 'c';
            object obj_int = 12;
            object obj_real = 4.3;

            string name = string.Empty;
            name = "John";
            string lastname = string.Empty;
            lastname = "Doe";
            string fullName = name + " " + lastname; 

            int num1 = 3;
            int num2 = 5;
            int mul = num1 * num2;

            bool tf = 1<0;

            // Type Casting 
            string str20 = "20";
            int int20 = 20;
            string str2020 = str20 + int20.ToString();

            int int40 = int20 + Convert.ToInt32(str20);

            int int400 = int20 * int.Parse(str20);

            string datetime_ps = DateTime.Now.ToString("dd.MM.yyyy");
            string datetime_ss = DateTime.Now.ToString("dd/MM/yyyy");
            string datetime_time = DateTime.Now.ToString("HH:mm:ss");

            string hour = DateTime.Now.ToString("HH");
            string minutes = DateTime.Now.ToString("mm");
            string seconds = DateTime.Now.ToString("ss");

            Console.WriteLine(variable);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(s);
            Console.WriteLine(us);
            Console.WriteLine(i);
            Console.WriteLine(i16);
            Console.WriteLine(i32);
            Console.WriteLine(i64);
            Console.WriteLine(ui);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(de);
            Console.WriteLine(ch);
            Console.WriteLine(str);
            Console.WriteLine(bf);
            Console.WriteLine(bt);
            Console.WriteLine(dt);
            Console.WriteLine(obj_string);
            Console.WriteLine(obj_char);
            Console.WriteLine(obj_int);
            Console.WriteLine(obj_real);
            Console.WriteLine(name);
            Console.WriteLine(lastname);
            Console.WriteLine(fullName);
            Console.WriteLine(mul);
            Console.WriteLine(tf);
            Console.WriteLine(str2020);
            Console.WriteLine(int40);
            Console.WriteLine(int400);
            Console.WriteLine(datetime_ps);
            Console.WriteLine(datetime_ss);
            Console.WriteLine(datetime_time);
            Console.WriteLine(hour);
            Console.WriteLine(minutes);
            Console.WriteLine(seconds);
        }
    }
}
