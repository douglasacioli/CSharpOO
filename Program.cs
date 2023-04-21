using Contas;

var conta = new Conta();
conta.Numero = "1";
conta.DataAbertura = DateTime.Today;
conta.Saldo = 100;

System.Console.WriteLine(conta.ExibirExtrato());
conta.Depositar(50);
System.Console.WriteLine(conta.ExibirExtrato());
conta.Sacar(100);
System.Console.WriteLine(conta.ExibirExtrato());