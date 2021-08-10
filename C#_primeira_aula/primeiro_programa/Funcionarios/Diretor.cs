using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa.Funcionarios
{
    public class Diretor : Funcionarios
    {
        public Diretor(int cpf,double salario):base(cpf,salario)
        {

        }
        public override double bonificacao()
        {
            return Salario*0.5;
        }

        public override void aumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
