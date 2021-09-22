using System;

namespace FunctionsAndExceptionHandling
{
    //  This program demo. how to use out paramater.
    class OutParamDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            double gstAmt;
            Console.WriteLine($"Total Product Amount is:{myMath.GstCalc(1000, 8, out gstAmt)}" );
            Console.WriteLine($"GST Amount is:{gstAmt}");
            Console.ReadLine();
        }
    }
}
