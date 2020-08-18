using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;
            contaDaGabrielaCosta.saldo = 100;


            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idade2 = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade2));

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);

            Console.WriteLine(contaDaGabrielaCosta.saldo);

            if (contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }

            Console.ReadLine();

            //Console.WriteLine($"Titular: {contaDaGabriela.titular}");
            //Console.WriteLine($"Agência: {contaDaGabriela.agencia}");
            //Console.WriteLine($"Número: {contaDaGabriela.numero}");
            //Console.WriteLine($"Saldo: {contaDaGabriela.saldo}");
        }
    }
}
