using System;

namespace C_Sharp_Training
{
    /// <summary>
    /// all about datatype of C#
    /// </summary>
    class CSDataType
    {
        // bool
        public bool b = true;

        // Numeric
        short sh = 12;
        int i = int.MaxValue;
        long l = 1234L;
        float f = 123.45F;
        double d1 = 123.45;
        double d2 = 123.45D;
        decimal d = 123.45M;

        // Char / String
        char c = 'A';
        string s = "Hello";

        public DateTime dt = new DateTime(2018, 10, 10, 12, 13, 0);

        public static void DataType()
        {
            string sn;
            sn = null;
            int? i = null;
            i = 101;

            bool? b = null;

            Nullable<int> j = null;
            j = 10;
            int k = j.Value;
            //k = j; // need explicit casting


            CSDataType csd = new CSDataType();
            Console.WriteLine("CSDataType");
            Console.WriteLine(csd.b);
            Console.WriteLine(csd.dt);

            Console.WriteLine(sn);
            Console.WriteLine(i);
            Console.WriteLine(b);
            Console.WriteLine(j);
            Console.WriteLine(k);
        }
    }

    class CSDataTypeProgram
    {
        //static void Main(string[] args)
        //{
        //    CSDataType.DataType();
        //}
    }

}
