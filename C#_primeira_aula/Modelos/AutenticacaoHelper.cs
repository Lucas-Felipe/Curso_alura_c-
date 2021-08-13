using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class AutenticacaoHelper
    {
        public bool compararSenha(string senhaVerdadeira,string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
