using System;
using System.IO;
using System.Collections.Generic;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the fullpath of the file to read from: ");
            string file = Console.ReadLine();
            ValidiateFile(file);
        }
        public static void ValidiateFile(string file)
        {
            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file)) 
                {
                    var result = reader.ReadLine();
                    Console.WriteLine(result);
                }
            }
            else if (!File.Exists(file))
            {
                throw new FileNotFoundException();
            }
        }
    }
}
