using System;
using System.IO;

namespace MyEvent
{
    class Program
    {
        private static void OnSerch(object sender, string rez)
        {
            Console.WriteLine(rez);
        }
        static void Main(string[] args)
        {
            TextSerch textSerch = new TextSerch();
            textSerch.Serch += OnSerch;
            textSerch.Start(@"C:\Test\", "C#");
            Console.ReadLine();
        }

    }
    class TextSerch
    {
        public event EventHandler<string> Serch;

        public void Start(string path, string text)
        {
            string[] Files = Directory.GetFiles(path);
            foreach (string i in Files)
            {
                int line = 1;
                foreach (string j in File.ReadLines(i))
                {
                    if (j.Contains(text))
                    {
                        Serch?.Invoke(this, $"Текст найден в файле {i} номер строки - {line}");
                    }

                    ++line;
                }
            }
        }
    }
}
