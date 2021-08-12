using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa
{
    public class ParceiroComercial:Sistemas.IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
