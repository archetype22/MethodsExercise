namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 ~
            #region
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();   
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("What is your lucky number?");
            int luckyNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"{name}, you will see {luckyNumber} {favColor} {favAnimal}s this day, and your life will be complete!");
            #endregion

            //Exercise 2 ~
            #region
            Console.WriteLine(Methods.Add(9, 3));
            Console.WriteLine(Methods.Multiply(9, 3));
            Console.WriteLine(Methods.Divide(9, 3)); 
            Console.WriteLine(Methods.Subtract(9, 3));
            #endregion

            //Bonus ~
            Methods.AddWithParam(12, 11, 10, 9, 8, 7);
            Methods.MultiplyWithParam(3, 3, 3, 3, 3);
            Methods.SubtractWithParam(24, 12, 10, 2);
        }
    }
}
