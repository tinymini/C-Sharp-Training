using System;

namespace C_Sharp_Training
{
    /// <summary>
    /// what is array in c#?
    /// </summary>
    class CSArray
    {
        public static void Array()
        {
            // 1 dimension array
            string[] players = new string[10];
            string[] Region = { "서울", "경기", "부산" };

            // 2 dimension array / Rectangular
            string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

            // 3 dimension array / Rectangular
            string[,,] Cubes;

            // Jagged Array - first dimension's size should be determined when complie time

            // should determine size of 1 dimension array
            int[][] A = new int[3][];

            A[0] = new int[2];
            A[1] = new int[3] { 1, 2, 3, };
            A[2] = new int[4] { 1, 2, 3, 4 };

            A[0][0] = 1;
            A[0][1] = 2;

            // C# array is from '.Net Framework's System.Array'

            Console.WriteLine("CSArray");


            int sum = 0;
            int[] scores = { 80, 90, 58, 22, 19, 100 };
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            Console.WriteLine(sum);

            // array is refernce type. so when passing array
            // it is not copy all data but send a reference pointer

            sum = CalcuateSum(scores);
            Console.WriteLine(sum);
        }

        static int CalcuateSum(int[] scoresArray)
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }
            return sum;
        }
    }

    class CSArrayProgram
    {
        //static void Main(string[] args)
        //{
        //    CSArray.Array();
            
        //}
    }

}
