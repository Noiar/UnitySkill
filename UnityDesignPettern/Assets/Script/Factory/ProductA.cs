using UnityEngine;


namespace Factory
{
    public class ProductA : Product
    {
        public ProductA()
        {
            base.productType = eProduct.A;
        }

        public override void GetInstanceType()
        {
            Debug.LogFormat("ProductType이 {0} 입니다.", this.productType);
        }
    }
}
