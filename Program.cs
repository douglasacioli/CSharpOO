using Contas;

var conta = new Conta();
System.Console.WriteLine(conta.ExibirExtrato());

var conta2 = new Conta("0001", DateTime.Now, 100);
System.Console.WriteLine(conta2.ExibirExtrato());
