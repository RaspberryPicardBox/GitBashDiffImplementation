using System;
using System.Collections.Generic;

namespace GitBashImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            InputSanitisation userInput = new InputSanitisation();

            Console.WriteLine("-----Welcome to Git Bash C#-----\n");

            List<string> fileNames = userInput.Input();

            string fileOne = System.IO.File.ReadAllText(@$"../../../../Files/{fileNames[0]}");
            string fileTwo = System.IO.File.ReadAllText(@$"../../../../Files/{fileNames[1]}");

            if (fileOne == fileTwo)
            {
                Console.WriteLine($"\n{fileNames[0]} and {fileNames[1]} are not different.");
            }
            else
            {
                Console.WriteLine($"\n{fileNames[0]} and {fileNames[1]} are different.");
            }
        }
    }
}
