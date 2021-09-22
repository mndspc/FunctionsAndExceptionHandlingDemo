using System;
using System.Collections.Generic;


namespace FunctionsAndExceptionHandling
{
    //  This program demo. how to return user defined types from functions.
    class ReturnUserDefinedType
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            var emp = myMath.GetEmployee();
            Console.Write($"Code={emp.EmpCode} Name={emp.EmpName}");

            Console.WriteLine();

            var emplist = myMath.GetEmployees();
            foreach(var employee in emplist)
            {
                Console.WriteLine($"Code={employee.EmpCode} Name={employee.EmpName}");
            }

            Console.ReadLine();
        }
    }
}
