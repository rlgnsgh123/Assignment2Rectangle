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


        public Rectangle()
        {

        }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            try
            {
                if (this.length < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    return this.length;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public int SetLength(int length)
        {
            try
            {
                if (length < 0)
                {
                    Console.WriteLine("Length should be greater than zero");
                    this.length = length;
                    throw new ArgumentException();
                }
                else
                {
                    this.length = length;
                    return this.length;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public int GetWidth()
        {
            try
            {
                if (this.width < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    return this.width;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int SetWidth(int width)
        {
            try
            {
                if (width < 0)
                {
                    Console.WriteLine("width should be greater than zero");
                    this.width = width;
                    throw new ArgumentException();
                }
                else
                {
                    this.width = width;
                    return this.width;
                }
            }
            catch (Exception)
            {

                throw;
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
