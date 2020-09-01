using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Fernando");
            p.Endereco = "Rua 1";
            p.Telefone = "123456789";
            Console.WriteLine("Nome=" + p.Nome + "\nEndereço=" + p.Endereco + "\nTelefone=" + p.Telefone);
            Console.ReadLine();
        }
    }
}
