using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
  public  class Juice: Product {
       // public Juice(int productId) : base(productId) {
       // }

        public string JuiceName { get; set; }
        public string TradeMark { get; set; }
        public Juice() {
                
        }
        public Juice(string name,string tr,string productname) {
                                     
            JuiceName = name;
            TradeMark = tr;
            ProductName = productname;
           
        }
       // public Juice(string name,string trmark) {
         //   this.JuiceName = name;
           // this.TradeMark = trmark ;
        //} 
        public override string ToString() {
            return "JuiceName: " + JuiceName + "   TradeMark: " + TradeMark+ "  ProductName: "+ProductName + System.Environment.NewLine;
        }

        // public string ProducerSite { get; set; }
        // public string ProductDescription { get; set; }

    }
}
