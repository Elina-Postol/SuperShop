using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class AddOrCreateProduct : Product {

        public string Create(string productName, string productType, string description, string currentPrice) {
            string newrow = " ";
            bool checkIsFail = false;
            if (String.IsNullOrEmpty(productName)) { throw new ArgumentException("Product Name can't be null or empty."); }
            if (String.IsNullOrEmpty(productType)) { throw new ArgumentException("Product type can't be null or empty."); }
            if (String.IsNullOrEmpty(description)) { throw new ArgumentException("Description can't be null or empty."); }
            if (String.IsNullOrEmpty(currentPrice)) { throw new ArgumentException("Price can't be null or empty."); }
          
            if (!EqualsCheck.Validation(productName)) {
                Console.WriteLine("Please input product name: ");
                productName = Console.ReadLine();
                checkIsFail = true;
            }
            
                      if (!EqualsCheck.NumberValidation(currentPrice)) {
                Console.WriteLine("Please input product current price: ");
                currentPrice = Console.ReadLine();
                Create(productName, productType, description, currentPrice);
                checkIsFail = true;
            }

            if (checkIsFail) {
                Create(productName, productType, description, currentPrice);
            }
            productType = Product.TypeFinder(productType);
            int price = int.Parse(currentPrice);
            Filler.products.Add(new Product() { ProductName = productName, Description = description, ProductType = productType, CurrentPrice = price });
            // Filler.AddSetOfProduct();
            foreach (Product product in Filler.products) {
                newrow += (product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice + System.Environment.NewLine);
            }
            return newrow;
        }
    }
}
