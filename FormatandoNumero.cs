using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // F1 = Uma casa decimal
            Console.WriteLine(valor.ToString("C")); // C = Valor monetário
            Console.WriteLine(valor.ToString("P")); // P = Valor percentual
            Console.WriteLine(valor.ToString("#.##")); // #.# = valor especifico de casas

            CultureInfo cultura = new CultureInfo("en-US"); // Mudança de linguagem padrão a ser seguida pelo código
            Console.WriteLine(valor.ToString("C0", cultura)); // C0 = Número de casas, sendo o numeral o número de casas desejado.

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // D = Completa com zero a esquerda, sendo o numeral a quantidade de números zeros para completar a esquerda, nesse caso seram adicionados 7 numeros 0 já que a variavel já possui três números.
        }
    }
}
