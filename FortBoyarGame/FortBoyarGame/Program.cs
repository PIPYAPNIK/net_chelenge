using System;

namespace FortBoyarGame
{
    class Program
    {
        static int ComputerMove()
        {
            int[] computer = new int[] { 1, 2, 3 };
            Random rand = new Random();
            var move = computer[rand.Next(0, computer.Length)];
            return move;
        }
        static void Game(int count)
        {
            if (count > 1)
            {
                Console.WriteLine($"Текущее кол - во палочек = {count}");
                Console.Write($"Введите, сколько палочек вы убираете - ");
                int move = Convert.ToInt32(Console.ReadLine());
                if (move > 0 && move < 4)
                {
                    count -= move;
                    if (count > 1)
                    {
                        Console.WriteLine($"Текущее кол - во палочек = {count}");
                        int compMove = ComputerMove();
                        Console.WriteLine($"Компьютер убирает {compMove}");
                        count -= compMove;
                        if (count >= 1) Game(count);
                        else Console.WriteLine("Вы выиграли");
                    }
                    else Console.WriteLine("Вы приграли");
                }
                else
                {
                    Console.WriteLine("Вы что то сдеалали не так");
                    Game(count);
                }
            }
            else Console.WriteLine("Вы приграли");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Перед вам n количество палочек, каждый игрок может вытягивать 1, 2 или 3 полочки за раз. Тот кто вытянет последнюю - проиграл");

            Console.Write("Введите количество полочек - ");
            int shelf = Convert.ToInt32(Console.ReadLine());

            Game(shelf);
            Console.ReadLine();
        }
    }
}
