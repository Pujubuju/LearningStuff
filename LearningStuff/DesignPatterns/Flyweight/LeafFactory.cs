using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class LeafFactory
    {
        private readonly Dictionary<int, Leaf> _leaves = new Dictionary<int, Leaf>();

        public Leaf GetLeaf(int key)
        {
            Leaf character = null;
            if (_leaves.ContainsKey(key))
            {
                character = _leaves[key];
            }
            else
            {
                switch (key)
                {
                    case 1: 
                        character = new Leaf1(); 
                        break;
                    case 2: 
                        character = new Leaf2(); 
                        break;
                    case 3: 
                        character = new Leaf3(); 
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("");
                }
                _leaves.Add(key, character);
            }
            return character;
        }

    }
}
