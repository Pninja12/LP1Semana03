using System;
using System.ComponentModel;

namespace ArrayMult
{
    class Program
    {
        /// <summary>
        /// Programa que recebe 6 parametros e os primeiros 4 vão para uma lista
        /// e os últimos dois vão para outra, então o programa multiplica as 
        /// listas como matrizes e mostra o resultado
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   
            //criação das duas matrizes
            float[,] A = new float[2, 2];
            float[,] B = new float[2, 1];

            //duplo cilco for para adicionar os números à lista A
            for(int i = 0; i < 3; i += 2){
                for(int j = 0; j < 2; j++){
                    A[i/2, j] = float.Parse(args[i + j]);
                }
            }

            //adicionar os últimos dois números à lista B
            B[0,0] = float.Parse(args[4]);
            B[1,0] = float.Parse(args[5]);

            //criação da matriz final e de uma varável de suporte à operação
            float[,] AvezesB = new float[2, 1];
            float AmaisB = 0;

            //duplo ciclo for que multiplica, soma e atribui as variáveis
            for(int i = 0; i < 2; i++){
                for(int j = 0; j < 2; j++){
                    //soma e multiplicação
                    AmaisB += A[i, j] * B[j, 0];
                }
                //atribuição
                AvezesB[i, 0] = AmaisB;
                //reset da variável para ser usada de novo
                AmaisB = 0;
            }
            
            //mostra todos os número dentro da matriz final
            foreach(float numero in AvezesB)
                    Console.WriteLine(numero);
                
        }
    }
}
