using System;
using System.IO;

namespace DocumentMerger2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int i;
            string outputInfo = "";

            if (args.Length < 3)
            {
                Console.WriteLine("DocumentMerger2 <input_file_1> <input_file_2> ... <input_file_n> <output_file>");
                Console.WriteLine("Supply a list of text files to merge followed by the name of the resulting merged text file as command line arguments.");
            }
            else
            {

                for (i = 0; i < args.Length - 1; i++)
                {
                    Console.WriteLine("Merge file {0}", args[i]);

                }
                while (!File.Exists(args[i]))
                {
                    Console.WriteLine("The file {0} couldn't be found. Try again", args[i]);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                try
                {
                    outputInfo += File.ReadAllText(args[i]);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error!!!!! -- {0}", e.Message);
                }

            }
        }
    }
}
