using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter //Lägger alla uppgifter under namespace Uppgifter så att de kan användas i Program.cs
{
    public class Circle: Shape
    {
        //ATTRIBUTER


        //METODER
        public override void GetArea() //metod som beräknar area av en cirkel
        {
            Console.WriteLine($"Beräknar area av en cirkel...");
        }

    }
}
