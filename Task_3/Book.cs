namespace Task_3
{
    class Book
    {
        readonly string content;
        public Book()
        {
            content = "Lorem ipsum dolor sit amet, \n" +
            "consectetur adipiscing elit, \n" +
            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. \n" +
            "Ut enim ad minim veniam, quis nostrud exercitation \n" +
            "ullamco laboris nisi ut aliquip ex ea commodo consequat. \n" +
            "Duis aute irure dolor in reprehenderit in voluptate \n" +
            "velit esse cillum dolore eu fugiat nulla pariatur.\n" +
            "Excepteur sint occaecat cupidatat non proident, \n" +
            "sunt in culpa qui officia deserunt mollit anim id est laborum. \n";
        }

        public void FindNext(string str)
        {
            string[] rows = content.Split('\n');

            for (int i = 0; i < rows.Length; i++)
            {
                if (rows[i].Contains(str, StringComparison.CurrentCulture))
                {
                    Console.WriteLine($"Found in a row #{i + 1}: {rows[i]}");
                    return;
                }
            }

            Console.WriteLine("The string has not been found.");
        }


        public class Notes
        {
            string content;

            public string Content
            {
                get { return content; }
                set
                {
                    content += (string.IsNullOrEmpty(content) ? "" : '\n') + value;
                }
            }

            public Notes() {
                content = "";
            }

            public void Print()
            {
                Console.WriteLine("Notes:");
                Console.WriteLine(content);
            }

        }
    }
}
