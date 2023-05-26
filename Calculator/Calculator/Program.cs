namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("===== Calculator =====");
                Console.WriteLine("1. Addition ( + )");
                Console.WriteLine("2. Subtraction ( - )");
                Console.WriteLine("3. Multiplication ( * )");
                Console.WriteLine("4. Division ( / )");
                Console.WriteLine("5. Exit");
                Console.WriteLine("--------------------");
                Console.Write("Select an operation: ");

                int input = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}