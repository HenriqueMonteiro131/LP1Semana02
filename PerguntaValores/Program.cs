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
           
            float pi = 3.1415926f;

            Console.WriteLine("What is the height (h) of the cylinder: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the radius (r) of the cylinder: ");
            int r = Convert.ToInt32(Console.ReadLine());

            float v = (pi*(r * r)*h);

            float s = 2(pi*r(r + h));

            Console.WriteLine("V = " + v);
            Console.WriteLine("S = " + s);


        }
    }
}
