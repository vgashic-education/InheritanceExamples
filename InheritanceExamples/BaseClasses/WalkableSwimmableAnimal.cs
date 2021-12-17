using System;

namespace InheritanceExamples
{
    public class WalkableSwimmableAnimal : WalkableAnimal
    {
        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }
}
