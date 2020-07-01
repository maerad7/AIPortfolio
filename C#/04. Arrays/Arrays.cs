using System;

namespace Arrays
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arrays = new int[101];
            // 1부터 100까지를 변수에 저장
            for (int i = 1;i < 101; i++){
                arrays[i] = i;
                Console.WriteLine(arrays[i]);
            }
        }
    }
}
