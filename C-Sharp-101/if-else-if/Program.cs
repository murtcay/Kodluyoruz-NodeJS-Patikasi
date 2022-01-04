using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;

            if(hour < 6) {
                Console.WriteLine("Good night...");
            }
            else if(hour < 12) {
                Console.WriteLine("Good morning...");
            }
            else if(hour < 16) {
                Console.WriteLine("Good afternoon...");
            }
            else if(hour < 21) {
                Console.WriteLine("Good evening...");
            }
            else {
                Console.WriteLine("Good night...");
            }
            int age = 16;
            string res = (age < 21) ? "You are young." : "You are old.";
            Console.WriteLine("age: " + age +", " +res);


            string msg = hour < 6 ?  "Good night..." : hour < 12 ?  "Good morning..." : hour < 16 ?  "Good afternoon..." : hour < 21 ?  "Good evening..." : "Good night...";

            Console.WriteLine(msg);
        }
    }
}
