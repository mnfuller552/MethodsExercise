namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");

            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");

            var animal = Console.ReadLine();

            Console.WriteLine("Who is your favorite musician?");

            var musician = Console.ReadLine();

            Console.WriteLine($"One day, {name} was wearing a {color} shirt. He took a ride downtown on his {animal} to go see {musician} in concert.");

        }   
    } 
}
