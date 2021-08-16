using System;
using Modelos;

namespace programa3_bibliotecas
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123,456,"lucas",064607,"estudante");
            
            conta.deposito(200);
            conta.imprime();

            DateTime datafim = new DateTime(2019, 05, 30);
            DateTime now = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromDays(366);

            string message = "\nVencimento: " + Humanizer.TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(message);
        }
    }
}
