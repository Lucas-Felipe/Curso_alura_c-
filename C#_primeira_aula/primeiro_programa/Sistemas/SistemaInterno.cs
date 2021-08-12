using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario,string senha)
        {
            bool usuarioAuth = funcionario.Autenticar(senha);

            if (usuarioAuth)
            {
                Console.WriteLine("Bem vindo!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha errada cavalo!");
                return false;
            }
        }
    }
}
