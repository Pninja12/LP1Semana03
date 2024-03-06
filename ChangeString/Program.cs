using System;

namespace ChangeString
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string palavra = Console.ReadLine();
            
            Console.Write("Caráter: ");
            string letra_s = Console.ReadLine();
            char letra = char.Parse(letra_s);

            Console.Write("Será impresso: ");

            foreach(char palavra_pequena in palavra){
                if(palavra_pequena == letra)
                {
                    Console.Write("X");
                }
                else{
                    Console.Write(palavra_pequena);
                }
            }
        }
    }
}
