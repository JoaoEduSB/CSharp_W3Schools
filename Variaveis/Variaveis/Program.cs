using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos de variáveis:");

            Console.WriteLine();

            Console.WriteLine("Int = Inteira");
            Console.WriteLine("double = Real");
            Console.WriteLine("Char = Caracteres únicos. Exemplo = A");
            Console.WriteLine("string = Textos. Exemplo = Olá mundo");
            Console.WriteLine("bool = verdadeiro ou falso");

            Console.WriteLine();

            // Sintaxe

            Console.WriteLine("Declaração de variáveis em C#: tipo nomedavariavel = valor"); // = significa recebe
            Console.WriteLine("Exemplo: double NotaDoAluno = 9.5");

            Console.WriteLine();

            Console.WriteLine("Tipos de variáveis:");
            Console.WriteLine("int = inteiros");
            Console.WriteLine("double = real");
            Console.WriteLine("char = caractere (armazena apenas 1 caractere)");
            Console.WriteLine("string = caractere (armazena textos ou seja, + de 1 caractere)");
            Console.WriteLine("bool = real ou verdadeiro");

            Console.WriteLine();

            Console.WriteLine("Armazenar texto em uma variável:");
            string nome = "João";
            Console.WriteLine(nome);      

            Console.WriteLine("Armazenar um número em uma variável:");
            int numero = 15;
            Console.WriteLine(numero);

            Console.WriteLine("Também é possível criar a variável e depois atribuir o valor:");
            int meuNumero;
            meuNumero = 15;
            Console.WriteLine(meuNumero);

            Console.WriteLine("Trocar o valor da variável:");
            int trocaNumero = 10;
            trocaNumero = 15;
            Console.WriteLine(trocaNumero);

            Console.WriteLine("Como declarar variáveis de todos os tipos:");

            Console.WriteLine("int meuNumero = 5;");
            Console.WriteLine("double meuNumeroReal = 5.99;");
            Console.WriteLine("char minhaLetra = J;");
            Console.WriteLine("bool meuBooleano = true;");
            Console.WriteLine("string meuTexto = \"Olá Mundo!\";");

            Console.WriteLine();

            // Constantes
            Console.WriteLine("Constantes");

            Console.WriteLine("É obrigatório atribuir um valor para a constante, caso contrário irá aparecer um erro");

            /*
            const int meuNumero = 15;
            meuNumero = 20; 

            Isso causará um erro.
             */
        }
    }
}