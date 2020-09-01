using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaConta
{
    abstract class Conta
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }

        public virtual void Rendimento()
        {

        }
    }

}
