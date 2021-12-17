using System;
using System.Collections.Generic;

namespace Composition2Example
{
    public static class AnimalFactory
    {
        public static Animal Get(Species species)
        {
            var actions = new HashSet<Actions>();

            switch (species)
            {
                case Species.Dog:
                    actions.Add(Actions.Walks);
                    break;
                case Species.Penguin:
                    actions.Add(Actions.Walks);
                    actions.Add(Actions.Swims);
                    break;
                case Species.Eagle:
                    actions.Add(Actions.Flies);
                    break;
                case Species.Duck:
                    actions.Add(Actions.Flies);
                    actions.Add(Actions.Swims);
                    break;
                case Species.Shark:
                    actions.Add(Actions.Swims);   
                    break;
                default:
                    throw new ArgumentException();
            }

            return new Animal(species, actions);
        }
    }
}
