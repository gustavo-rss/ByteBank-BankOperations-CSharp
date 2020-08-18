using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            Console.WriteLine($"Saldo: {contaDoBruno.saldo}");

            bool resultadoSaque = contaDoBruno.Sacar(50);

            contaDoBruno.Sacar(50);
            Console.WriteLine($"Saldo: {contaDoBruno.saldo}");
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            bool resultadoTransferencia = contaDoBruno.Transferir(100, contaDaGabriela);

            Console.WriteLine($"Saldo do Bruno: {contaDoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela: {contaDaGabriela.saldo}");
            Console.WriteLine(resultadoTransferencia);

            contaDaGabriela.Transferir(50, contaDoBruno);
            Console.WriteLine($"Saldo do Bruno: {contaDoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela: {contaDaGabriela.saldo}");



            Console.ReadLine();
        }
    }
}
