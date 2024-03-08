using System;

namespace PowTwoUntil
{
    class Program
    {
        /// <summary>
        /// Função que ao ser chamada escreve os multiplos de 2 até 32
        /// </summary>
        private static void PowersOf2Until5()
        {
            //quando um ciclo acaba, o i avança uma casa binária até chegar ao
            //máximo de 5 casas binárias
            for (int i = 1; i <= (1<<5); i = i<<1)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// O programa corre a função anterior 2 vezes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
        }
    }
}
