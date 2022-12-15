namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
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
