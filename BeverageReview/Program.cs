
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeveragesShop_ClassLibrary_;
using System.ComponentModel;
using System.Collections;


namespace BeverageReview {
    class Program {

        public static string productname = "new";

        static void Main(string[] args) {

            Console.WriteLine("Login:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Password:");
            string userPassword = Console.ReadLine();
                User user = new User();
            if (!user.Login(UserName, userPassword)) {
                Console.WriteLine("LoginFailes.");
                Console.ReadKey();
                System.Environment.Exit(-1);
            }
            Product stuff = new Product();

            Console.WriteLine("Hi " + UserName + " Please, select what you want to do: ");
            Console.WriteLine("1) Create/Create/Update/Delete product manualy.");
            Console.WriteLine("2) Look through the store warehouse (upload set of products, read them...).");
            Console.WriteLine("3) Conveyor. Upload standart set of products and have an overview of what is loaded.");
            string choice = Console.ReadLine();
            StoreWarehouse warehouse = new StoreWarehouse();
            switch (choice) {
                case "3":

                warehouse.ProcessConveyor();
                break;
                case "2":
                warehouse.AllProductsAdd();

                Console.WriteLine();
                Console.WriteLine("New product with product type- ' Juice'- Created: ");
                warehouse.CreateProduct("Juice");

                Console.WriteLine();
                Console.WriteLine("Product with product type- ' Mineral Water'- Read: ");
                warehouse.ReadProduct("Mineral Water");

                Console.WriteLine();
                Console.WriteLine("Product with product type- 'Soft Drink' with name'Cola'- Updated to 'some value' ");
                warehouse.UpdateProduct("Soft Drink", "Cola");

                Console.WriteLine();
                Console.WriteLine("Product with product type- 'Soft Drink' with name'Cola'- Deleted ");
                warehouse.DeleteProduct("Soft Drink", "Cola");

                Console.WriteLine();
                Console.WriteLine("Results of SEARH by juice with name 'Apple' ");
                warehouse.SearchToFindJuiceInfo("Apple");

                Console.WriteLine();
                Console.WriteLine("Results of SEARH by mineral water with trade mark 'Morshinska' ");
                warehouse.SearchToFidMineralWaterInfo("Morshinska");

                Console.WriteLine();
                Console.WriteLine("Results of SEARH by soft drink with name 'Pepsi' ");
                warehouse.SearchToFindSoftDrinkInfo("Pepsi");
                break;
                case "1":
                
            IProduct iproduct = new Product();

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

                    var productList = iproduct.Create(productname, productype, description, currentprice);
                    Console.WriteLine("The List of Product is now next:" + productList);

                    break;

                    case "R":
                    // Find items according to type
                    Console.WriteLine("Please select type of product you want to inspect: : Mineral water(M), Juice(J) or Soft drink(S) ? (just type the first symbol) ");
                    productype = Console.ReadLine();
                    productype = iproduct.TypeFinder(productype);

                    var selectedList = iproduct.Read(productype);
                    Console.WriteLine("The List of selected product type is next:" + selectedList);

                    break;

                    case "U":
                    iproduct.Update();
                    break;

                    case "D":
                    int id;

                    foreach (Product product in Filler.products) {
                        Console.WriteLine(ix + ") " + product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice);
                        ix++;
                    }

                    Console.WriteLine("Please select from the list a product you want to delete(use it number) : ");
                    // if (String.IsNullOrEmpty(Console.ReadLine())) { throw new ArgumentException("Selected row number can't be empty."); }
                    id = System.Convert.ToInt32(Console.ReadLine());
                    string deletedRow = iproduct.DeleteRow(id);
                    break;
                }
                break;
                default:
                Console.WriteLine("Sorry, can't help with your choice.");
                break;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} ", "User with next login name: ");
            sb.AppendFormat("{0} ", UserName);
            sb.AppendFormat("{0} ", "has next activity: ");
            foreach (var log in UserLog.loggingdata)
                sb.AppendFormat("{0} ", log);

            Console.WriteLine(sb);
            Console.ReadKey();


        }

    }
}

