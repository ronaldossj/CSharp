using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Ronaldo";
            // nome = 123; (Não é possivel trocar o tipo da variavel inferida)
            Console.WriteLine(nome);

            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 4;

            int b = 5;
            Console.WriteLine(a + b);
        }
    }
}
