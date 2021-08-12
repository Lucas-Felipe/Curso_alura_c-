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
       

        public string Nome { get; set; }
        public int CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionarios(int cpf,double salario)
        {
            CPF = cpf;
            Salario = salario;
            QteFuncionarios++;
        }

        public abstract double bonificacao();
        

        public abstract void aumentarSalario();
        
    }
}
