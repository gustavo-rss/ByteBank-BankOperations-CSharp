using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente()
            //{
            //    nome = "Gabriela",
            //    profissao = "Desenvolvedora C#",
            //    cpf = "434.562.878-20"
            //};

            ContaCorrente conta = new ContaCorrente()
            {
               // titular = gabriela,
                saldo = 500,
                agencia = 563,
                numero = 5634527
            };

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "434.562.878-20";
            conta.titular.profissao = "Desenvolvedora C#";

                

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
            
        }
    }
}
