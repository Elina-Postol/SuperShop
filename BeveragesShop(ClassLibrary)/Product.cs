using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class Product : IProduct {
        private string v;

        public Product(string v) {
            this.v = v;
        }

        public Product() {
            // this.ToString();
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string Description { get; set; }
        public int CurrentPrice { get; set; }
        public string ProductStorageType { get; set; }


        string IProduct.TypeFinder(string sign) {
            string type = null;
            sign = sign.ToUpper();
            IProduct findType = new Product();
            bool checkIsFail = false;
            if (!(String.Equals(sign, "J") || String.Equals(sign, "M") || String.Equals(sign, "S"))) {
                Console.WriteLine("Please, make CORRECT ('J','M','S') choice - Mineral water(M), Juice(J) or Soft drink(S)");
                sign = Console.ReadLine();
                checkIsFail = true;
            }

            switch (sign) {
                case "J":
                type = "Juice";
                break;
                case "M":
                type = "Mineral water";
                break;
                case "S":
                type = "Soft drink";
                break;
            }
            if (checkIsFail) {
                type = findType.TypeFinder(sign);
            }
            return type;
        }

        string IProduct.DeleteRow(int id) {
            UserLog.Log("Function DELETE item called; ");
            string deletedRow = "";
            int ix = 0;
            Product item = Filler.GetRowFromList(id);
            deletedRow = item.ProductName + " " + item.Description + " " + item.ProductType + " " + item.CurrentPrice;
            Console.WriteLine("Row to be deleted: " + deletedRow);

            Filler.DeleteRowFromList(id);
            Console.WriteLine("Updated list of products: ");
            foreach (Product product in Filler.products) {

                Console.WriteLine(ix + ") " + product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice);
                ix++;
            }
            return deletedRow;
        }

        void IProduct.Update() {
            UserLog.Log("Function UPDATE item called; ");
            int ix = 0;
            string updatedrow = " ";
            IProduct rowUpdate = new Product();
            foreach (Product product in Filler.products) {
                Console.WriteLine(ix + ") " + product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice);
                ix++;
            }
            ix = 0;
            Console.WriteLine("Please select from the list a row you want to update (use it number) ");
            int id = System.Convert.ToInt32(Console.ReadLine());
            Product item = Filler.GetRowFromList(id);
            StringBuilder stringBuild = new StringBuilder();
            stringBuild.AppendFormat("{0} ", "Row to be updated: ");
            stringBuild.AppendFormat("{0} ", item.ProductName);
            stringBuild.AppendFormat("{0} ", item.Description);
            stringBuild.AppendFormat("{0} ", item.ProductType);
            stringBuild.AppendFormat("{0} ", item.CurrentPrice);
            Console.WriteLine(stringBuild);

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
            updatedrow = rowUpdate.UpdateOfRow(id, newname, newdescrip, newpricen);
        }


        string IProduct.UpdateOfRow(int id, string newname, string newdescrip, int newpricen) {
            int ix = 0;
            Filler.products[id].ProductName = newname;
            Filler.products[id].Description = newdescrip;
            Filler.products[id].CurrentPrice = newpricen;
            Console.WriteLine("Updated list of products: ");
            foreach (Product product in Filler.products) {

                Console.WriteLine(ix + ") " + product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice);
                ix++;
            }
            string updatedRow = String.Concat(Filler.products[id].ProductName, Filler.products[id].ProductType, Filler.products[id].Description, Filler.products[id].CurrentPrice);
            return updatedRow;
        }
        string IProduct.Read(string productType) {
            UserLog.Log("Function READ item called; ");
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
        string IProduct.Create(string productName, string productType, string description, string currentPrice) {
            UserLog.Log("Function CREATE item called; ");
            string newrow = " ";
            bool checkIsFail = false;
            IProduct iproduct = new Product();
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
                iproduct.Create(productName, productType, description, currentPrice);
                checkIsFail = true;
            }

            if (checkIsFail) {
                iproduct.Create(productName, productType, description, currentPrice);
            }
            productType = iproduct.TypeFinder(productType);
            int price = int.Parse(currentPrice);
            if (Filler.products.Capacity < 17) {
                Filler.products.Add(new Product() { ProductName = productName, Description = description, ProductType = productType, CurrentPrice = price });
            } else {
                Console.WriteLine("There is no space to add new product. Capacity amount has been already reached.");
                Console.ReadKey();
                System.Environment.Exit(-1);
            }
            foreach (Product product in Filler.products) {
                newrow += (product.ProductName + " " + product.Description + " " + product.ProductType + " " + product.CurrentPrice + System.Environment.NewLine);
            }
            return newrow;
        }

    }
}



