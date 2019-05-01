using UnityEngine;

namespace Composite
{
    public class Leaf : Component
    {
        public Object Data { get; set; }

        public Leaf(string Name) : base(Name)
        {
        }
    }
}
