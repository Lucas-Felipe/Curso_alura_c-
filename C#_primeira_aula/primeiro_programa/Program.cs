using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            

            //Console.WriteLine("\n "+t.bonificacao());

            Funcionarios.Diretor y = new Funcionarios.Diretor(456789,20000);
            y.Nome = "roberta";
            y.aumentarSalario();
            
            gerenciador.registrar(y);

            //Console.WriteLine(gerenciador.Total);

            Console.WriteLine("total func.: " + Funcionarios.Funcionarios.QteFuncionarios);

            Console.WriteLine(y.Nome+" "+y.CPF+" "+y.Salario);

            Console.WriteLine("--------------------------------------------------------------------------------");

            ContaCorrente a = new ContaCorrente();
            ContaCorrente b = new ContaCorrente();

            Cliente c = new Cliente();
            Cliente d = new Cliente();
            d.Nome = "jaquim";
            d.CPF = 456;
            d.Profission = "ristorant";
            c.Nome = "lucas";
            c.CPF = 123;
            c.Profission = "vergonha";
            b.Titular = d;
            a.Titular = c;

            a.imprime();
            a.deposito(100);
            a.imprime();

            a.saque(120);
            a.imprime();

            a.saque(50);
            a.imprime();

            b.imprime();
            a.transferencia(50, b);
            b.imprime();
            a.imprime();

            b.transferencia(50, a);
            b.imprime();
            a.imprime();

            
        }
    }
}
