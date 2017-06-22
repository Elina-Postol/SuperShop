
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeveragesShop_ClassLibrary_;


namespace BeverageReview {
    class Program {

        public static string productname = "new";

        static void Main(string[] args) {

            Filler.AddSetOfProduct();
            int ix = 0;
            string userrespond;
            string currentprice;
            string description = " ";
            string productype;

            Console.WriteLine("Please make choice about what you want to do : Create/add new product(C), Read(R),Update(U) or Delete (D) ? (just type the first symbol)");
            firsstinp:
            userrespond = Console.ReadLine();

            userrespond = userrespond.ToUpper();
            if (!(String.Equals(userrespond, "C") || String.Equals(userrespond, "R") || String.Equals(userrespond, "U") || String.Equals(userrespond, "D"))) {
                Console.WriteLine("Please, make CORRECT ('C','R','U','D') choice - Create/add new product(C), Read(R),Update(U) or Delete (D) "); goto firsstinp;
            }

            switch (userrespond) {
                case "C":
                Console.WriteLine("Please input product name: ");
                productname = Console.ReadLine();
                Console.WriteLine("Please make choice about what product you want to add : Mineral water(M), Juice(J) or Soft drink(S) ? (just type the first symbol)");
                productype = Console.ReadLine();
                Console.WriteLine("Please input product Description: ");
                description = Console.ReadLine();
                Console.WriteLine("Please input product current price: ");
                currentprice = Console.ReadLine();
                AddOrCreateProduct createProduct = new AddOrCreateProduct();
                var productList = createProduct.Create(productname, productype, description, currentprice);
                Console.WriteLine("The List of Product is now next:" + productList);

                break;

                case "R":
                // Find items according to type
                Console.WriteLine("Please select type of product you want to inspect: : Mineral water(M), Juice(J) or Soft drink(S) ? (just type the first symbol) ");
                productype = Console.ReadLine();
                productype = Product.TypeFinder(productype);
                GetInfoAboutProduct getInfo = new GetInfoAboutProduct();
                var selectedList = getInfo.Read(productype);
                Console.WriteLine("The List of selected product type is next:" + selectedList);

                break;

                case "U":
                UpdateOfProduct updateProduct = new UpdateOfProduct();
                updateProduct.Update();
                break;

                case "D":
                int id;

                foreach (Product product in Filler.products) {
                    Console.WriteLine(ix + ") " + product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice);
                    ix++;
                }

                Console.WriteLine("Please select from the list a product you want to delete(use it number) : ");
                if (String.IsNullOrEmpty(Console.ReadLine())) { throw new ArgumentException("Selected row number can't be empty."); }
                id = System.Convert.ToInt32(Console.ReadLine());

                DeleteProduct deleterow = new DeleteProduct();
                string deletedRow = deleterow.DeleteRow(id);
                break;
            }

            Console.ReadKey();
        }

    }
}

