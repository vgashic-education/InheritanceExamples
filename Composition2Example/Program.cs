using System;
using System.Text;

namespace Composition2Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animalsList = new StringBuilder();
            foreach (var item in Enum.GetValues(typeof(Species)))
            {
                animalsList.AppendLine($"{(int)item}. {item}");
            }

            Console.WriteLine($"Select animal number from list:\n{animalsList}\n\n>");

            if (!Int32.TryParse(Console.ReadLine(), out int animalId))
            {
                Console.WriteLine("Invalid selection");
                return;
            }

            var animal = AnimalFactory.Get((Species)animalId);

            Console.WriteLine($"{animal.Species}");
            foreach (var item in animal.Actions)
            {
                Console.WriteLine(item);
            }
        }
    }
}
