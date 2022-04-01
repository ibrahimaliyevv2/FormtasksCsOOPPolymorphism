using System;
using Figures;
namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Square square = new Square(1);
            Rectangular rectangular = new Rectangular(1, 1);
            while (check)
            {
                Console.WriteLine("=======================");
                Console.WriteLine("Enter operation 1/2/3 :");
                Console.WriteLine(" 1. Square \n 2. Rectangular \n 0. Quit ");
                Console.WriteLine("========================");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter side of square:");
                        square.Side = Convert.ToInt32(Console.ReadLine());
                        square.CalcArea();
                        break;
                    case 2:
                        Console.WriteLine("Enter width of rectangular:");
                        rectangular.Width = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter length of rectangular:");
                        rectangular.Length = Convert.ToInt32(Console.ReadLine());
                        rectangular.CalcArea();
                        break;
                    case 0:
                        Console.WriteLine("Good-bye!");
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }
                    
            }
        }
    }
}
