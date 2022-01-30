using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number to check its Square root");
                var input = int.Parse(Console.ReadLine());
                var answer = Math.Sqrt(input);
                Console.WriteLine(answer);
                if (input < 0)
                {
                    throw new InvalidInputException("Invalid Input");
                }
               
            }
            catch(InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
            Console.ReadKey();
        }
    }
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message):base(message)
        {
        }
    }
}
