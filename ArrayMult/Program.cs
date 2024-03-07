using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] A = new float[2, 2];
            float[,] B = new float[2, 1];

            for(int i = 0; i < 2; i++){
                for(int j = 0; i < 2; j++){
                    int cont = i + j;
                    A[i, j] = float.Parse(args[i + j]);
                }
            }
            B[0,0] = float.Parse(args[5]);
            B[1,0] = float.Parse(args[6]);
        }
    }
}
