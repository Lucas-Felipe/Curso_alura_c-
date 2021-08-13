using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2_excecoes
{
    public class ExecptionSaque:Exception
    {
        public ExecptionSaque()
        {
            Console.WriteLine("\nsaldo insuficiente!");
        }
    }
}
