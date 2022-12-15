using System;
using System.ComponentModel;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program 
    {
        
        public static int Multiply(int num1, int num2)
        {
           var result = num1 * num2;
            return result;
        }
        public static int Adding(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }
        
        public static int Dividing(int num1, int num2)
        {
            var result = num1 / num2;
            return result;
        }

        public static int Subtraction(int num1, int num2)
        {
            var result = num1 - num2;
            return result;
        }


        static void  Main(string[] args)
        {
            Console.WriteLine("Please tell me what type of Math problem you would like to solve based on the corresponding number below.");
            Console.WriteLine("'1' = Adding");
            Console.WriteLine("'2' = Subtraction");
            Console.WriteLine("'3' = Multiply");
            Console.WriteLine("'4' = Division");

            int mathType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please tell me the first number  you would like to use.");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please tell me the second number  you would like to use.");
            var num2 = Convert.ToInt32(Console.ReadLine());

            

            switch (mathType)
            {
                case 1: Console.WriteLine($"Addition value is : {Adding(num1, num2)}");
                    break;
                case 2: Console.WriteLine($"Subtraction value is : {Subtraction(num1, num2)}");
                    break;
                case 3: Console.WriteLine($"Multiplication value is : {Multiply(num1, num2)}");
                    break;
                case 4: Console.WriteLine($"Division value is : {Dividing(num1, num2)}");
                    break;


            }

            




                //Console.WriteLine("please tell me the first number  you would like to multiply.");
                //var num1Multiply = int.Parse(Console.ReadLine());

                //Console.WriteLine("please tell me the second number  you would like to multiply.");
                //var num2Multiply = int.Parse(Console.ReadLine());


                //Console.WriteLine($"The product is {Multiply(num1Multiply, num2Multiply)}.");




            Console.WriteLine("Hello, what is your name?");

            var userName = Console.ReadLine();

            Console.WriteLine("What is your favorite type of music?");
            var favMusic = Console.ReadLine();

            Console.WriteLine("What is the best city you have ever visited?");
            var favCity = Console.ReadLine();

            Console.WriteLine("If you could be an animal what animal would you be?");
            var favAnimal = Console.ReadLine();

            Console.WriteLine($"Why hello {userName}, welcome to our profile builder.  This can help others learn more about you.  " +
                $"It appears, based on your answers....that you would love nothing more than to be dressed as a {favAnimal} while riding to " +
                $"{favCity} to catch your desired {favMusic} concert.  Please use this information wisely {userName}!");
        }


    }
}
