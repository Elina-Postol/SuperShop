using BeveragesShop_ClassLibrary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UpdateOfProduct : Product  {

   
    public void Update() {
          int ix = 0;
        string updatedrow = " ";

        // Filler.AddSetOfProduct();
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
        updatedrow = UpdateOfProduct.UpdateOfRow(id, newname, newdescrip, newpricen);
    }


    public static string UpdateOfRow(int id, string newname, string newdescrip, int newpricen) {
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



}


