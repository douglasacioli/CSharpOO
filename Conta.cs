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

        public void ExibirExtrato()
        {
            System.Console.WriteLine($"Conta n°:  {Numero}");
            System.Console.WriteLine($"Data de Abertura:  {DataAbertura.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Saldo:  {Saldo.ToString("c")}");
        }
    }
}