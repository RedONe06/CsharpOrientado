using bytebank; //namespace da classe;
using bytebank.Titular;

Console.WriteLine("Boas vindas ao ByteBank!");

Cliente cliente = new Cliente();
ContaCorrente conta = new ContaCorrente();
conta.Saldo = -10;
Console.WriteLine(conta.Saldo);


//cliente.nome = "Andre Silva";
//cliente.CPF = "10253541263";
//cliente.profissao = "Programador C#";

//ContaCorrente conta1 = new ContaCorrente();

//conta1.cliente = cliente;
//conta1.conta = "10123-x";
//conta1.numeroAgencia = 23;
//conta1.nomeAgencia = "Agência Central";
//conta1.saldo = 100.0;

//Console.WriteLine($"Nome do cliente: {conta1.cliente.nome}");

//ContaCorrente conta2 = new ContaCorrente();

//conta2.titular = "Amanda Nogueira";
//conta2.conta = "10106-X";
//conta2.numeroAgencia = 321;
//conta2.nomeAgencia = "Agência Central";
//conta2.saldo = 100;

//Console.WriteLine($"Saldo da Amanda: {String.Format("{0:0.00}", conta2.saldo)}");
//bool saque = conta2.sacar(50);
//Console.WriteLine($"Saque realizado: {saque}");

//Console.WriteLine($"Saldo da Amanda: {String.Format("{0:0.00}", conta2.saldo)}");
//bool deposito = conta2.depositar(100);
//Console.WriteLine($"Depósito realizado: {deposito}");

//Console.WriteLine($"Saldo da Amanda: {String.Format("{0:0.00}", conta2.saldo)}");
//Console.WriteLine($"Saldo da Andriele: {String.Format("{0:0.00}", conta1.saldo)}");
//bool transferencia = conta2.transferir(30, conta1);
//Console.WriteLine($"Transferência realizada: {transferencia}");

//Console.WriteLine($"Saldo da Amanda: {String.Format("{0:0.00}", conta2.saldo)}");
//Console.WriteLine($"Saldo da Andriele: {String.Format("{0:0.00}", conta1.saldo)}");
//Console.WriteLine(conta1.informacoesDaConta());

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Nome da agência: " + conta1.nomeAgencia);
//Console.WriteLine("Número da agência: " + conta1.numeroAgencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

//Console.WriteLine(" ");

//Console.WriteLine($"Titular da conta: {conta2.titular}");
//Console.WriteLine($"Número da conta: {conta2.conta}");
//Console.WriteLine($"Agência: {conta2.numeroAgencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta2.saldo)}");

//ctrl k + ctrl c comenta o código
//ctrl k + ctrl u para descomentar
//cw tab tab para console write

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Nome da agência: " + conta1.nomeAgencia);
//Console.WriteLine("Número da agência: " + conta1.numeroAgencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

Console.ReadKey();