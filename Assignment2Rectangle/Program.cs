using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int width = 0;

            bool isTrue;
            int option;

            do
            {
                Console.Write("Please enter lenght: ");
                isTrue = int.TryParse(Console.ReadLine(), out length);
                
                if (!isTrue)
                {
                    Console.Write("\nPlease enter right lenght as inteager...");   
                }
            } while (!isTrue);

            do
            {
                Console.Write("Please enter width: ");
                isTrue = int.TryParse(Console.ReadLine(), out width);

                if (!isTrue)
                {
                    Console.Write("\nPlease enter right width as inteager...");
                }
            } while (!isTrue);

            Rectangle rectangle = new Rectangle(length, width);


            do
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                Console.Write("-----------------------------------------");



                do
                {
                    Console.Write("\nPlease select option : ");
                    isTrue = int.TryParse(Console.ReadLine(), out option);

                    if (!isTrue)
                    {
                        Console.Write("\nPlease enter right option between that option.....");
                    }
                } while (!isTrue);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Entered length: "+rectangle.GetLength());
                        break;
                    case 2:
                        Console.Write("Please enter new lenght: ");
                        do
                        {
                            isTrue = int.TryParse(Console.ReadLine(), out length);

                            if (!isTrue)
                            {
                                Console.Write("Please enter right lenght as inteager...");
                            }
                        } while (!isTrue);
                        rectangle.SetLength(length);
                        Console.WriteLine("Updated Length: "+ rectangle.GetLength());
                        break;
                    case 3:
                        Console.WriteLine("Entered length: " + rectangle.GetLength());
                        break;
                    case 4:
                        do
                        {
                            Console.Write("Please enter width: ");
                            isTrue = int.TryParse(Console.ReadLine(), out length);

                            if (!isTrue)
                            {
                                Console.WriteLine("Please enter right width as inteager...");
                            }
                        } while (!isTrue);
                        rectangle.SetWidth(width);
                        Console.WriteLine("Updated width: " + rectangle.GetWidth());
                        break;
                    case 5:
                        Console.WriteLine("Perimeter : "+rectangle.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("Area : " +rectangle.GetArea());
                        break;
                    case 7:
                        Console.WriteLine("Good Bye");
                        break;
                }

            } while (option != 7);


        }
    }
}
