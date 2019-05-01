using UnityEngine;

namespace Composite
{
    public class CompositeMain : MonoBehaviour
    {
        Composite component1, component2, component3;
        Leaf leaf1, leaf2, leaf3;

        private void Awake()
        {
            this.component1 = new Composite("Root");
            this.component2 = new Composite("Child1");
            this.component3 = new Composite("Child2");

            this.leaf1 = new Leaf("Leaf1");
            this.leaf2 = new Leaf("Leaf2");
            this.leaf3 = new Leaf("Leaf3");

            this.component1.addComponent(component2);
            this.component1.addComponent(leaf1);

            this.component2.addComponent(component3);
            this.component2.addComponent(leaf2);
            this.component2.addComponent(leaf3);

            this.ShowComponent(this.component1);
        }

        private void ShowComponent(Component component)
        {
            if (component is Composite)
            {
                Debug.LogFormat("이 컴포넌트의 이름은 {0}입니다. 그리고 Composite 입니다.", component.Name);
                foreach (var item in ((Composite)component).children)
                {
                    this.ShowComponent(item);
                }
            }
            if (component is Leaf)
            {
                Debug.LogFormat("이 컴포넌트의 이름은 {0}입니다. 그리고 Leaf 입니다.", component.Name);
            }
        }
    }
}
