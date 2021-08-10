using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa.Funcionarios
{
    public abstract class Funcionarios
    {
        public static int QteFuncionarios { get; private set; }

        private string _nome;
        private int _cpf;
        private double _salario;

        public string Nome { get; set; }
        public int CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionarios(int cpf,double salario)
        {
            CPF = cpf;
            Salario = salario;
            QteFuncionarios++;
        }

        public virtual double bonificacao()
        {
            return Salario * 0.10;
        }

        public virtual void aumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
