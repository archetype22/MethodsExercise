namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();   
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("What is your lucky number?");
            int luckyNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"{name}, you will see {luckyNumber} {favColor} {favAnimal}s this day, and your life will be complete!");

        }
    }
}
