using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab02
{
    internal class BankAccount
    {
        decimal balance;

        public decimal Saldo
        {
            get => balance;
        }

        public string Wlasciciel { get; }

        public BankAccount(string clientName, decimal startBalance)
        {
            Wlasciciel = clientName;
            balance = startBalance;
        }

        public void Wplata(decimal kwota)
        {
            if (kwota > 0) { balance += kwota; }
            else if (kwota == 0) { Console.WriteLine("Nie wykonano transakcji, podana kwota była równa zeru"); }
            else { Console.WriteLine("Aby zmniejszyć saldo konta użyj metody Wypłata()"); }
        }

        public void Wyplata(decimal kwota)
        {
            if (balance < kwota)
            {
                Console.WriteLine("Saldo konta jest zbyt niskie aby wykonać transakcję");
            }
            else
            {
                balance -= kwota;
            }
        }
    }

}
