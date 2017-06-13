using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class Product {

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string Descriprion { get; set; }
        public int CurrentPrice { get; set; }
        public string ProductStorageType { get; set; }
        Product product = new Product();
       
        public Product ProductList() {

            product.ProductId = '1';
            product.Descriprion = "Min water";
            product.ProductType = "MineralWater";
            product.ProductName = "new";
            return product;
        }

    }
}
