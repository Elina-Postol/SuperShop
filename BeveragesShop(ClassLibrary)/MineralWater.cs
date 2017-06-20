using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
   public class MineralWater: Product {
       // public MineralWater(int productId) : base(productId) {
      //  }
        public string MinWaterName { get; set; }
        public string TradeMark { get; set; }
        public string ProducerSite { get; set; }
        public string ProductDescription { get; set; }

    }
}
