using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contas
{
    public class Conta
    {
        public string? Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public Decimal Saldo { get; set; }

        public void ExibirExtrato() //metodo sem parametro
        {
            System.Console.WriteLine($"Conta n°:  {Numero}");
            System.Console.WriteLine($"Data de Abertura:  {DataAbertura.ToString("dd/MM/yyyy")}"); //formata data
            System.Console.WriteLine($"Saldo:  {Saldo.ToString("c")}"); //formata valor
            System.Console.WriteLine("-----------------------------------------------------");
        }

        public void Depositar(decimal valor) //adiciona valor ao saldo
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor) //subtrai valor do saldo 
        {
            Saldo -= valor;
        }
    }
}