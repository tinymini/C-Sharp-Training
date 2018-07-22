using System;

namespace C_Sharp_Training
{
    /// <summary>
    /// global variable and local variable
    /// </summary>
    class CSvar
    {
        // global var has default value zero (int)
        int globalVar;
        // constant
        const int MAX = 1024;
        // readonly value is decided at runtime
        readonly int ReadonlyMax;

        public CSvar()
        {
            ReadonlyMax = 1;
        }

        public void Method1()
        {
            int localVar;
            localVar = 100;

            Console.WriteLine("CSvar");
            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
            Console.WriteLine(MAX);
            Console.WriteLine(ReadonlyMax);

        }
    }

    class CSVarProgram
    {
        //static void Main(string[] args)
        //{
        //    CSvar csVar = new CSvar();
        //    csVar.Method1();
        //}
      
    }
}