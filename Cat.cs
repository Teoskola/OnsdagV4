using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgifter //Lägger alla uppgifter under namespace Uppgifter så att de kan användas i Program.cs
{
    public class Cat: Animal
    {
        //METODER
        public override void MakeSound() //implementerar den abstrakta metoden från Animal-klassen
        {
            Console.WriteLine("Meow!");
        }
    }
}
