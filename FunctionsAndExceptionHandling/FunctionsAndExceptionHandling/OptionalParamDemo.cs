using System;


namespace FunctionsAndExceptionHandling
{
    //  This program demo how to use Optional Parameters.
    class OptionalParamDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            Console.WriteLine($"Size is:{myMath.Size(20)}");
            Console.WriteLine($"Size is:{myMath.Size(20,20)}");
            Console.WriteLine(myMath.StudentDetails(20, "Scott", city: "Mumbai"));
            Console.ReadLine();
        }
    }
}
