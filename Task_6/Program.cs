namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 25;
            double b = 5;
            
            Console.WriteLine($"{a} + {b} = {Calculator.Add(a, b)}");
            Console.WriteLine($"{a} - {b} = {Calculator.Subtract(a, b)}");
            Console.WriteLine($"{a} * {b} = {Calculator.Multiply(a, b)}");
            Console.WriteLine($"{a} / {b} = {Calculator.Divide(a, b)}");

            Console.ReadKey();
        }
    }
}