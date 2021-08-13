using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cliente
    {
        private readonly string _nome;
        private readonly int _cpf;
        private string _profission;

        public string Nome { get; }
        public int CPF { get; }
        public string Profission { get; private set; }

        public Cliente(string nome, int cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
    }
}
