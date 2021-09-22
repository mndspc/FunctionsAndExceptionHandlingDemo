using System;


namespace FunctionsAndExceptionHandling
{
    //  This program demo how to pass array as an argument using param keyword
    class ParamDemo
    {
        
        static void Main()
        {
            MyMath myMath = new MyMath();
            int[] marks = {50,60,70,80,90 };
            myMath.PrintMarks(marks);
            myMath.PrintMarks(50, 60, 70, 80, 90);
            Console.ReadLine();
        }
    }
}
