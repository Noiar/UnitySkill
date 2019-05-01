using UnityEngine;

namespace Factory
{
    public class ProductB : Product
    {
        public ProductB()
        {
            base.productType = eProduct.B;
        }

        public override void GetInstanceType()
        {
            Debug.LogFormat("ProductType이 {0} 입니다.", this.productType);
        }
    }
}
