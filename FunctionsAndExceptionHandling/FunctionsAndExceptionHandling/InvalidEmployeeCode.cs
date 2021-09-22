using System;

namespace FunctionsAndExceptionHandling
{
    //  This class contains how to create user defined exception
    class InvalidEmployeeCode:Exception
    {
        public InvalidEmployeeCode():base("Invalid Employee Code")
        {

        } 
    }
}
