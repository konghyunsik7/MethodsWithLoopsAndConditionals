using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals

{
    internal class MainMethods
    {
        public static void Methods1()
        {
            //for (int i =-1000 ; i >=-1000 && i <= 1000; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            int x = 1000;
            while (x >= -1000)
            {
                Console.WriteLine(x);
                x--;
            }
        }
        public static void Methods2()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        public static void Methods3(int a,int b)
        {
            string answer = a == b ? "Its a match" : "Does NOT match";
            Console.WriteLine(answer);
            //Console.WriteLine( (a == b) ? "Its a match" : "Does NOT match" );
            //    if (a == b)
            //    {
            //        Console.WriteLine("Its a match");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Does NOT match");
            //    }
        }
        public static void Methods4()
        {
            Console.Write("Enter a Number : ");
            int c = int.Parse(Console.ReadLine());
            if (c % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
            }
            
        }
        public static void Methods5()
        {
            Console.WriteLine("Enter a number: ");
            int d = int.Parse(Console.ReadLine());
            if (d <= -1)
            {
                Console.WriteLine("The number is negative");
            }
            else if (d == 0)
            {
                Console.WriteLine("It's neither! ZERO is nothing and everything at the sametime");
            }
            else
            {
                Console.WriteLine("The number is positive");
            }
        }
        public static void Methods6()
        {
            int age = 0;
            bool ageVerify;

            do
            {
                Console.WriteLine("Enter your age: ");
                ageVerify = int.TryParse(Console.ReadLine(), out age);

                if (age < 0)
                {
                    ageVerify = false;
                }
            }while (!ageVerify);
         if(age < 18)
            {
                Console.WriteLine("You are too young");
            }
            else
            {
                Console.WriteLine("You can vote!");
            }
            
        }
        public static void Methods7()
        {
        Console.WriteLine("Pick a number");
        int x = int.Parse(Console.ReadLine());
            if (x > -10 && x < 10)
            {
            
                Console.WriteLine("You are correct");
            }
            else { Console.WriteLine("You are wrong"); }
        
        }
        public static void Methods8()
        {
            Console.WriteLine("Please picka number: ");
            int x = int.Parse(Console.ReadLine());

            for (int y = 1; y <= 12; y++)
            {
                Console.WriteLine($"{y}*{x}={y*x}");
            }

        }

    }
}
