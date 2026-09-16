using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter //Lägger alla uppgifter under namespace Uppgifter så att de kan användas i Program.cs
{
    internal class BankAccount
    {
        //Attributer

        private double balance; //privat kontobalans

        //Metoder
        public void Deposit(double amount)
        {
            balance = balance + amount; //lägger till beloppet till kontobalansen
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");


        }

        public void Withdraw(double amount)
        {
        }
}
