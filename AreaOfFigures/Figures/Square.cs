using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Square:Figure
    {
        public Square(int side)
        {
            this.Side = side;
        }

        private int _side;
        public int Side {
            get => _side;
            set
            {
                if (value > 0)
                {
                    this._side = value ;
                }
            }


         }

        public override void CalcArea()
        {
            Console.WriteLine($"Area of square is : {Side*Side}");
        }
    }
}
