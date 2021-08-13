using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using primeiro_programa;

public class ContaCorrente
{
    private Cliente _titular=new Cliente();
    private int _numeroAgencia;
    private int _numeroConta;
    private double _saldo=100;
    public static double Taxa { get; private set; }
    public static int TotalDeContas { get; private set; }
    public Cliente Titular { get; set; }
    public int NumeroAgencia { get; set; }
    public int NumeroConta { get; set; }
    public double Saldo { get; set; }

    public ContaCorrente(int agencia,int numero) 
    {
        NumeroAgencia = agencia;
        NumeroConta = numero;

        Taxa = 30/TotalDeContas;
        TotalDeContas++;
    }

    public void imprime()
    {
        Console.WriteLine("\n titular: " + Titular.Nome + "\n saldo: "+Saldo+"\n numero agencia: "+
            NumeroAgencia +"\n numero conta: " + NumeroConta);
    }

    public void saque(int valor)
    {
        if (valor<Saldo)
        {
            Saldo = Saldo - valor;
            Console.WriteLine("\n saque de "+valor+" na conta de "+Titular.Nome+" feito com sucesso!");
        }
        else
        {
            Console.WriteLine("\n erro ao sacar!");
        }
            
    }

    public void deposito(int valor)
    {
        Saldo = Saldo + valor;
        Console.WriteLine("\n deposito de "+valor+" na conta de "+Titular.Nome+" feito com sucesso!");
    }

    public void transferencia(int valor,ContaCorrente contadestino)
    {
        if (Saldo >=valor)
        {
            Saldo -= valor;
            contadestino.deposito(valor);
            Console.WriteLine("\n transferencia para "+contadestino.Titular.Nome+" de "+
                Titular.Nome+ " no valor de "+valor+" feita com sucesso!");
        }
    }
}