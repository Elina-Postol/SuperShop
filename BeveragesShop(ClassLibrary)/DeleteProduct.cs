using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class DeleteProduct {
        public string DeleteRow(int id) {
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
    }
}

