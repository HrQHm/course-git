using System;
using System.Globalization;

namespace BankCount {
    class Program {
        static void Main(string[] args) {

            Count countClass;

            Console.WriteLine("Gold Saucer Bank - Welcome!");
            Console.Write("Digite número da conta: "  );
            int numberCount = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string nameCount = Console.ReadLine();
            Console.Write("Haverá Depósito Inicial (s/n)? ");
            char op = char.Parse(Console.ReadLine());

            if (op == 's' || op == 'S') {
                Console.Write("Entre o valor do depósito incial: ");
                double balanceCount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                countClass = new Count(numberCount, nameCount, balanceCount);//carregando variaveis da classe
            }
            else 
                countClass = new Count(numberCount, nameCount);//carregando variaveis da classe
            
            
            
            Console.WriteLine(countClass);
            Console.WriteLine("-----------------------------------------");

            Console.Write("Entre um valor para depósito: ");
            countClass.DepositoSaldo(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(countClass);

            Console.WriteLine("-----------------------------------------");
            Console.Write("Entre um valor para saque: ");
            countClass.SaqueSaldo(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(countClass);
            Console.WriteLine("Teste github");


        }
    }
}
