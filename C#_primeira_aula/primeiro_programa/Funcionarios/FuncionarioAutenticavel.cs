using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa.Funcionarios
{
    public abstract class FuncionarioAutenticavel:Funcionarios,Sistemas.IAutenticavel
    {

        public string Senha { get; set; }
        public FuncionarioAutenticavel(int cpf,double salario):base(cpf,salario)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
        
    }
}
