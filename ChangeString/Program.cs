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
            
            Console.Write("\nCaráter: ");
            string letra_s = Console.ReadLine();
            char letra = char.Parse(letra_s);

            Console.Write("\nSerá impresso: ");

            foreach(char palavra_pequena in palavra){
                if(palavra_pequena == letra)
                {
                    Console.Write(letra);
                }
                else{
                    Console.Write(palavra_pequena);
                }
            }
        }
    }
}
