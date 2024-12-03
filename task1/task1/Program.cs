namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш возраст");

            if (int.TryParse(Console.ReadLine(), out var age))
            {
                if (age % 2 == 0)
                {
                    Console.WriteLine("Ваш возраст - четное число.");
                }
                else
                {
                    Console.WriteLine("Ваш возраст - нечетное число.");
                }

                switch (age)
                {
                    case <= 2:
                        Console.WriteLine("Вы младенец");
                        break;
                    case >= 3 and <= 12:
                        Console.WriteLine("Вы ребенок");
                        break;
                    case >= 13 and <= 17:
                        Console.WriteLine("Вы подросток");
                        break;
                    case >= 18 and <= 59:
                        Console.WriteLine("Вы взрослый");
                        break;
                    case > 60:
                        Console.WriteLine("Вы пожилой");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введено некорректное значение");
            }
        } 
    }
}
