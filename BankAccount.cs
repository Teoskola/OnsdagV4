using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter //Lägger alla uppgifter under namespace Uppgifter så att de kan användas i Program.cs
{
    internal class BankAccount
    {
        //Attributer

        private double balance; //privat kontobalans

        //Konstruktör
        public BankAccount() //konstruktor som sätter initialt värde på kontobalansen
        {
            balance = 0; //sätter initialt värde på kontobalansen till 0
        }

        //Metoder
        public void Deposit(double amount)
        {
            balance = balance + amount; //lägger till beloppet till kontobalansen
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");


        }

        public void Withdraw(double amount)
        {
            balance = balance - amount; //drar av beloppet från kontobalansen
            Console.WriteLine($"Withdrew: {amount}, New Balance: {balance}");
        }

    }
}
