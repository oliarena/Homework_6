namespace Task_3
{
    internal class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Console.WriteLine("Searching a string : " + str);

            Book book = new Book();
            book.FindNext(str);

            Console.WriteLine(new string('-', 25));
        }
    }
}
