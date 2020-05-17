using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Ronaldo";
            var nacionalidade = "Brasileiro";
            int idade = 23;
            Console.WriteLine("O meu nome é " + nome + " sou " + nacionalidade + " e tenho " + idade + " anos de idade.");
            Console.WriteLine("O meu nome é {0} sou {1} e tenho {2} anos de idade.", nome, nacionalidade, idade);
            Console.WriteLine($"O meu nome é {nome}");
            Console.WriteLine($"1 + 1 = {1 + 1}");
        }
    }
}