namespace Factory
{
    public static class Factory
    {
        public static Product GetInstance(eProduct productType)
        {
            Product p = null;

            switch (productType)
            {
                case eProduct.A:
                    {
                        p = new ProductA();
                    }
                    break;

                case eProduct.B:
                    {
                        p = new ProductB();
                    }
                    break;

                case eProduct.C:
                    {
                        p = new ProductC();
                    }
                    break;

                default:
                    {
                        p = new Product();
                    }
                    break;
            }

            return p;
        }
    }
}
