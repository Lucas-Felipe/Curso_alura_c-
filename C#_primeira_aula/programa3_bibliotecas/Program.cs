using System;
using Modelos;

namespace programa3_bibliotecas
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123,456,"lucas",064607);
            
            conta.imprime();


        }
    }
}
