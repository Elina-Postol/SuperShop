using BeveragesShop_ClassLibrary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class EqualsCheck {
          public string text = "test";

        public bool IsNew { get; private set; }

        public static new bool Equals(object obj1, object obj2) {
            if (obj1 == obj2)
                return true;
            else
                return false;

        }
        public static bool Validation(string text) {
            if (String.IsNullOrEmpty(text)) { Console.WriteLine("The product name cannot be null or empty."); goto isfalse; }

            foreach (Product product in Filler.products) {
                if (product.ProductName.Equals(text, StringComparison.OrdinalIgnoreCase)) {
                    Console.WriteLine("The product name already exists. Need to select other name.");
                    goto isfalse;
                }
            }
            return true;

            isfalse:
            return false;
        }

      
        public static bool NumberValidation(string text) {
        int temp;
            if (String.IsNullOrEmpty(text) || !int.TryParse(text, out temp)) { Console.WriteLine("Current price can't be null or empty and must be a NUMBER."); goto isfalse; }
                

            return true;

            isfalse:
            return false;
        }
        public static bool NumberCheck(int num) {

            if (num !=0 && num>0) { Console.WriteLine("Current price can't be null or empty."); goto isfalse; }
            return true;

            isfalse:
            return false;
        }
    }
}

        
               



    

