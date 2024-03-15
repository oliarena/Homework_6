using System.Drawing;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("some string");
            FindAndReplaceManager.FindNext("Duis aute irure dolor");
            FindAndReplaceManager.FindNext("Lorem ipsum dolor sit");
            FindAndReplaceManager.FindNext("quis nostrud");

            Console.ReadKey();
        }
    }
}