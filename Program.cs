namespace ControleWork2
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string>();

            Console.WriteLine("Введите имена (по одному имени на строку). Для окончания ввода введите пустую строку:");

            // Читаем имена с клавиатуры, пока пользователь не введет пустую строку
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                names.Add(input);
            }

            // Сортируем список имен по алфавиту
            names.Sort();

            Console.WriteLine("Введите имя для поиска:");
            string searchName = Console.ReadLine();

            // Ищем заданное имя в списке
            int index = names.BinarySearch(searchName);

            if (index >= 0)
            {
                Console.WriteLine("Имя найдено в списке!");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}