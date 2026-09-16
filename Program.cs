using Uppgifter;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gör två instanser av CarClass dessa är objekt av klassen CarClass
            //CarClass car1 = new CarClass();
            // CarClass car2 = new CarClass();

            //Sätter attributer för car1 objektet
            // car1.brand = "Toyota";
            // car1.model = "Camry";
            // car1.year = 2020;

            //Sätter attributer för car2 objektet
            // car2.brand = "Honda";
            // car2.model = "Civic";
            // car2.year = 2021;

            //Skriver ut information om car1 och car2 objektet
            // car1.PrintCarInfo();
            // car2.PrintCarInfo();

            //Gör en instans av BankAccount klassen och skapar ett objekt av klassen BankAccount
            BankAccount account = new BankAccount();

            //Använder metoderna Deposit och Withdraw för att ändra saldot på kontot
            account.Deposit(1000);
            account.Withdraw(200);
        }
    }
}
