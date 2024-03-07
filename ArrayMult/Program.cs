using System;
using System.ComponentModel;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] A = new float[2, 2];
            float[,] B = new float[2, 1];

            
            

            for(int i = 0; i < 3; i += 2){
                for(int j = 0; j < 2; j++){
                    A[i/2, j] = float.Parse(args[i + j]);
                }
            }
            
            B[0,0] = float.Parse(args[4]);
            B[1,0] = float.Parse(args[5]);

            float[,] AvezesB = new float[2, 2];

            for(int i = 0; i < 2; i++){
                for(int j = 0; j < 2; j++){
                    AvezesB[i, j] = A[i, j] * B[i, 0];
                }
            }

            foreach(float numero in AvezesB){
                Console.WriteLine(numero);
            }
        }
    }
}
