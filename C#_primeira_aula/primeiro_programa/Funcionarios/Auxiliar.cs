using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa.Funcionarios
{
    class Auxiliar : Funcionarios
    {
        public Auxiliar(double cpf) : base(2000, cpf)
        {

        }

        public override void aumentarSalario()
        {
            Salario *= 1.1;
        }
        public override double bonificacao()
        {
            return Salario * 0.2;
        }
    }
}
