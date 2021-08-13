using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.IO.IOException;

namespace Programa2_excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            try
            {
                ContaCorrente conta = new ContaCorrente(123, 789,"lucas",123);
                ContaCorrente conta2 = new ContaCorrente(456, 123, "jaquim", 963);
                
                conta.imprime();
                conta2.imprime();
                conta.deposito(100);
                conta.imprime();
                //conta.saque(200);
                conta.saque(50);
                conta.imprime();
                conta.transferencia(50, conta2);
                conta.imprime();
                conta2.imprime();

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Taxa: "+ContaCorrente.Taxa);

            


        }
    }

}
