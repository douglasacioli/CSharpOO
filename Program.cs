using Contas;

var conta = new Conta();
conta.Numero = "1";
conta.DataAbertura = DateTime.Today;
conta.Saldo = 100;

System.Console.WriteLine(Conta.TaxaRendimento);
System.Console.WriteLine(Conta.CalcularRendimento(200,12));
