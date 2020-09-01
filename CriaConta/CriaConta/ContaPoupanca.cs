using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaConta
{
    class ContaPoupanca: Conta, IImposto
    {
        public override void Rendimento()
        {
            
            this.saldo = saldo * 0.05;
        }
        public double calcularImposto()
        {
            this.saldo = saldo * 0.25;
        }
    }
}
