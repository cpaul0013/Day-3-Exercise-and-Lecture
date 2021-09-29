using System;
using System.Text;

namespace Day_3_Exercise
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Please enter a number 1- 10");
            int userInput = int.Parse(Console.ReadLine());
            long result = Factorial(userInput);
            Console.WriteLine(result);
            stringSection();
            exercise();

        }
        // everything related to strings
        public static void stringSection()
        {
            string x = "ABC";
            string y = "ABC";
            if (x == y)
            {
                Console.WriteLine($"{x} is equal to {y} using ==.");
            }
            else
            {
                Console.WriteLine($"{x} is not equal to {y} using ==.");
            }
            if (string.Compare(x, y) == 0)
            {
                Console.WriteLine($"{x} and {y} are comparable.");
            }
            else
            {
                Console.WriteLine($"{x} and {y} are not comparable.");
            }

            if (x.Equals(y))
            {
                Console.WriteLine($"{x} equals {y} using equals method.");
            }

            else
            {
                Console.WriteLine($"{x} deos not equal {y} using equal method.");
            }
            Console.WriteLine($"{x} the letter b is in spot {x.IndexOf("b")}");
            string z = "abcabcabc";

            Console.WriteLine($"{z} the last letter of b appears in spot {z.LastIndexOf("b")}");

            Console.WriteLine($"{z} Does this end in a d? {z.EndsWith("d")}");

            string newZ = z.Replace("a", "j");

            Console.WriteLine($"{newZ}");

            string sentence = "Welcome to my class";
            string[] words = sentence.Split(" ");
            foreach (string w in words)
            {
                Console.WriteLine(w);

            }
            Console.WriteLine($"{sentence.Substring(8)}");

            Console.WriteLine($"{sentence.ToUpper()}");

            Console.WriteLine($"{sentence.ToLower()}");

            string messyString = "                                  dude";

            Console.WriteLine($"{messyString}");
            Console.WriteLine($"{messyString.Trim()}");

            //string builder example

            StringBuilder sb = new StringBuilder("Test!");
            sb.Append("\t Super!");
            Console.WriteLine(sb);
        }
        public static long Factorial(int loops)
        {
            long total = 1;
            for (int i = 1; i <= loops; i++)
            {

                total *= i;


            }
            return total;



        }

        public static int getRandomNumber()
        {
            Random ran = new Random();
            int number = ran.Next(10) + 1;
            return number;

        }

        public static void exercise()
        { Random ran = new Random();
            int number = ran.Next(100) + 1;
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }





        }







    }
    }
    

