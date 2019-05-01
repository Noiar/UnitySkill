using UnityEngine;

namespace Factory
{
    public class Main : MonoBehaviour
    {
        public void CreateProductA()
        {
            Product p = Factory.GetInstance(eProduct.A);
            p.GetInstanceType();
        }

        public void CreateProductB()
        {
            Product p = Factory.GetInstance(eProduct.B);
            p.GetInstanceType();
        }

        public void CreateProductC()
        {
            Product p = Factory.GetInstance(eProduct.C);
            p.GetInstanceType();
        }
    }
}
