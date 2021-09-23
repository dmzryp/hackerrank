using System;
using System.Collections.Generic;
using System.IO;


namespace hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            //Day0();
            //Day1();
            //Day2();
            //Day3();
            //Day4();
            //Day5();
            Day6();
           
        }

        static void Day0 (){
             // Declare a variable named 'inputString' to hold our input.
            String inputString;

            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            Console.WriteLine("====Zero====");
            Console.Write("Quote: ");
            inputString = Console.ReadLine(); 
            
            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine("Hello, World.");
            
            // TODO: Write a line of code here that prints the contents of input_string to stdout. 
            //inputString 
            Console.WriteLine(inputString);
        }

        static void Day1(){
             int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int ii;
            double dd;
            String ss;
            // Read and save an integer, double, and String to your variables.
            Console.WriteLine("====One====");
            Console.WriteLine("isi int :");
            ii = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("isi Double :"); 
            dd = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("isi String :");
            ss = Console.ReadLine(); 
            
            // Print the sum of both integer varables on a new line.
            Console.WriteLine(i+ii);
            // Print the sum of the double variables on a new line.
            Console.WriteLine((d+dd));
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s+ss);
            Hewan hewan = new Hewan();
            Console.WriteLine(hewan.nama);
        }

        static void Day2()
        {
            Console.WriteLine("====two====");
            Console.Write("Meal Cost :");
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());
            Console.Write("tip % :");
            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());
            Console.Write("tax % :");
            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            day2Child.solve(meal_cost, tip_percent, tax_percent);
        }
        
        static void Day3()
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            if(N <= 100)
            {
                if (N % 2 == 1 || (N > 5 && N < 21))
                {
                    Console.Write("Weird");
                }
                else
                {
                    Console.Write("Not Weird");
                }
            }
            else
            {
                Console.Write("Weird");
            }
        }

        static void Day4()
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }
        //Loop//
        static void Day5()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{n} x {i} {i * n}");
            }
        }

        static void Day6()
        {
            var T = int.Parse(Console.In.ReadLine());
            for (int L = 0; L < T; L++){
                var S = Convert.ToString(Console.ReadLine().Trim());
                string even = "";
                string odd = "";
                if (!int.TryParse(S, out int value))
                {
                    for (int i = 0; i < S.Length; i++)
                    {
                        string newstring = S.Substring(i, 1);
                        if (i % 2 == 0)
                        {
                            even += newstring;
                        }
                        else
                        {
                            odd += newstring;
                        }
                    }
                    Console.WriteLine($"{even} {odd}");
                }
            }
        }
    }
}
