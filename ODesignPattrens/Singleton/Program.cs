using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var productManager = ProductManager.CreateProductAsSingleton();
            productManager.Update();
        }

        class ProductManager
        {
            private static ProductManager _productManager;
            private ProductManager()
            {

            }

            public static ProductManager CreateProductAsSingleton()
            {
                if (_productManager == null)
                    _productManager = new ProductManager();

                return _productManager;

            }

            public void Update()
            {
                Console.WriteLine("Updated");
                Console.ReadLine();
            }
        }
    }
}
