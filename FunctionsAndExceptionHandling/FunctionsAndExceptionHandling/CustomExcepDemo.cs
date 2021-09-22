using System;


namespace FunctionsAndExceptionHandling
{
    //  This program demo. how to catch userdefined excep.
    class CustomExcepDemo
    {
        static void Main()
        {
            try
            {
                Employee employee = new Employee();
                employee.ValidateEmployeeCode(0, "Scott");
            }catch(InvalidEmployeeCode ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
