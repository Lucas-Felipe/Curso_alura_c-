using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2_excecoes
{
    public class ContaCorrente
    {
        private readonly Cliente _titular;
        private readonly int _numeroAgencia;
        private readonly int _numeroConta;
        private readonly double _saldo = 0;
        public static double Taxa { get; private set; }
        public static int TotalDeContas { get; private set; }
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
        }

        public int NumeroAgencia
        {
            get
            {
                return _numeroAgencia;
            }
        }

        public int NumeroConta
        {
            get
            {
                return _numeroConta;
            }

        }
        public double Saldo { get; private set; }

        public ContaCorrente(int agencia, int numero, string nome, int cpf)
        {
            if (agencia == 0)
            {
                throw new ArgumentException("Agencia deve ser maior q zero!", nameof(agencia));
            }
            else if (numero == 0)
            {
                throw new ArgumentException("conta deve ser maior q zero!", nameof(numero));
            }

            _numeroAgencia = agencia;
            _numeroConta = numero;
            _titular = new Cliente(nome, cpf);

            TotalDeContas++;

            try
            {
                Taxa = 30 / TotalDeContas;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void imprime()
        {
            Console.WriteLine("\n titular: " + Titular.Nome + "\n CPF: " + Titular.CPF + "\n Profissão: " + Titular.Profission +
                "\n saldo: " + Saldo + "\n numero agencia: " +
                NumeroAgencia + "\n numero conta: " + NumeroConta);
        }

        public void saque(int valor)
        {
            
            if (valor < Saldo)
            {
                Saldo = Saldo - valor;
                Console.WriteLine("\n saque de " + valor + " na conta de " + Titular.Nome + " feito com sucesso!");
            }
            else
            {
                throw new ArgumentException("Erro na operação de saque! ",new ExecptionSaque());
            }

        }

        public void deposito(int valor)
        {
            Saldo = Saldo + valor;
            Console.WriteLine("\n deposito de " + valor + " na conta de " + Titular.Nome + " feito com sucesso!");
        }

        public void transferencia(int valor, ContaCorrente contadestino)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                contadestino.deposito(valor);
                Console.WriteLine("\n transferencia para " + contadestino.Titular.Nome + " de " +
                    Titular.Nome + " no valor de " + valor + " feita com sucesso!");
            }
            else 
            { 
                throw new ArgumentException("erro na operação de transferencia! ",new ExecptionSaque()); 
            }
        }
    }
}