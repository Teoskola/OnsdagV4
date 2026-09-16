using System;
using System.Collections.Generic;
using System;


namespace Uppgifter //Lägger alla uppgifter under namespace Uppgifter så att de kan användas i Program.cs
{
    internal class Student : Person
    {
        //ATTRIBUTER
        public int StudentId { get; set; }

        //METODER

        public void printStudentInfo() //metod som skriver ut information om studenten
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentId}");
        }



    }



}


