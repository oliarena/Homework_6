namespace Task_2
{
    static class FindAndReplaceManager
    {

        public static void FindNext(string str)
        {
            Console.WriteLine("Searching a string : " + str); //Для цього уроку, те що потрібно зробити це зайве :-)

            // Задача в тому, що треба просто зробити класс, через котрий будет виконуватися робота, але цей клас передае через себе інформацію в інший клас. Що і відображено у 12 і 13 строці коду.

            Book book = new Book();
            book.FindNext(str);

            Console.WriteLine(new string('-', 25));
        }
    }
}
