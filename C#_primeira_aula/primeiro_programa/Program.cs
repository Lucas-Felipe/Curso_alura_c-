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

            Funcionarios.Diretor y = new Funcionarios.Diretor(456789);
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

            calculaBonificacao();
            Console.WriteLine("\n-------------------------------------------------------------------\n");
            UsarSistema();
            
        }

        public static void calculaBonificacao()
        {
            GerenciadorBonificacao gerenb = new GerenciadorBonificacao();

            Funcionarios.Funcionarios a = new Funcionarios.Designer(123);
            Funcionarios.Funcionarios b = new Funcionarios.Diretor(456);
            Funcionarios.Funcionarios c = new Funcionarios.Auxiliar(789);
            Funcionarios.Funcionarios d = new Funcionarios.GerenteDeConta(963);

            Funcionarios.Desenvolvedor e = new Funcionarios.Desenvolvedor(852);

            gerenb.registrar(a);
            gerenb.registrar(b);
            gerenb.registrar(c);
            gerenb.registrar(d);
            gerenb.registrar(e);

            Console.WriteLine("\n------------------------------------------------------\n" +
                "total de bonificacao: "+gerenb.GetTotal());
        }

        public static void UsarSistema()
        {
            Sistemas.SistemaInterno system = new Sistemas.SistemaInterno();

            Funcionarios.Diretor a = new Funcionarios.Diretor(123);
            Funcionarios.GerenteDeConta d = new Funcionarios.GerenteDeConta(963);

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";

            a.Nome = "cavalo";
            a.Senha = "789";

            d.Nome = "cavala";
            d.Senha = "456";

            system.Logar(parceiro, "123");
            system.Logar(a, "789");
            system.Logar(d, "456");
           
        }
    }

}
