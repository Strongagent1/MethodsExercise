using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program 
    {
        
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Adding(int num1, int num2)
        {
            return num1 + num2;
        }


        static void  Main(string[] args)
        {

            
                Console.WriteLine("please tell me the first number  you would like to add.");
                var num1Add = int.Parse(Console.ReadLine());

                Console.WriteLine("please tell me the second number  you would like to add.");
                var num2Add = int.Parse(Console.ReadLine());


                Console.WriteLine($"The sum is {Adding(num1Add, num2Add)}.");




                Console.WriteLine("please tell me the first number  you would like to multiply.");
                var num1Multiply = int.Parse(Console.ReadLine());

                Console.WriteLine("please tell me the second number  you would like to multiply.");
                var num2Multiply = int.Parse(Console.ReadLine());


                Console.WriteLine($"The product is {Multiply(num1Multiply, num2Multiply)}.");




            //Console.WriteLine("Hello, what is your name?");

            //var userName = Console.ReadLine();

            //Console.WriteLine("What is your favorite type of music?");
            //var favMusic = Console.ReadLine();

            //Console.WriteLine("What is the best city you have ever visited?");
            //var favCity = Console.ReadLine();

            //Console.WriteLine("If you could be an animal what animal would you be?");
            //var favAnimal = Console.ReadLine();

            //Console.WriteLine($"Why hello {userName}, welcome to our profile builder.  This can help others learn more about you.  " +
            //    $"It appears, based on your answers....that you would love nothing more than to be dressed as a {favAnimal} while riding to " +
            //    $"{favCity} to catch your desired {favMusic} concert.  Please use this information wisely {userName}!");
        }


    }
}
