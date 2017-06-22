using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class Product {

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string Description { get; set; }
        public int CurrentPrice { get; set; }
        public string ProductStorageType { get; set; }
        
        public Juice JuiceList() {
            var juicetype = new Juice() {
                JuiceName = "Sandora",
                Description = "Apple nectar",
                ProductType = "Juice",
                ProductName = "Sandora juice",
                ProductId = 2
                            };
            return juicetype;
        }
        
        public static int InstanceCount { get; set; }

        public static string TypeFinder(string sign) {
            string type = null;
            sign = sign.ToUpper();
            bool checkIsFail = false;
            if (!(String.Equals(sign, "J") || String.Equals(sign, "M") || String.Equals(sign, "S"))) {
                Console.WriteLine("Please, make CORRECT ('J','M','S') choice - Mineral water(M), Juice(J) or Soft drink(S)");
                sign= Console.ReadLine();
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
                 type=TypeFinder(sign);
            }

            return type;


        }
      
    }

}




