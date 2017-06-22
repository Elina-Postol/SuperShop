using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class GetInfoAboutProduct : Product {

        public string  Read(string productType) {
          
            string selectedData = "";
            if (String.IsNullOrEmpty(productType)) { throw new ArgumentException("Product Type can't be null or empty."); }
            
            // Filler.AddSetOfProduct();
         
            foreach (Product product in Filler.products) {
            if (product.ProductType == productType)
                    // selectedList.AddRange(new Product() { ProductName = product.ProductName, Description = product.Description, ProductType = product.ProductType, CurrentPrice = product.CurrentPrice });
                   selectedData += (product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice + System.Environment.NewLine);
             }   
            return selectedData;
          }   

       
    }
}
