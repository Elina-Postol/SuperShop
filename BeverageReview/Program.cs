
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeveragesShop_ClassLibrary_;

namespace BeverageReview {
    class Program {
        public static string clientslist;
        public static string productname = "new";

        static void Main(string[] args) {

            Customer client = new Customer();
            Customer client2 = new Customer();
            Customer client3 = new Customer();

            client.FirstName = "ClientF1";
            client.LastName = "ClientL1";
            var customer = client.FullName;
            client2.FirstName = "ClientF2";
            client2.LastName = "ClientL2";
            var customer2 = client2.FullName;
            client3.FirstName = "ClientF3";
            client3.LastName = "ClientL3";
            var customer3 = client3.FullName;
            clientslist = customer + "," + customer2 + "," + customer3;

            String text = ReportView.ShopTypeDescription;

            Juice juicetoshow = new Juice();
            Juice juice = juicetoshow.JuiceList();

            Console.WriteLine(text);
            Console.WriteLine("Clients that system has at this moment : " + clientslist);
            Console.WriteLine("Juice name: " + juice.JuiceName);
            Console.WriteLine("Juice description: " + juice.Description);

            int ix = 0;
            string s;
            string currentprice;
            string description = " ";
            string productype;

            Console.WriteLine("Please make choice about what you want to do : Create/add new product(C), Read(R),Update(U) or Delete (D) ? (just type the first symbol)");
            firsstinp:
            s = Console.ReadLine();
            s = s.ToUpper();
            if (!(String.Equals(s, "C") || String.Equals(s, "R") || String.Equals(s, "U") || String.Equals(s, "D"))) {
                Console.WriteLine("Please, make CORRECT ('C','R','U','D') choice - Create/add new product(C), Read(R),Update(U) or Delete (D) "); goto firsstinp;
            }

            switch (s) {
                case "C":
                Filler.AddSetOfProduct();
                Console.WriteLine("Please make choice about what product you want to add : Mineral water(M), Juice(J) or Soft drink(S) ? (just type the first symbol)");
                type:
                s = Console.ReadLine();
                s = s.ToUpper();
                if (!(String.Equals(s, "J") || String.Equals(s, "M") || String.Equals(s, "S"))) {
                    Console.WriteLine("Please, make CORRECT ('J','M','S') choice - Mineral water(M), Juice(J) or Soft drink(S)");
                    goto type;
                }
                s = Product.TypeFinder(s);
                Console.WriteLine("You are adding a new product:" + s);

                newinputn:
                Console.WriteLine("Please input product name: ");
                productname = Console.ReadLine();

                if (!EqualsCheck.Validation(productname)) { goto newinputn; }

                newinputd:
                Console.WriteLine("Please input product Description: ");
                description = Console.ReadLine();
                if (String.IsNullOrEmpty(description)) { Console.WriteLine("Description can't be null or empty."); goto newinputd; }


                newinputp:

                Console.WriteLine("Please input product current price: ");
                currentprice = Console.ReadLine();
                //  if (String.IsNullOrEmpty(currentprice)|| !int.TryParse(currentprice,out temp)) { Console.WriteLine("Current price can't be null or empty and must be a NUMBER."); 
                if (!EqualsCheck.NumberValidation(currentprice)) { goto newinputp; }

                int price = int.Parse(currentprice);
                Filler.products.Add(new Product() { ProductName = productname, Description = description, ProductType = s, CurrentPrice = price });
                Console.WriteLine("At the shop are now stored next products: ");
                Filler.AddSetOfProduct();
                foreach (Product product in Filler.products) {
                    Console.WriteLine(product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice);
                }
                break;

                case "R":
                // Find items according to type
                Console.WriteLine("Please select type of product you want to inspect: : Mineral water(M), Juice(J) or Soft drink(S) ? (just type the first symbol) ");
                productype = Product.TypeFinder(Console.ReadLine());
                Filler.AddSetOfProduct();
                foreach (Product product in Filler.products) {
                    if (product.ProductType == productype)
                        Console.WriteLine(product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice);
                }

                break;

                case "U":

                Filler.AddSetOfProduct();
                foreach (Product product in Filler.products) {

                    Console.WriteLine(ix + ") " + product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice);
                    ix++;
                }
                ix = 0;
                Console.WriteLine("Please select from the list a row you want to update (use it number) ");
                int id = System.Convert.ToInt32(Console.ReadLine());


                Product item = Filler.GetRowFromList(id);
                Console.WriteLine("Row to be updated: " + item.ProductName + " " + item.Description + " " + item.ProductType + " " + item.CurrentPrice);
                newinputupdatedname:
                Console.WriteLine("Please, print new product name: ");
                String newname = Console.ReadLine();
                if (!EqualsCheck.Validation(newname)) { goto newinputupdatedname; }
                Console.WriteLine("Please, print new product description: ");
                String newdescrip = Console.ReadLine();
                newinputprice:
                Console.WriteLine("Please, print updated price: ");
                string newprice = Console.ReadLine();
                if (!EqualsCheck.NumberValidation(newprice)) { goto newinputprice; }
                int newpricen = System.Convert.ToInt32(newprice);

                Filler.products[id].ProductName = newname;
                Filler.products[id].Description = newdescrip;
                Filler.products[id].CurrentPrice = newpricen;
                Console.WriteLine("Updated list of products: ");
                foreach (Product product in Filler.products) {

                    Console.WriteLine(ix + ") " + product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice);
                    ix++;
                }
                break;
                case "D":
                Filler.AddSetOfProduct();
                foreach (Product product in Filler.products) {
                    Console.WriteLine(ix + ") " + product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice);
                    ix++;
                }
                ix = 0;
                Console.WriteLine("Please select from the list a product you want to delete(use it number) : ");
                id = System.Convert.ToInt32(Console.ReadLine());
                item = Filler.GetRowFromList(id);
                Console.WriteLine("Row to be deleted: " + item.ProductName + " " + item.Description + " " + item.ProductType + " " + item.CurrentPrice);

                Filler.DeleteRowFromList(id);
                Console.WriteLine("Updated list of products: ");
                foreach (Product product in Filler.products) {

                    Console.WriteLine(ix + ") " + product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice);
                    ix++;
                }

                break;
            }




            Console.ReadKey();

        }

        public enum NewProduct { s, productname, currentprice };
    }
}
