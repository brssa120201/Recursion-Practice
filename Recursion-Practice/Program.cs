using System;

namespace Recursion_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sm = SumNumbers(5);
            Console.WriteLine("The numbers sum: " + sm);
            
            int sd = SumDigits(25);
            Console.WriteLine("The digits sum: " + sd);

            //Number Prime
            Console.WriteLine(PrimeNumber(7));

            //Spiderman jump
            Console.WriteLine("There are: " + PossibleWay(3) + " possible paths");
        }

        //1. Write a program in C# to calculate the sum of numbers from 1 to n using recursion. Go to the editor
        //Test Data : Input the last number of the range starting from 1 : 5 
        //Expected Output : The sum of numbers from 1 to 5 : 15
        public static int SumNumbers(int n)
        {
            int number = 0;
            if(n > 1)
            {
                number = n + SumNumbers(n - 1);
            }
            if (n == 1)
            {
                number = n;
            }
            return number;
        }

        //2. Write a program in C# to find the sum of digits of a number using recursion. Go to the editor
        //Test Data : Input any number to find sum of digits: 25 
        //Expected Output : The Sum of digits of 25 = 7 
        public static int SumDigits(int d)
        {
            int rec = 0;
            int recur = 0;
            if (d / 10 == 0)
            {
                rec = d;
            }
            if(d % 10 != 0)
            {
                recur = d % 10;
                rec = recur + SumDigits(d / 10);
            }
            return rec;
        }

        //3. Write a program in C to check a number is a prime number or not using recursion. Go to the editor
        //Test Data : Input any positive number : 7 
        //Expected Output : The number 7 is a prime number.
        static Boolean primeNumber(int number, int count)
        {
            if(count == 1)
            {
                return true;
            }
            if(number % count == 0)
            {
                return false;
            }
            count = count - 1;
            return primeNumber(number, count);
        }
        public static string PrimeNumber(int p)
        {
            Boolean prime = primeNumber(p, p / 2);

            string message = "";
            if(prime == true)
            {
                message = "The number " +p+ " is prime";
            }
            if (prime == false)
            {
                message = "The number " + p + "is not prime";
            }
            return message;
        }

        //4. Spiderman is capable to jump one or two buildings
        //	0	    |	|	|	|
        //Spiderman b1  b2  b3  b4
        //Spider could jump to b1, or b2. Once Spiderman has jumped to the b2, he could jump to the b3 or b4 buildings. 
        //Spiderman is always able to jump 1 or 2 buildings. How many ways has Spiderman to go up n buildings.
        //(e.g.)  input n = 3
        //0				|	|	|
        //Spiderman		b1	b2	b3
        //output: way 1 (b1, b3)    way 2 (b1, b2, b3)      way 3 (b2, b3)
        //Answer: 3 ways.
        static int PossibleWay(int buildings)
        {
            if(buildings >= 2)
            {
                return PossibleWay(buildings - 1) + PossibleWay(buildings - 2);
            }
            if(buildings == 1)
            {
                return PossibleWay(buildings - 1);
            }
            return 1;
        }
    }
}
