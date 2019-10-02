using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace ProgramTests
{
    [TestClass]
    public class Program
    {
        public static int i = 0;

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

        [TestMethod]
        public void Main()
        {

            string path = "erweweff";
            DirShow(path);
        }
    }
}
