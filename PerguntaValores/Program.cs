using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// V = πr2h Sa = 2πr(r + h) - Volume and Radius
            /// </summary>
           
            //float pi = 3.1415926f;
            

            Console.WriteLine("What is the height (h) of the cylinder: ");
            float h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the radius (r) of the cylinder: ");
            float r = Convert.ToInt32(Console.ReadLine());

            double r2 = Math.Pow(r,2);

            double v = (Math.PI*r2*h);

            double s = 2*(Math.PI*r*(r + h));

            Console.WriteLine($"V = {v}");
            Console.WriteLine($"S = {s}");


        }
    }
}
