using System;
using System.Collections.Generic;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number lesser than 100 for starting the range: ");
                var firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number lesser than 100 for ending the numbers: ");
                var secondNumber = int.Parse(Console.ReadLine());
                ReadNumber(firstNumber, secondNumber);
            }
            catch (LesserThanStartException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (BiggerThanEndException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AscendingOderingException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (BiggerThan100Exception e)
            {
                Console.WriteLine(e.Message);
            }
            catch   (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            
        }
        public static void ReadNumber(int start, int end)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Input a number within the range: ");
                var input = int.Parse(Console.ReadLine());
                if (input <= start)
                {
                    throw new LesserThanStartException("The number is lesser than or exactly the specified starting number");
                }
                else if (input >= end)
                {
                    throw new BiggerThanEndException("The number is greater than or exactly the specified ending number");
                }
                else if (input >= count)
                {
                    throw new AscendingOderingException("Inputs should be in Ascendimg order");
                }
                else if (input > 100)
                {
                    throw new BiggerThan100Exception("The number ig greater than 100");
                }
                
                count = input;
            }
        }
    }
    public class LesserThanStartException : Exception
    {
        public LesserThanStartException(string message) : base(message)
        {
        }
    }
    public class BiggerThanEndException : Exception
    {
        public BiggerThanEndException(string message) : base(message)
        {
        }
    }
    public class BiggerThan100Exception : Exception
    {
        public BiggerThan100Exception(string message) : base(message)
        {
        }
    }
    public class AscendingOderingException : Exception
    {
        public AscendingOderingException(string message) : base(message)
        {
        }
    }
}
