using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class FuncionarioAutenticavel:Funcionarios,IAutenticavel
    {

        public string Senha { get; set; }
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public FuncionarioAutenticavel(int cpf,double salario):base(cpf,salario)
        {

        }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.compararSenha(Senha,senha);
        }
        
    }
}
