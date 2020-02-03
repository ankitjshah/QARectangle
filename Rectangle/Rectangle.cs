using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return this.length;
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public int GetWidth()
        {
            return 0;
        }
        public void SetWidth(int width) 
        {
            this.width = width;
        }
        public int GetPerimeter() 
        {
            return 2 * (this.width + this.length);
        }

        public int GetArea()
        {
            return this.length * this.width;
        }

    }
}
