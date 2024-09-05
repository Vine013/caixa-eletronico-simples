
// See https://aka.ms/new-console-template for more information
using Aula03OOExemplo;

Console.WriteLine("Aula 03 OO - Exemplo");

//Instanciar um objeto do tipo ContaBancaria - fazer declaração do objeto, colocar um igual a 1000 e fazer a construção do objeto
ContaBancaria objCB1 = new ContaBancaria();

//Atribuir valores para as propriedades do objeto
objCB1.Numero = 123456;
objCB1.Tipo = "Conta Corrente";
objCB1.NomeCliente = "João da Silva";
objCB1.LimiteCredito = 10000;

//Depositar dinheiro na COnta1
objCB1.Depositar(150);
objCB1.Depositar(678);
objCB1.Depositar(432.65m);
objCB1.Depositar(129);

//Chamar o método ImprimirDados do objCB1
//objCB1.ImprimirDados();

//Criar objCB2
ContaBancaria objCB2 = new ContaBancaria();

objCB2.Numero = 7891011;
objCB2.Tipo = "Conta Poupança";
objCB2.NomeCliente = "Marisa Souza";
objCB2.LimiteCredito = 20000;

objCB2.Depositar(789);
objCB2.Depositar(1000.01m);
objCB2.Depositar(7560);

objCB2.Sacar(349.01m);

//objCB2.ImprimirDados();



//Programa de Caixa Eletrônico

ContaBancaria objCB3 = new ContaBancaria();

objCB2.Numero = 101010;
objCB2.Tipo = "Conta Corrente";
objCB2.NomeCliente = "Vinicin Malvadeza";
objCB2.LimiteCredito = 5000;

int opcao = 0;

do
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Imprimir Dados");
    Console.WriteLine("4 - Sair");

    opcao = Convert.ToInt32(Console.ReadLine());

    switch(opcao)
    {
        case 1:
            Console.WriteLine("Digite o valor a depositar: ");
            decimal vlDeposito = Convert.ToDecimal(Console.ReadLine());
            objCB3.Depositar(vlDeposito);
            break;
        case 2:
            Console.WriteLine("Digite o valor de saque: ");
            decimal vlSaque = Convert.ToDecimal(Console.ReadLine());
            objCB3.Sacar(vlSaque);
            break;
        case 3:
            objCB3.ImprimirDados();
            break;
    }

    Console.WriteLine("Aperte qualquer tecla para continuar....");
    Console.ReadKey();
    Console.Clear();

} while (opcao != 0);


