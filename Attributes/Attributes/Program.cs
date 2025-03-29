using System;

namespace Atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atributos do C#");

            Console.WriteLine("");
            Console.Write("Sem o Line ele não");
            Console.Write(" pula uma linha");
            Console.WriteLine("");

            Console.WriteLine("Comentário em uma linha só"); // Comentário em uma linha só
            Console.WriteLine("Comentário multilinhas"); 
            /* 
                             Esse comentário não aparece em produção
                                                                                */
        }
    }
}