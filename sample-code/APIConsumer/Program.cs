namespace APIConsumer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PrimeHolding.Tools;
    using PrimeHolding.Tools.Common.Exceptions;    

    class Program
    {
        static void Usage()
        {
            String appName = AppDomain.CurrentDomain.FriendlyName;

            Console.WriteLine();
            Console.WriteLine("Usage: {0} <command> [<options>]", appName);
            Console.WriteLine();
            Console.WriteLine("These are command commands used in various situations:");
            Console.WriteLine();
            Console.WriteLine("Convert images to various formats");
            Console.WriteLine("\tconvert | c\t\tConvert images to one of supported formats");
            Console.WriteLine();
            Console.WriteLine("\tOptions: ");
            Console.WriteLine("\t--source | -s\t\tPath to source file");
            Console.WriteLine("\t--destination | -d\tPath to destination file");
            Console.WriteLine("\t--type | -t\t\tImage type for destination file. GIF, PNG and JP(E)G are supported");
            Console.WriteLine();
            Console.WriteLine("Resize images using various strategies");
            Console.WriteLine();
            Console.WriteLine("\trezise | r\t\tResize images using one of available strategies");
            Console.WriteLine();
            Console.WriteLine("\tOptions: ");
            Console.WriteLine("\t--source | -s\t\tPath to source file");
            Console.WriteLine("\t--destination | -d\tPath to destination file");
            Console.WriteLine("\t--type | -t\t\tResize type for destination file. Crop, Skew and KeepAspect are supported");
            Console.WriteLine("\t--width | -w\t\tWidth of destination file");
            Console.WriteLine("\t--height | -h\t\tHeight of destination file");
            Console.WriteLine("\t--startX | -x\t\tX Coordinate for cropping");
            Console.WriteLine("\t--startY | -y\t\tY Coordinate for cropping");
            Console.WriteLine();
            Console.WriteLine("Misc");
            Console.WriteLine();
            Console.WriteLine("\thelp | h\t\tDisplay this information");
            Console.WriteLine();
        }

        static int Main(string[] args)
        {
            String command = "", sourceFile = "", destinationFile = "", type = "";
            int width = 0, height = 0, startX = 0, startY = 0;

            // Get CLI arguments as List
            var arg = new List<string>(args);
            
            // Validate arguments count
            if (arg.Count < 1)
            {
                Usage();

                return 1;
            }

            ImageTools tools = new ImageTools();
            
            // Get command
            command = arg.First().ToLower();
            arg.RemoveAt(0);
            
            // Get Options
            while (arg.Count > 0)
            {
                switch (arg.First().ToLower())
                {
                    case "-s":
                    case "--source":
                        // Remove option name
                        arg.RemoveAt(0);

                        // Get option value
                        sourceFile = arg.First().ToLower();
                        arg.RemoveAt(0);
                        break;

                    case "-d":
                    case "--destination":
                        // Remove option name
                        arg.RemoveAt(0);

                        // Get option value
                        destinationFile = arg.First().ToLower();
                        arg.RemoveAt(0);
                        break;

                    case "-t":
                    case "--type":
                        // Remove option name
                        arg.RemoveAt(0);

                        // Get option value
                        type = arg.First().ToLower();
                        arg.RemoveAt(0);
                        break;

                    case "-w":
                    case "--width":
                        // Remove option name
                        arg.RemoveAt(0);

                        // Get option value
                        width = Int32.Parse(arg.First());
                        arg.RemoveAt(0);
                        break;

                    case "-h":
                    case "--height":
                        // Remove option name
                        arg.RemoveAt(0);

                        // Get option value
                        height = Int32.Parse(arg.First());
                        arg.RemoveAt(0);
                        break;

                    case "-x":
                    case "--startX":
                        // Remove option name
                        arg.RemoveAt(0);

                        // Get option value
                        startX = Int32.Parse(arg.First());
                        arg.RemoveAt(0);
                        break;

                    case "-y":
                    case "--startY":
                        // Remove option name
                        arg.RemoveAt(0);

                        // Get option value
                        startY = Int32.Parse(arg.First());
                        arg.RemoveAt(0);
                        break;

                    default:
                        // In case if we have nonsense as option
                        arg.RemoveAt(0);
                        break;
                }
            }

            // TODO: Add more exceptions to exception handling
            try {
                switch (command)
                {
                    case "help":
                    case "h":
                        Usage();
                        return 0;
    #pragma warning disable CS0162 // Unreachable code detected
                        break;
    #pragma warning restore CS0162 // Unreachable code detected

                    case "convert":
                    case "c":
                        tools.Convert(sourceFile, destinationFile, type);
                        break;

                    case "resize":
                    case "r":
                        tools.Resize(sourceFile, destinationFile, type, width, height, startX, startY);
                        break;

                    default:
                        Usage();
                        return 1;
    #pragma warning disable CS0162 // Unreachable code detected
                        break;
    #pragma warning restore CS0162 // Unreachable code detected
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }

            return 0;
        }
    }
}
