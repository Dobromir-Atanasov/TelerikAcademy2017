using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Display
    {
        private double size;
        private int numberOfColors;
        public Display(double size, int colors)
        {
            this.size = size;
            this.numberOfColors = colors;
        }
        public double Size
        {
            get { return this.size; }
            set {
                if (value<0)
                {
                    throw new ArgumentException("Value must be greater then or equal to Zero");
                }
                if (value>100)
                {
                    throw new ArgumentException("Is this a door?");
                }
                this.size = value; }
        }
        public int NumberOfColors {
            get { return this.numberOfColors; }
            set
            {
                if (value <0)
                {
                    throw new ArgumentException("Value must be greater then or equal to Zero");
                }
                if (value>int.MaxValue)
                {
                    throw new ArgumentException("Must be less then 2 000 000");                }
                this.numberOfColors = value;
            }
        }
    }
}
