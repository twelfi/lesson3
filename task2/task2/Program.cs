namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool value1, value2;
            Console.WriteLine("Введите первое значение true/false:");
            while (!bool.TryParse(Console.ReadLine(), out value1))
            {
                Console.WriteLine("Некорректное значение. Введите true/false:");
            }

            Console.WriteLine("Введите второе значение true/false:");
            while (!bool.TryParse(Console.ReadLine(), out value2))
            {
                Console.WriteLine("Некорректное значение. Введите true/false:");
            }

            Console.WriteLine("Результаты операций:");
            Console.WriteLine("p \tq \tp&q \tp|q \tp^q \t!p \t!q ");
            Console.WriteLine($"{value1}\t{value2}\t{value1 && value2}\t{value1 | value2}\t{value1 ^ value2}\t{!value1}\t{!value2}");
        }
    }
}
