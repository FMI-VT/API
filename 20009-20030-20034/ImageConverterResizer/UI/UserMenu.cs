using ImageConverterResizer.Helpers;
using ImagerLib;
using System;

namespace ImageConverterResizer.UI
{
    public class UserMenu
    {
        private Imager imager = new Imager();

        private MenuOptionsType RenderMainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("WELCOME TO IMAGER # CONVERTER & RESIZER # ");
                Console.WriteLine("\nChoose option : \n");
                Console.WriteLine("1.[C]onverter");
                Console.WriteLine("2.[R]esizer\n");
                Console.WriteLine("--------------------");
                Console.WriteLine("E[x]it\n");

                Console.Write("Imager >> ");
                string choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "C":
                        {
                            return MenuOptionsType.Converter;
                        }
                    case "R":
                        {
                            return MenuOptionsType.Resizer;
                        }
                    case "X":
                        {
                            return MenuOptionsType.Exit;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice.");
                            Console.ReadKey(true);
                            break;
                        }
                }
            }
        }

        public void ShowMainMenu()
        {
            while (true)
            {
                MenuOptionsType choice = RenderMainMenu();
                try
                {
                    switch (choice)
                    {
                        case MenuOptionsType.Converter:
                            {
                                Convert();
                                break;
                            }
                        case MenuOptionsType.Resizer:
                            {
                                new ResizerMenu().ShowResizerMenu();
                                break;
                            }
                        case MenuOptionsType.Exit:
                            {
                                Environment.Exit(0);
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.ReadKey(true);
                }
            }

        }
        
        private void Convert()
        {
            Console.Clear();
            Console.Write("Available formats: JPG,GIF,PNG\n\n");
            Console.Write("SourceDestination: ");
            string sourcePath = Console.ReadLine();

            Console.Write("DestinationPath: ");
            string destinatonPath = Console.ReadLine();

            Console.Write("Format: ");
            string imageFormat = Console.ReadLine();

            imager.Convert(sourcePath, destinatonPath,(ConvertType)Enum.Parse(typeof(ConvertType),imageFormat,true));

        }
   
    }
}
