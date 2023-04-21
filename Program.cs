using Contas;

var conta = new Conta();
conta.Numero = "1";
conta.DataAbertura = DateTime.Today;
conta.Saldo = 100;

conta.ExibirExtrato();
conta.Depositar(50);
conta.ExibirExtrato();
conta.Sacar(100);
conta.ExibirExtrato();