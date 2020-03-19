using System;
using System.Collections.Generic;
using System.Text;

namespace GitBashImplementation
{
    class InputSanitisation
    {
        public List<string> Input()
        {
            string userCommand = Console.ReadLine().ToLower();

            if (userCommand.Contains("diff"))
            {
                string[] commandSplit = userCommand.Split(" ");
                if (!commandSplit[1].Contains(".txt") || !commandSplit[2].Contains(".txt"))
                {
                    Console.WriteLine("\nParamaters are invalid!\n");
                    return Input();
                }
                else
                {
                    List<string> fileNames = new List<string> { commandSplit[1], commandSplit[2] };
                    return fileNames;
                }
            }
            else
            {
                Console.WriteLine("\nCommand is invalid!\n");
                return Input();
            }
        }
    }
}
