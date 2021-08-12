using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa.Funcionarios
{
    class GerenteDeConta:FuncionarioAutenticavel
    {
        public GerenteDeConta(int cpf) : base(cpf,4000)
        {

        }

        public override void aumentarSalario()
        {
            Salario *= 1.05;
        }
        public override double bonificacao()
        {
            return Salario * 0.25;
        }
    }
}
