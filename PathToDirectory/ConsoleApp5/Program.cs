using System;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        public static  int  i = 0;

        public static void DirShow(string dir)
        {
            string[] dirs = Directory.GetDirectories(dir);

            for (int i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine(dirs[i]);
                DirShow(dirs[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please write directory: ");
            string path = Console.ReadLine().ToString();
            DirShow(path);

            Console.WriteLine("The End!");
            Console.ReadKey();
        }
    }
}
