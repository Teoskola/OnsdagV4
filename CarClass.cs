using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter //Lägger alla uppgifter under namespace Uppgifter så att de kan användas i Program.cs
{
    public class CarClass 
    {
        //Attributer
        //sätter typ av bilar attributer/variabler för bilarna
        public string brand;
        public string model;
        public int year;

        //Metoder
        public void PrintCarInfo() //metod som skriver ut information om bilen
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}");
        }


    }



}
