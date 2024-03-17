using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Rectangle
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }
        public int SetLength(int length)
        {
            if (length < 0)
            {
                Console.WriteLine("Length should be greater than zero");
                return length;
            }
            else
            {
                return length;
            }
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            if (width < 0)
            {
                Console.WriteLine("Width should be greater than zero");
                return width;
            }
            else
            {
                return width;
            }
        }
        public int GetPerimeter()
        {
            return (width + length) * 2;
        }
        public int GetArea()
        {
            return width * length;
        }

    }
}
