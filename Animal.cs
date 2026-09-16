using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter //Lägger alla uppgifter under namespace Uppgifter så att de kan användas i Program.cs
{
    public abstract class Animal
    {

        //ATTRIBUTER
       

        //METODER
        public abstract void MakeSound(); //abstrakt metod som ska implementeras i subklasserna
    }
}
