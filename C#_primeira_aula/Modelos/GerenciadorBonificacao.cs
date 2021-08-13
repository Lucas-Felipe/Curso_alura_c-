using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelos
{
    class GerenciadorBonificacao
    {

        private double _total;

        public double GetTotal() { return _total; }
        public void registrar(Funcionarios funcionario)
        {
            _total+=funcionario.bonificacao();
        }
    }
}
