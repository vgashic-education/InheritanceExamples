namespace CompositionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shark = new Shark();
            shark.Swimmable.Swim();
        }
    }
}
