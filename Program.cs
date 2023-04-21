using Contas;

var conta = new Conta();
conta.Numero = "1";
conta.DataAbertura = DateTime.Today;
conta.Saldo = 0;
System.Console.WriteLine(conta.Numero);
System.Console.WriteLine(conta.DataAbertura);
System.Console.WriteLine(conta.Saldo);
