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

        public string ExibirExtrato() //metodo sem parametro
        { //{Environment.NewLine} serve para quebrar as linhas
            return $"Conta n°:  {Numero}{Environment.NewLine}" +
                   $"Data de Abertura:  {DataAbertura.ToString("dd/MM/yyyy")}{Environment.NewLine}" + //formata data
                   $"Saldo:  {Saldo.ToString("c")}{Environment.NewLine}" + //formata valor
                   "-----------------------------------------------------";
                ;
        }

        public void Depositar(decimal valor) //adiciona valor ao saldo
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor) //subtrai valor do saldo 
        {
            Saldo -= valor;
        }

        public void RealizarEmprestimo(decimal valor)
        {
            Saldo += valor;
            System.Console.WriteLine($"O valor {valor} foi creditado e será debitado em 30 dias.");
        }

        public void RealizarEmprestimo (decimal valor, int parcelas)
        {
            Saldo += valor;
            System.Console.WriteLine($"O valor {valor} foi creditado e será debitado em {parcelas} vezes.");
        }
    }
}