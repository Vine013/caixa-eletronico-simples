using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03OOExemplo
{
    public class ContaBancaria
    {
        public int Numero { get; set; }

        public string Tipo { get; set; }

        public string NomeCliente { get; set; }

        public decimal LimiteCredito { get; set; }
        private decimal Saldo;


        public void ImprimirDados()
        {
            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Dados da Conta Bancária");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Número da conta: {Numero}");
            Console.WriteLine($"Tipo da Conta: {Tipo}");
            Console.WriteLine($"Nome do Cliente: {NomeCliente}");
            Console.WriteLine($"Limite de Crédito: {LimiteCredito:c}"); //:c - converte para moeda
            Console.WriteLine($"Saldo: {Saldo:c}");
            Console.WriteLine("==================================");
        }

        //Criando um metodo de deposito para acumular na conta bancária
        public void Depositar(decimal valorDeposito)
        {
            Saldo += valorDeposito;
        }

        //Criando um metodo de sacar

        public void Sacar(decimal valorSaque)
        {
            if (valorSaque > Saldo)
            {
                Console.WriteLine("Não há saldo suficiente para o saque");
            }
            else
            {
                Saldo -= valorSaque;
            }
        }

    }
}
