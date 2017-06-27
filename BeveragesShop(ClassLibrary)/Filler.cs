using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class Filler :Product {

     
        //  public  List<string> products;
        public static List<Product> products = new List<Product>();
   
        public static void AddSetOfProduct() {
      
            products.Add(new Product() { ProductName = "Sandora juice", Description = "Apple nectar", ProductType= "Juice", CurrentPrice=12 });
            products.Add(new Product() { ProductName = "Rich juice", Description = "Apple nectar", ProductType = "Juice", CurrentPrice = 16 });
            products.Add(new Product() { ProductName = "Sadochok juice", Description = "Apple nectar", ProductType = "Juice", CurrentPrice = 11 });
            products.Add(new Product() { ProductName = "Happy Day juice", Description = "Apple nectar", ProductType = "Juice", CurrentPrice = 32 });

            products.Add(new Product() { ProductName = "Morshinska", Description = "Min water , sparkling", ProductType = "Mineral water", CurrentPrice = 19 });
            products.Add(new Product() { ProductName = "Morshinska", Description = "Non sparkling", ProductType = "Mineral water", CurrentPrice = 16 });
            products.Add(new Product() { ProductName = "Mirgorodska", Description = "Sparkling", ProductType = "Mineral water", CurrentPrice = 31 });
            products.Add(new Product() { ProductName = "Borjomi", Description = "Sparkling", ProductType = "Mineral water", CurrentPrice = 42 });

            products.Add(new Product() { ProductName = "Pepsi", Description = "with lemon", ProductType = "Soft drink", CurrentPrice = 14 });
            products.Add(new Product() { ProductName = "Sprite", Description = "classic", ProductType = "Soft drink", CurrentPrice = 19 });
            products.Add(new Product() { ProductName = "Fanta", Description = "with lemon", ProductType = "Soft drink", CurrentPrice = 21 });
            products.Add(new Product() { ProductName = "Cola", Description = "cherry", ProductType = "Soft drink", CurrentPrice = 32 });

          


        }

        public static Product GetRowFromList(int itemIx) {

            Product  item = products[ itemIx];
                    
            return item;

        }
        public static void DeleteRowFromList(int itemIx) {


            Product item = products[itemIx];
            products.RemoveRange(itemIx,1);
            

        }
    }

}





