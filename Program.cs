using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            ChangeLength(rectangle);
            ChangeWidth(rectangle);
            InitApplication(rectangle);
        }

        private static void ChangeWidth(Rectangle rectangle)
        {
            int width = 0;
            Boolean loop = true;
            while (loop)
            {
                Console.WriteLine("Please enter Width: ");
                if (!Int32.TryParse(Console.ReadLine(), out width) || width <= 0)
                {
                    Console.WriteLine("Wrong width. please try again and provide numeric value greater than 0.");
                    continue;
                }
                else
                {
                    rectangle.SetWidth(width);
                    loop = false;
                }
            }

        }
        private static void ChangeLength(Rectangle rectangle)
        {
            Boolean loop = true;
            int length = 0;
            while (loop)
            {

                Console.WriteLine("Please enter Length: ");
                if (!Int32.TryParse(Console.ReadLine(), out length) || length <= 0)
                {
                    Console.WriteLine("Wrong Length. please try again and provide numeric value greater than 0.");
                    continue;
                }
                else
                {
                    rectangle.SetLength(length);
                    loop = false;
                }
            }
        }
        private static void InitApplication(Rectangle rectangle)
        {
            string selection;
            do
            {

                Console.WriteLine();
                Console.WriteLine("Make a selection of number from the below list to perform various actions!!");
                Console.WriteLine();
                Console.WriteLine("Press 1. Get Rectangle Length");
                Console.WriteLine("Press 2. Change Rectangle Length");
                Console.WriteLine("Press 3. Get Rectangle Width");
                Console.WriteLine("Press 4. Change Rectangle Width");
                Console.WriteLine("Press 5. Get Rectangle Perimeter");
                Console.WriteLine("Press 6. Get Rectangle Area");
                Console.WriteLine("Press 7. Exit");
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.WriteLine(rectangle.GetLength());
                        break;
                    case "2":
                        ChangeLength(rectangle);
                        break;
                    case "3":
                        Console.WriteLine(rectangle.GetWidth());
                        break;
                    case "4":
                        ChangeWidth(rectangle);
                        break;
                    case "5":
                        Console.WriteLine(rectangle.GetPerimeter());
                        break;
                    case "6":
                        Console.WriteLine(rectangle.GetArea());
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please choose option properly!!");
                        break;


                }
            } while (int.TryParse(selection, out int SelectionId) || SelectionId <= 0);

        }
    }

}
