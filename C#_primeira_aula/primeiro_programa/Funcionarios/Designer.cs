﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_programa.Funcionarios
{
    class Designer:Funcionarios
    {
        public Designer(double cpf) : base(3000, cpf)
        {

        }

        public override void aumentarSalario()
        {
            Salario *= 1.11;
        }
        public override double bonificacao()
        {
            return Salario * 0.17;
        }
    }
}