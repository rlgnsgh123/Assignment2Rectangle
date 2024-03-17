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
            return this.length;
        }
        public int SetLength(int length)
        {
            if (length < 0)
            {
                Console.WriteLine("Length should be greater than zero");
                this.length = length;
                return this.length;
            }
            else
            {
                this.length = length;
                return this.length;
            }
        }
        public int GetWidth()
        {
            return this.width;
        }
        public int SetWidth(int width)
        {
            if (width < 0)
            {
                Console.WriteLine("Width should be greater than zero");
                this.width = width;
                return this.width;
            }
            else
            {
                this.width = width;
                return this.width;
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
