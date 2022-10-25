﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 865332;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 865332;

            Console.WriteLine("Igualdade de tipo de referencia = " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeDaGabriela = 27;

            Console.WriteLine("Igualdade de tipo de valor = " + (idade == idadeDaGabriela));

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
        }
    }
}
