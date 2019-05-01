using UnityEngine;

namespace Factory
{
    public enum eProduct
    {
        NONE = -1,
        A,
        B,
        C,
    }

    public class Product
    {
        public eProduct productType = eProduct.NONE;

        public virtual void GetInstanceType()
        {
            Debug.LogFormat("ProductType이 {0} 입니다.", productType);
        }
    }
}
