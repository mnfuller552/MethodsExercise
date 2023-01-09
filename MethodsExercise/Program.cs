namespace MethodsExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;

        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;

        }

        static void Main(string[] args)
        {

            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);

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
}

            
        

