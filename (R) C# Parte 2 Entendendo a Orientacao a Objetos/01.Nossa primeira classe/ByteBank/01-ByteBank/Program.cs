using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 1399;
            contaDaGabriela.numero = 55627;
            contaDaGabriela.saldo = 100;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine(contaDaGabriela.agencia);
            Console.WriteLine(contaDaGabriela.numero);
            Console.WriteLine(contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine(contaDaGabriela.saldo);


            Console.ReadLine();
        }
    }
}
