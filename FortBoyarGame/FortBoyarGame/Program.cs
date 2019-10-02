using System;

namespace FortBoyarGame
{
    class Program
    {
        static int id = 1;

        static int Act(string firstName, string secondName, int move)
        {
            if (id == 1)
            {
              First:
                Console.Write($"{firstName} убирает - ");
                move = Convert.ToInt32(Console.ReadLine());
                if (move > 3 || move <= 0)
                {
                    Console.WriteLine("Упс что то не то, давай еще раз");
                    goto First;
                }
                id = 2;
            }
            else if (id == 2)
            {
              Second:
                Console.Write($"{secondName} убирает - ");
                move = Convert.ToInt32(Console.ReadLine());
                if (move > 3 || move <= 0)
                {
                    Console.WriteLine("Упс что то не то, давай еще раз");
                    goto Second;
                }
                id = 1;
            }
            Console.WriteLine();
            return move;
        }
        static void Game(string firstName, string secondName, int quantity)
        {
            int move = 1;
            Console.WriteLine($"Количество палочек - {quantity}");

            if (quantity > 1)
            {
                move = Act(firstName, secondName, move);
                Game(firstName, secondName, quantity - move);
            }
            else
            {
                if (id == 1) Console.Write($"{firstName} проиграл ");
                if (id == 2) Console.Write($"{secondName} проиграл ");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите имя игрока, который ходит первым - ");
            string firstPlayer = Console.ReadLine().ToString();

            Console.Write("\nВведите имя игрока, который ходит вторым - ");
            string secondPlayer = Console.ReadLine().ToString();

            Console.WriteLine("Перед вам n количество палочек, каждый игрок может вытягивать 1, 2 или 3 полочки за раз. Тот кто вытянет последнюю - проиграл");

            Console.Write("Введите количество полочек - ");
            int shelf = Convert.ToInt32(Console.ReadLine());

            Game(firstPlayer, secondPlayer, shelf);
            Console.ReadLine();
        }
    }
}
