using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Rectangular:Figure
    {
        public Rectangular(int width, int length)
        {
            this.Width = width;
            this.Length = length;
        }

        private int _width;
        private int _length;

        public int Width
        {
            get => _width;
            set
            {
                if (value > 0)
                {
                    this._width = value;
                }
            }
        }
        public int Length
        {
            get => _length;
            set
            {
                if (value > 0)
                {
                    this._length = value;
                }
            }
        }

        public override void CalcArea()
        {
            Console.WriteLine($"Area of rectangular is : {Width * Length}");
        }
    }
}
