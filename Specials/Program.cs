using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte sb = sbyte.MaxValue;
            Console.WriteLine(sb);

            /// <summary>
            /// mini - minimum value 
            /// </summary>
            sbyte sbmini = sbyte.MinValue;
            Console.WriteLine(sbmini);

            short sh = short.MaxValue;
            Console.WriteLine(sh);

            short shmini = short.MinValue;
            Console.WriteLine(shmini);

            double db = double.MaxValue;
            Console.WriteLine(db);
            
            double dbmini = double.MinValue;
            Console.WriteLine(dbmini);

            float f = float.MaxValue;
            Console.WriteLine(f);
            
            float fmini = float.MinValue;
            Console.WriteLine(fmini);

            int i = int.MaxValue;
            Console.WriteLine(i);
            
            int imini = int.MinValue;
            Console.WriteLine(imini);

            decimal dc = decimal.MaxValue; 
            Console.WriteLine(dc);

            decimal dcmini = decimal.MinValue; 
            Console.WriteLine(dcmini);

            double x = double. PositiveInfinity;
            Console.WriteLine(x);

            double z = double. NegativeInfinity;
            Console.WriteLine(z);

            float y = float .NaN;
            Console.WriteLine(y);

            double a = double .NaN;
            Console.WriteLine(a);

            int max_short = short.MaxValue;
            Console.WriteLine(max_short);
            Console.WriteLine((short) ( max_short + 1));

            double double_max = double.MaxValue + 1;
            Console.WriteLine(double_max);

            float float_max = float.MaxValue + 1;
            Console.WriteLine(float_max);

            float float1 , float2 ;
            float1 = float2 = 10000.0f;
            Console.WriteLine(float1 == float2 + 0.0001f);


        }
    }
}
