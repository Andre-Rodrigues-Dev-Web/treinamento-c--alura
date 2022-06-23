// See https://aka.ms/new-console-template for more information
// Importação da classe
using countbank;
// Nome do banco
Console.WriteLine("Banco ALR");

// Utilização da classe
ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Laurentino";
conta1.conta = "10000-x";
conta1.numero_conta = 20;
conta1.nome_agencia = "Agência Bambuí";
conta1.saldo = 100.20; 

// Exibição de informação
Console.WriteLine("Titular:" + conta1.titular);
Console.WriteLine("Conta:" + conta1.conta);
Console.WriteLine("Número agência:" + conta1.numero_conta);
Console.WriteLine("Nome agência:" + conta1.nome_agencia);
Console.WriteLine("Saldo:" + conta1.saldo);

//Exibição de valores 
Console.WriteLine("Saldo de André pré-saque: " + conta1.saldo);
conta1.Sacar(50);
Console.WriteLine("Saldo da André pós-saque: " + conta1.saldo);
// evento que fecha as informações
Console.ReadKey();