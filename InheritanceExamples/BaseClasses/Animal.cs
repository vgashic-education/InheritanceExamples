﻿using System;

namespace InheritanceExamples
{
    public class Animal
    {
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("Zzzzzzzzzz");
        }
    }
}
