using System;

namespace CMethodsE1
{
    internal class Program
    {
        //*------------------------excercise 2.1-------------------------*//
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multipler(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        //*--------------------------------------------------------------*//
        static void Main(string[] args)
        {
            //*------------------------excercise 1-------------------------*//
            Console.WriteLine("What's your name?"); //input of 1st question
            String name = Console.ReadLine();

            Console.WriteLine("What's your favorite color?");
            String color = Console.ReadLine();

            Console.WriteLine("What's your favorite animal?");
            String animal = Console.ReadLine();

            Console.WriteLine("Who's your favorite band?");
            String band = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Did you know that one day, the young {name} rode the almost extinct {color} {animal}?\nThey rode all across the country until international sensation {band} showed up!\nThey asked if {name} and the {animal} can go with them on a world tour?\nTrue Story!");
            Console.WriteLine("\nPress enter to continue to the next excercise...");

            Console.ReadLine();//user must enter key to continue. will clear console and enter 2nd excercise
            Console.Clear();

            //*--------------------------------------------------------------*//
            //*------------------------excercise 2.2-------------------------*//
            var SumAmount = Sum(2, 6);
            var MulAmount = Multipler(60, 2, 4);
            Console.WriteLine($"Your sum of 2 and 6 is {SumAmount} {Sum(3,7)}");
            Console.WriteLine($"Your product of 2, 4, and 60 is {MulAmount}");
            //*--------------------------------------------------------------*//
        }
    }
}
