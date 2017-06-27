using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
   public  class SoftDrink: Product {
        //public SoftDrink(int productId) : base(productId) {
       // }

        public string SoftDrinkName { get; set; }
        public string TradeMark { get; set; }
        public string ProducerSite { get; set; }
        public string ProductDescription { get; set; }
        public override string ToString() {
            return "Soft Drink: " + SoftDrinkName  + "   TradeMark: " + TradeMark;
        }
    }
}
