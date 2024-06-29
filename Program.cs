
using System;

namespace Access4
{
    internal class Complex
    {
        internal int real;
        internal int img;

        public void setData(int r, int i)
        {
            real = r;
            img = i;
        }

        public void displayData()
        {
            Console.WriteLine("Real "+ real);
            Console.WriteLine("Imaginary "+ img);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {          
            Complex c = new Complex();
            c.setData(2, 1);
            c.displayData();
        }
    }
}

