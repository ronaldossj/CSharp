using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é: " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int" + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira" + populacaoBrasileira);

            long menorValorLong = 207_600_000;
            Console.WriteLine("menor long" + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial" + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador: " + precoComputador);

            double valordeMercadoDaApple = 1_000_000;
            Console.WriteLine("Valor da Apple" + valordeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância é de: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra é: " + letra);
        }
    }
}
