using System;

namespace RightSize
{
    class Program
    {
        /// <summary>
        /// Programa que imprime args que excedem os 3 caratéres e acaba o
        /// programa caso exceda os 6 caratéres
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //for loop que atribui 1 a 1 do args ao s
            foreach(string s in args)
            {
                //caso o s exceda os 6 caratéres, acaba o programa
                if (s.Length > 6)
                    break;
                
                //caso o s exceda os 3 caratéres, imprime o s
                if (s.Length > 3)
                    Console.WriteLine(s);
            }
        }
    }
}
