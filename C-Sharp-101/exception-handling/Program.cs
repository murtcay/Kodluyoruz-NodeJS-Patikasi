using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Start...");
                Console.Write("Please enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number is: " + num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Finished...");
            }

            try
            {   
                Console.WriteLine("Start...");
                // int i = int.Parse(null);
                // int j = int.Parse("test");
                int k = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("You provided an empty value.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("The value is in wrong format.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The given number is not in the range of int.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finished...");
            }

        }
    }
}
