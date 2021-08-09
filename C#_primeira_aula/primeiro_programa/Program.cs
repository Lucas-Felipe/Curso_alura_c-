using System;


namespace primeiro_programa
{
    class Program
    {
        static void Main(string[] args)
        {
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
