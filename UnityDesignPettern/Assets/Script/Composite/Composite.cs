using System.Collections.Generic;
using UnityEngine;

namespace Composite
{
    public class Composite : Component
    {
        public List<Component> children;

        public Composite(string Name) : base(Name)
        {
            this.children = new List<Component>();
        }

        public void addComponent(Component component)
        {
            this.children.Add(component);
            Debug.LogFormat("{0} 컴포넌트에 {1}컴포넌트 추가", base.Name, component.Name);
        }

        public void removeComponent(Component component)
        {
            if (this.children.Contains(component))
            {
                this.children.Remove(component);
                Debug.LogFormat("{0} 컴포넌트 제거", component.Name);
            }
        }
    }
}
