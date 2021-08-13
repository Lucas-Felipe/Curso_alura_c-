using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(int cpf):base(cpf,5000)
        {

        }
        public override void aumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double bonificacao()
        {
            return Salario*0.5;
        }
       
    }
}
