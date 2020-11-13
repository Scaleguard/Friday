using System;
using System.IO;

namespace Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFilePath();
            WriteDirectoriesPath();

        }

        public static void WriteFilePath()
        {
            
            string directoryPath = @"C:\Users\opilane\Samples";

            string Directorypath = @"C:\Users\opilane\Friday\SampleDirectories.txt";

            string[] folders = Directory.GetDirectories(directoryPath, "*.*", SearchOption.AllDirectories);

            File.WriteAllLines(Directorypath, folders);
        }

        public static void WriteDirectoriesPath()
        {

            string directoryPath = @"C:\Users\opilane\Samples";

            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            string filepath = @"C:\Users\opilane\Friday\SampleFiles.txt";

            File.WriteAllLines(filepath, files);
        }
    }
}
