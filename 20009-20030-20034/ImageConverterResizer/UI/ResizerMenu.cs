using ImageConverterResizer.Helpers;
using ImagerLib;
using System;

namespace ImageConverterResizer.UI
{
    public class ResizerMenu
    {
        private Imager imager = new Imager();

        private ResizerOptionsType RenderMenuResizer()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[Resizer] MENU\n");
                Console.WriteLine("Choose operation: \n");
                Console.WriteLine("1.[C]rop");
                Console.WriteLine("2.[K]eepAspect");
                Console.WriteLine("3.[S]kew\n");
                Console.WriteLine("---------------");
                Console.WriteLine("[B]ack to MainMenu\n");

                Console.Write("Imager >> ");
                string choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "C":
                        {
                            return ResizerOptionsType.Crop;
                         
                        }
                    case "K":
                        {
                            return ResizerOptionsType.KeepAspect;
                        }
                    case "S":
                        {
                            return ResizerOptionsType.Skew;
                        }
                    case "B":
                        {
                            return ResizerOptionsType.MainMenu;
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

        public void ShowResizerMenu()
        {
            while (true)
            {
                ResizerOptionsType choice = RenderMenuResizer();
                try
                {
                    switch (choice)
                    {
                        case ResizerOptionsType.Crop:
                            {
                                Crop();
                                break;
                            }
                        case ResizerOptionsType.KeepAspect:
                            {
                                KeepAspect();
                                break;
                            }
                        case ResizerOptionsType.Skew:
                            {
                                Skew();
                                break;
                            }
                        case ResizerOptionsType.MainMenu:
                            {
                                new UserMenu().ShowMainMenu();
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

        private void Crop()
        {
            Console.Clear();
            Console.WriteLine("[Crop]\n");
            Console.Write("SourceDestination: ");
            string sourcePath = Console.ReadLine();

            Console.Write("DestinationPath: ");
            string destinatonPath = Console.ReadLine();

            Console.Write("Enter expected width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter expected height: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Start point X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Start point Y: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Operation: ");
            string operationType = Console.ReadLine();

            imager.Resize(sourcePath, destinatonPath,(ResizeType)Enum.Parse(typeof(ResizeType), operationType, true),width,height,x,y);
        }

        private void KeepAspect()
        {
            Console.Clear();
            Console.WriteLine("[KeepAspect]\n");
            Console.Write("SourceDestination: ");
            string sourcePath = Console.ReadLine();

            Console.Write("DestinationPath: ");
            string destinatonPath = Console.ReadLine();

            Console.Write("Enter expected width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter expected height: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Operation: ");
            string operationType = Console.ReadLine();

            imager.Resize(sourcePath, destinatonPath, (ResizeType)Enum.Parse(typeof(ResizeType), operationType, true), width, height);
        }

        private void Skew()
        {
            Console.Clear();
            Console.WriteLine("[Skew]\n");
            Console.Write("SourceDestination: ");
            string sourcePath = Console.ReadLine();

            Console.Write("DestinationPath: ");
            string destinatonPath = Console.ReadLine();

            Console.Write("Enter expected width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter expected height: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Operation: ");
            string operationType = Console.ReadLine();

            imager.Resize(sourcePath, destinatonPath, (ResizeType)Enum.Parse(typeof(ResizeType), operationType, true), width, height);
        }
    }
}
