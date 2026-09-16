using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter //Lägger alla uppgifter under namespace Uppgifter så att de kan användas i Program.cs
{
    public class Shape
    {
        //ATTRIBUTER


        //METODER
        public virtual void GetArea() //metod som beräknar area av en rektangel
        {
            Console.WriteLine($"Beräknar area...");
        }



    }
}
