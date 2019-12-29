using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
    
namespace BankCount {
    class Count {
        public int NumberCount  { get; private set; }
        public double Balance { get; private set; }
        public string Name { get; set; }

        public Count(int numberCount, string name) { //construtor
            NumberCount = numberCount;
            Name = name;
        }

        public Count(int numberCount, string name, double balance) : this(numberCount, name){
            Balance = balance;
        }

        public void DepositoSaldo (double valor){
            Balance += valor;
        }

        public void SaqueSaldo(double valor) {
            Balance -= valor + 5.00;
        }
        public override string ToString() {
            return "Conta " + NumberCount +
                   ", Titular: " + Name + ", Saldo: $ " +
                   Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
