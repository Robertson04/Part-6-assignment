using System;

namespace Part_6_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cameron
            Prompter(); 
            PercentPassing();
            RandomNumbers();
            OddSum();




        }
        public static void Prompter()
        {
        Double min;
        Double max;
        Double num;
        Console.WriteLine("Please enter a minimum number");
            while (!Double.TryParse(Console.ReadLine(), out min))
                Console.WriteLine("Please enter a valid input");
            Console.WriteLine("Please enter a maximum number");
            do
            {
                while (!Double.TryParse(Console.ReadLine(), out max))
                    Console.WriteLine("Please enter a valid input");
                if (max<=min)
                    Console.WriteLine("Please enter a valid number");
            } while (max<=min);
            do
            {
                Console.WriteLine($"Please enter a number betwen the {min} and {max}");
                while (!Double.TryParse(Console.ReadLine(), out num))
                    Console.WriteLine("Please enter a valid input");
                if (num<max && num> min)
                    Console.WriteLine("That is a great number");
                else
                    Console.WriteLine("The number you enterd is not betwen your minamum and maxamum numbers");
            } while (num<=min || num>=max);           
            }
        public static void PercentPassing()
        {
            double scores;
            double up = 0;
            double total = 0;
            string done;
            do
            {
                Console.WriteLine("Please enter a test score");
                while (!Double.TryParse(Console.ReadLine(), out scores))
                    Console.WriteLine("Please enter a valid input");
                if (scores >= 70 && scores < 101)
                    up = up + 1;
                if (scores >= 70 && scores < 101)
                    total = total + 1;
                else if (scores >= 0 && scores <= 69)
                    total = total + 1;
                if (scores >= 101 && scores != 200)
                    Console.WriteLine("Please enter a proper score");
                else if (scores < 0)
                    Console.WriteLine("Please enter a proper score");
                Console.WriteLine("Enter z if you are done entering scores");
                Console.WriteLine("Prese enter to enter your next score");
                done = Console.ReadLine();
            } while (done != "z");
            if (done == "z")
                Console.WriteLine($"A total of {up / total * 100}% of your marks are above 70%");
        }
        public static void RandomNumbers()
        {
            Random generator = new Random();
            int num1;
            int num2;
            int i = 0;
            do
            {
                Console.WriteLine("Please enter two number that are over 50 numbers apart");
                while (!Int32.TryParse(Console.ReadLine(), out num1))
                    Console.WriteLine("Please enter a valid input");
                Console.WriteLine("Please enter one more number");
                while (!Int32.TryParse(Console.ReadLine(), out num2))
                    Console.WriteLine("Please enter a valid input");
            } while (num1 < num2 && num1 + 50 > num2 || num2 < num1 && num2 + 50 > num1);
            Console.WriteLine("Your random numbers are the folowing");
            do
            {
                Console.WriteLine($"{generator.Next(num1, num2 + 1)}");
                i = i + 1;
            } while (i != 25);
        }
        public static void OddSum ()
        {
            int num;
            int total = 0;
            int change = 1;
            do
            {
                Console.WriteLine("Please enter a number");
                while (!Int32.TryParse(Console.ReadLine(), out num))
                    Console.WriteLine("Invalid input");
            } while (num <= 0);
            do
            {
                total = total + change;
                change = change + 2;
            } while (change <= num);
            Console.WriteLine($"the sum of all odd numbers is {total}");
        }
    }
}
