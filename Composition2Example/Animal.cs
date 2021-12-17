using System.Collections.Generic;

namespace Composition2Example
{
    public class Animal
    {
        private Species _species;
        private HashSet<Actions> _actions;

        public Animal(Species species, HashSet<Actions> actions)
        {
            _species = species;
            _actions = actions;
        }

        public Species Species => _species;
        public HashSet<Actions> Actions => _actions;
    }
}
