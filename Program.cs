using Contas;

var conta = new Conta();
conta.Numero = "1";
conta.DataAbertura = DateTime.Today;
conta.Saldo = 100;

conta.RealizarEmprestimo(200, 4);
System.Console.WriteLine(conta.ExibirExtrato());
