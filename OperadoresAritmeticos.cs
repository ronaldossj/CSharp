using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            //IMC

            double peso = 78.9;
            double altura = 1.75;
            double IMC = peso / Math.Pow(altura, 2);
            Console.WriteLine($"Imc é {IMC}.");

            // Numero Impar 

            int par = 36;
            int impar = 9;
            Console.WriteLine($"{par} o número é par, pois o resto é: {par % 2}");
            Console.WriteLine($"{impar} o número é impar, pois o resto é: {impar % 2}");
        }
    }
}
