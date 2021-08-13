using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Desenvolvedor:Funcionarios
    {
        
        public Desenvolvedor(int cpf):base(cpf,3000)
        {

        }

        public override void aumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double bonificacao()
        {
            return Salario * 0.1;
        }
    }
}
