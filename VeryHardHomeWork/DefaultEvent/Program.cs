using System;
using System.IO;

namespace DefaultEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();

            watcher.Path = @"C:\test";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);

            watcher.EnableRaisingEvents = true;

            Console.ReadKey();
        }

        private static void OnChanged(object sourse, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} is Changed");
        }

        private static void OnCreated(object sourse, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} is Created");
        }

        private static void OnDeleted(object sourse, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} is Deleted");
        }
    }
}
