using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta cc = new ContaCorrente();
            cc.numero = 1;
            cc.titular = "João";
            cc.saldo = 100;

            Conta cp = new ContaPoupanca();
            cp.numero = 2;
            cp.titular = "Maria";
            cp.saldo = 200;

            Console.WriteLine("Conta=" + cc.numero + "\nTitular=" + cc.titular + "\nSaldo=" + cc.saldo);
            cc.Rendimento();
            Console.WriteLine("Rendimento="+cc.saldo);
            Console.WriteLine("Conta=" + cp.numero + "\nTitular=" + cp.titular + "\nSaldo=" + cp.saldo);
            cp.Rendimento();
            Console.WriteLine("Rendimento="+cp.saldo);
            Console.ReadLine();
        }
    }
}
