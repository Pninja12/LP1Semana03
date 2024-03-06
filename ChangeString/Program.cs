using System;

namespace ChangeString
{
    class Program
    {
        /// <summary>
        /// Programa que pede uma string e um char ao utilizador e troca todas
        /// as letra na string que coicidem com o char por um X
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //pede a string ao utilizador e guarda a variável
            Console.Write("String: ");
            string palavra = Console.ReadLine();
            
            //pede a string ao utilizador, troca para char e guarda a variável
            Console.Write("Caráter: ");
            string letra_s = Console.ReadLine();
            char letra = char.Parse(letra_s);

            Console.Write("Será impresso: ");
            //mostra no ecrã letra a letra da palavra e caso alguma delas
            //coicida com a letra escolhida pelo jogador, imprime um X 
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
