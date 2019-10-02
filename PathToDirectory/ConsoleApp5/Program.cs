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
            if (i == dirs.Length)
                Console.WriteLine("The end");
            if (i < dirs.Length)
            {
                Console.WriteLine($"{i + 1} {dirs[i]}");
                i++;
                DirShow(dir);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please write directory: ");
            string path = Console.ReadLine().ToString();
            DirShow(path);
            Console.ReadKey();
        }
    }
}
