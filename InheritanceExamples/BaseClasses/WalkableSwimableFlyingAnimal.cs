using System;

namespace InheritanceExamples
{
    public class WalkableSwimableFlyingAnimal : WalkableSwimmableAnimal
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
