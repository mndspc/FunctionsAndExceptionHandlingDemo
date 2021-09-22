using System;


namespace FunctionsAndExceptionHandling
{
    class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }

        public void ValidateEmployeeCode(int empCode,string empName)
        {
            this.EmpCode = empCode;
            if (EmpCode <= 0)
            {
                throw new InvalidEmployeeCode();
            }
            else
            {
              
                this.EmpName = empName;
                Console.WriteLine(this.Display());
            }
        }

        public string Display()
        {
            return $"Code={this.EmpCode}\nName={this.EmpName}";
        }
    }
}
