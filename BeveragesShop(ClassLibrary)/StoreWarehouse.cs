using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class StoreWarehouse : ISearchProduct {
        public Dictionary<string, string> productType = new Dictionary<string, string>();
        public List<Juice> juiceList = new List<Juice>();
        public Queue<Juice> jj = new Queue<Juice>();
    
        public List<SoftDrink> softdrink = new List<SoftDrink>();
        public List<MineralWater> minwater = new List<MineralWater>();
        Product product = new Product();
        public StoreWarehouse() {


        

        // string d= conv.GetEnumerator();
       // conv.Push (juice);
        //    string typeOfProduct = "";
       // Console.WriteLine ( conv.Pull());
       //     foreach (var type in productType.Keys) {
       //         typeOfProduct += type;
           }
       

        public string CreateProduct(string typeOfProduct) {
            UserLog.Log("Function CREATE warehouse item called; ");
          
            string newproduct = "";
            string tradeMark = "";
            string productName = "";
            StoreWarehouse warehouse = new StoreWarehouse();
            int currentPrice = 22;
            switch (typeOfProduct) {
                case "SoftDrink":
                string softdrinkName = "NewlyAddedOrange";
                tradeMark = "UdatedCola";
                productName = "CreatedCoCaCoLa";
                softdrink.Add(new SoftDrink() { SoftDrinkName = softdrinkName, TradeMark = tradeMark, ProductName = productName, ProductType = typeOfProduct, CurrentPrice = currentPrice });
                break;

                case "Juice":

                string juiceName = "NewlyAddedOrange";
                tradeMark = "AddedRich";
                productName = "CreatedRich Juice";
                juiceList.Add(new Juice() { JuiceName = juiceName, TradeMark = tradeMark, ProductName = productName, ProductType = typeOfProduct, CurrentPrice = currentPrice });
                foreach (var juiceitem in juiceList)
                    Console.WriteLine(juiceitem);
                break;

                case "Mineral Water":
                minwater.Add(new MineralWater() { });
                string MinWaterName = "NewlyAddedSparkling";
                tradeMark = "UdatedMorshinska";
                productName = "CreatedMINMorshinska";
                minwater.Add(new MineralWater() { MinWaterName = MinWaterName, TradeMark = tradeMark, ProductName = productName, ProductType = typeOfProduct, CurrentPrice = currentPrice });
                break;
            }
            return newproduct;

        }
        public string ReadProduct(string typeOfProduct) {
            UserLog.Log("Function READ warehouse item called; ");
            string productinfo = "";
            List<Juice> resultsJ = juiceList.FindAll(s => s.ProductType.Equals(typeOfProduct));
            List<SoftDrink> resultsS = softdrink.FindAll(s => s.ProductType.Equals(typeOfProduct));
            List<MineralWater> resultsM = minwater.FindAll(s => s.ProductType.Equals(typeOfProduct));
            if (resultsJ.Count != 0) {
                foreach (var findProduct in resultsJ) { Console.WriteLine(findProduct); }
            } else if (resultsS.Count != 0) {
                foreach (var findProduct in resultsS) { Console.WriteLine(findProduct); }
            } else if (resultsM.Count != 0) {
                foreach (var findProduct in resultsM) { Console.WriteLine(findProduct); }
            } else
                Console.WriteLine("\nNo requested to read product found.");

            return productinfo;
        }
        public string UpdateProduct(string typeOfProduct, string productName) {
            UserLog.Log("Function UPDATE warehouse item called; ");
            string updatedproduct = "";
            switch (typeOfProduct) {
                case "Soft Drink":
                var softDrinkToUpdate = softdrink.Where(s => s.SoftDrinkName == productName).FirstOrDefault();
                if (softDrinkToUpdate != null) { softDrinkToUpdate.SoftDrinkName = "some value"; }
                Console.WriteLine(softDrinkToUpdate);
                break;

                case "Juice":
                var juiceToUpdate = juiceList.Where(j => j.JuiceName == productName).FirstOrDefault();
                if (juiceToUpdate != null) { juiceToUpdate.JuiceName = "some value"; }
                Console.WriteLine(juiceToUpdate);
                break;

                case "Mineral Water":
                var minwaterToUpdate = minwater.Where(m => m.MinWaterName == productName).FirstOrDefault();
                if (minwaterToUpdate != null) { minwaterToUpdate.MinWaterName = "some value"; }
                Console.WriteLine(minwaterToUpdate);
                break;
            }
            return updatedproduct;

        }
        public string DeleteProduct(string typeOfProduct, string productName) {
            UserLog.Log("Function DELETE warehouse item called; ");
            string newproductList = "";
            switch (typeOfProduct) {
                case "Soft Drink":
                var removeSDLines = softdrink.FindAll(s => s.SoftDrinkName.Equals(productName));
                Console.WriteLine("Lines to be removed:");
                foreach (var remove in removeSDLines) {
                    Console.WriteLine(remove);
                    softdrink.Remove(remove);
                }
                Console.WriteLine("Lines in collection after delete:");
                foreach (var softdrinkitem in softdrink)
                    Console.WriteLine(softdrinkitem);
                break;

                case "Juice":
                var removeJLines = juiceList.FindAll(j => j.JuiceName.Equals(productName));
                Console.WriteLine("Lines to be removed:");
                foreach (var remove in removeJLines) {
                    Console.WriteLine(remove);
                    juiceList.Remove(remove);
                }
                Console.WriteLine("Lines in collection after delete:");
                foreach (var juiceitem in juiceList)
                    Console.WriteLine(juiceitem);
                break;

                case "Mineral Water":
                var removeLines = minwater.FindAll(m => m.MinWaterName.Equals(productName));
                Console.WriteLine("Lines to be removed:");
                foreach (var remove in removeLines) {
                    Console.WriteLine(remove);
                    minwater.Remove(remove);
                }
                Console.WriteLine("Lines in collection after delete:");
                foreach (var minwateritem in minwater)
                    Console.WriteLine(minwateritem);
                break;
            }
            return newproductList;

        }


        public void AllProductsAdd() {


            productType.Add("J", "Juice");
            productType.Add("S", "Soft Drink");
            productType.Add("M", "Mineral Water");


            juiceList.Add(new Juice() { JuiceName = "Apple", TradeMark = "Rich", ProductName = "Rich Juice", ProductType = "Juice", CurrentPrice = 22 });
            juiceList.Add(new Juice() { JuiceName = "Orange", TradeMark = "Rich", ProductName = "Rich Juice", ProductType = "Juice", CurrentPrice = 22 });
            juiceList.Add(new Juice() { JuiceName = "Multivitamin", TradeMark = "Rich", ProductName = "Rich Juice", ProductType = "Juice", CurrentPrice = 22 });
            juiceList.Add(new Juice() { JuiceName = "Tomate", TradeMark = "Rich", ProductName = "Rich Juice", ProductType = "Juice", CurrentPrice = 22 });
            juiceList.Add(new Juice() { JuiceName = "Apple", TradeMark = "Rich", ProductName = "Rich Juice", ProductType = "Juice", CurrentPrice = 22 });


            minwater.Add(new MineralWater() { MinWaterName = "Mirgorodska light", TradeMark = "Mirgorodska", ProductName = "Mineral water", ProductType = "Mineral Water", CurrentPrice = 22 });
            minwater.Add(new MineralWater() { MinWaterName = "Mirgorodska strong", TradeMark = "Mirgorodska", ProductName = "Mineral water", ProductType = "Mineral Water", CurrentPrice = 22 });
            minwater.Add(new MineralWater() { MinWaterName = "Morshinska sparkling", TradeMark = "Morshinska", ProductName = "Mineral water", ProductType = "Mineral Water", CurrentPrice = 22 });
            minwater.Add(new MineralWater() { MinWaterName = "Morshinska natural", TradeMark = "Morshinska", ProductName = "Mineral water", ProductType = "Mineral Water", CurrentPrice = 22 });
            minwater.Add(new MineralWater() { MinWaterName = "Borjomi", TradeMark = "Borjomi", ProductName = "Mineral water", ProductType = "Mineral Water", CurrentPrice = 22 });


            softdrink.Add(new SoftDrink() { SoftDrinkName = "Cola", TradeMark = "CocaCola", ProductType = "Soft Drink", ProductName = "Sparkling sweet water", CurrentPrice = 22 });
            softdrink.Add(new SoftDrink() { SoftDrinkName = "Fanta", TradeMark = "CocaCola", ProductType = "Soft Drink", ProductName = "Sparkling sweet water", CurrentPrice = 22 });
            softdrink.Add(new SoftDrink() { SoftDrinkName = "Cola cherry", TradeMark = "CocaCola", ProductType = "Soft Drink", ProductName = "Sparkling sweet water", CurrentPrice = 22 });
            softdrink.Add(new SoftDrink() { SoftDrinkName = "Pepsi", TradeMark = "Pepsi", ProductType = "Soft Drink", ProductName = "Sparkling sweet water", CurrentPrice = 22 });
            softdrink.Add(new SoftDrink() { SoftDrinkName = "Lemon pepsi", TradeMark = "Pepsi", ProductType = "Soft Drink", ProductName = "Sparkling sweet water", CurrentPrice = 22 });
            softdrink.Add(new SoftDrink() { SoftDrinkName = "Cola", TradeMark = "Biola", ProductType = "Soft Drink", ProductName = "Sparkling sweet water", CurrentPrice = 22 });
            softdrink.Add(new SoftDrink() { SoftDrinkName = "Limonade", TradeMark = "Biola", ProductType = "Soft Drink", ProductName = "Sparkling sweet water", CurrentPrice = 22 });
        }

        public string SearchToFindJuiceInfo(string juice) {
            UserLog.Log("Function SEARCH warehouse item called; ");
            string findinfo = "";
            List<Juice> getinfo = juiceList.FindAll(j => j.JuiceName.Equals(juice));
            Juice[] productinfo = getinfo.ToArray();

            DisplayProductInfo(productinfo);
            return findinfo;
        }

        public string SearchToFindSoftDrinkInfo(string softDrink) {

            UserLog.Log("Function SEARCH warehouse item called; ");
            string findinfo = "";

            List<SoftDrink> getinfo = softdrink.FindAll(s => s.SoftDrinkName.Equals(softDrink));
            SoftDrink[] productinfo = getinfo.ToArray();

            DisplayProductInfo(productinfo);
            return findinfo;
        }

        public string SearchToFidMineralWaterInfo(string mineralWater) {
            UserLog.Log("Function SEARCH warehouse item called; ");
            string findinfo = "";
            List<MineralWater> getinfo = minwater.FindAll(m => m.TradeMark.Equals(mineralWater));
            MineralWater[] productinfo = getinfo.ToArray();

            DisplayProductInfo(productinfo);
            return findinfo;
        }

        public void DisplayProductInfo(Product[] productList) {
            Console.WriteLine("You were looking for: ");
            foreach (var product in productList)
                Console.WriteLine(product);


        }
        public void ProcessConveyor() {
            UserLog.Log("Function QUEUE item called; ");
            var conv = new Conveyor<Juice>();
            Juice juice = new Juice();
             string[] name = { "A", "B", "C", "D", "E", "F", "J" };
            string[] tr = { "TradeMark1", "TradeMark2", "TradeMark3", "TradeMark4", "TradeMark5", "TradeMark6", "TradeMark7", "TradeMark8" };
            string[] productname = { "Product1", "Product2", "Product3", "Product4", "Product5", "Product6", "Product7", "Product8" };
            string[] juicename = { "juice1", "juice2", "juice3", "juice3", "juice4", "juice5", "juice6", "juice7" };
            Console.WriteLine("Conveyor data PUSH: ");
            for (int i = 0; i < 6; i++) {
             juice = new Juice(name[i], tr[i], productname[i]);
                conv.Push(juice);
                Console.WriteLine(juice);
            }
                  
        Console.WriteLine ("Conveyor data PULL: ");

            while (!conv.IsEmpty) {

                Console.WriteLine(conv.Pull());
            }
        }
        // Conveyor(Queue<Juice> );

    }

}
