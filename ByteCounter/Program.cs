using System;
using System.IO;
namespace ByteCounter;
class Program
{
    static void Main()
    {
        string path = @"E://Downloads";
        Console.WriteLine($"Total size: {CountBytes(path)} bytes");

        Console.ReadKey();
    }
    static double CountBytes(string path, double size = 0)
    {
        if (Directory.Exists(path))
        {
            string[] files = Directory.GetFiles(path);
            foreach (string file in files) { size += file.Length; }

            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs) { size += CountBytes(dir, size); }

            return size;
        }
        return -1;
    }
}
