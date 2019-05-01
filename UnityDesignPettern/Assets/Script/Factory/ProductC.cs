using UnityEngine;

namespace Factory
{
    public class ProductC : Product
    {
        public ProductC()
        {
            base.productType = eProduct.C;
        }

        public override void GetInstanceType()
        {
            Debug.LogFormat("ProductType이 {0} 입니다.", this.productType);
        }
    }
}
