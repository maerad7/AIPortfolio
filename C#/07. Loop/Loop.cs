using System;
using System.Diagnostics;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 차원 배열 선언
            string[,,] arr = new string[,,] { 
                { {"1", "2"}, {"11","22"} }, 
                { {"3", "4"}, {"33", "44"} }
            };

            // 3번 반복
            for (int i=0; i < arr.GetLength(0); i++)
            {
                for (int j=0 ; j < arr.GetLength(1); j++)
                {
                    for (int k=0; k < arr.GetLength(2); k++)
                    {
                        Console.WriteLine(arr[i,j,k]);
                    }
                }
            }

            // 1번에 3차원 배열 처리
            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
