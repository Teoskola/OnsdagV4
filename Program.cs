using Cars;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CarClass car1 = new CarClass();
            CarClass car2 = new CarClass();
            car1.brand = "Toyota";
            car1.model = "Camry";
            car1.year = 2020;
            car2.brand = "Honda";
            car2.model = "Civic";
            car2.year = 2021;

            car1.PrintCarInfo();
            car2.PrintCarInfo();

        }
    }
}
