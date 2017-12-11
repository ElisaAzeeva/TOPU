using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CursTOPU
{
    class Program
    {
        const int M = 2;
        const int N = 2;
        static void Main(string[] args)
        {
            //variable
            string fNAME_MATR = "Input.txt";
            int[,] ABR = new int[M + 1,N+M];
            int[] nB = new int[M];
            int[] bBR = new int[M+1];
            //program
            GetMatr(fNAME_MATR,ABR);
            Console.WriteLine(GetL(ABR));
            PrintArr(ABR);
            Console.ReadLine();
        }
        static void GetMatr(string fNAME_MATR, int[,] intArray)
        {
            FileStream f = new FileStream(fNAME_MATR, FileMode.Open);
            StreamReader reader = new StreamReader(f);
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                    intArray[i, j] = reader.Read();   
            }
            reader.Close();
        }
        static void PrintArr(int[,] intArray)
        {
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                    Console.Write(intArray[i, j] + "  ");
                Console.WriteLine();
            }
        }
        static int GetL(int[,] ABR)
        {
            var res = (from int x in ABR select x).Skip(M - 1).Take(1).Max();
            //var max = (from int x in ABR select x).Max();
            return (int)res;
        }
    }
}
