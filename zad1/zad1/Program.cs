using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"c:\test\test_kar_wac.txt";

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            int count = content.Count(c => c == 'a' || c == 'A');
            Console.WriteLine($"Liczba wystąpień litery 'a': {count}");
        }
        else
        {
            Console.WriteLine("Plik nie istnieje.");
        }
    }
}