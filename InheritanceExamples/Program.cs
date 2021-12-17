namespace InheritanceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Walk();

            var shark = new Shark();
            shark.Sleep();
            shark.Swim();

            var penguin = new Penguin();
            penguin.Walk();
            penguin.Swim();

            var duck = new Duck();
            duck.Walk();
            duck.Swim();
            duck.Fly();
        }
    }
}
