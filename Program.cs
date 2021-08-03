using System;

namespace Lab4_1_Parallelogram
{
    class Parallelogram
    {
        public double B; // B is for Base
        public double H; // H is for Height
        public double S; // S is for Side

        public double GetArea()
        {
            return B * H;
        }
               
        public double GetPerimeter()
        {
            return 2 * (B + S);
        }

        public void Print()
        {
            Console.WriteLine("\nHere is your Parallelogram:");
            Console.WriteLine($"Base: {B}");
            Console.WriteLine($"Height: {H}");
            Console.WriteLine($"Side: {S}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
            Console.WriteLine($"Area: {GetArea()}");          
        }

        public void Resize(double newB, double newH)
        {

            B = newB;
            H = newH;

            if (newB < 0 || newH < 0)
            {
                // If they give us a negative, just don't change it.
                // We won't print out a message or anything.
                return;
            }                      
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parallelogram p1 = new Parallelogram() { B = 5, H = 7, S = 8 };
            p1.Print();

            Parallelogram p2 = new Parallelogram() { B = 3, H = 4, S = 5 };
            p2.Print();
        }
    }
}
