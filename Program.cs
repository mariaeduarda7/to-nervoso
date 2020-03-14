using System;

namespace to_nervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usuário, o que você pensa sobre mim?");
            string mensagem = Console.ReadLine();
            string tonervoso = mensagem.Remove(10) + "... nao pera";
            Console.WriteLine(tonervoso);
            Console.WriteLine("to nervoso");
        }   
    }
}
