using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace practical_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("TextFile1.txt"))
            {
                string content = File.ReadAllText("TextFile1.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            Console.WriteLine("Please enter new content for the file:");
            string newContent = Console.ReadLine();
            File.WriteAllText("TextFile1.txt", newContent);
            


        }
    }
}
