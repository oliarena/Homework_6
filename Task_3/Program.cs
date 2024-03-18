namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.Notes notes = new Book.Notes();
            notes.Content = "My note";
            notes.Content = "My additional note";
            notes.Print();

            Console.ReadKey();
        }
    }
}

//Тут питань немає, все добре 
