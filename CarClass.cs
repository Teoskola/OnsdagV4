using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class CarClass
    {
        public string brand;
        public string model;
        public int year;

        public void PrintCarInfo()
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}");
        }


    }



}
