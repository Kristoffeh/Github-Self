using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_Self
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Version = "1.4";

            Console.WriteLine("// GITHUB SELF //");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Currently running software version v" + Version  + ", developed in Visual Studio 2018");
            Console.WriteLine("Type !help for a list of commands to use");

            Console.WriteLine("");

            String command;
            Boolean quitNow = false;
            while (!quitNow)
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "!help":
                        Console.WriteLine("» Commands available");
                        Console.WriteLine("» !help");
                        Console.WriteLine("» !git");
                        break;

                    case "!git":
                        Console.WriteLine("Processing transfer..");

                        string sourcePath = "C:/xampp/htdocs";
                        string targetPath = "G:/Github/HEX-Design/HEX-Design";
                        string fileName = string.Empty;
                        string destFile = string.Empty;

                        // To copy all the files in one directory to another directory. 
                        // Get the files in the source folder. (To recursively iterate through 
                        // all subfolders under the current directory, see 
                        // "How to: Iterate Through a Directory Tree.")
                        // Note: Check for target path was performed previously 
                        //       in this code example. 
                        if (System.IO.Directory.Exists(sourcePath))
                        {
                            string[] files = System.IO.Directory.GetFiles(sourcePath);

                            Console.Write("Files has been moved to the specified location.");
                            Console.WriteLine("");

                            // Copy the files and overwrite destination files if they already exist. 
                            foreach (string s in files)
                            {
                                // Use static Path methods to extract only the file name from the path.
                                fileName = System.IO.Path.GetFileName(s);
                                destFile = System.IO.Path.Combine(targetPath, fileName);
                                System.IO.File.Copy(s, destFile, true);
                                
                            }
                        }
                        else
                        {
                            Console.WriteLine("Source path does not exist!");
                        }
                        break;

                    case "!version":
                        Console.WriteLine("This program is running on version v" + Version);
                        break;

                    default:
                        Console.WriteLine("Unknown command " + command);
                        break;
                }
            }
        }
    }
}
