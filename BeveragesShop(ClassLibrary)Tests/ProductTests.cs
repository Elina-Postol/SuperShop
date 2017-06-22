using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeveragesShop_ClassLibrary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_.Tests {
    [TestClass()]
    public class ProductTests {
        [TestMethod()]
        public void TypeFinderTest() {
            string type = "S";
            string expected = "Soft drink";
            var actual =Product.TypeFinder(type);
            Assert.AreEqual(expected,actual);
                }

       // [TestMethod()]
      //  public void TypeFinderTestOfWrongInput() {
       //     string type = "S ";
       //     string expected = null;
      //      var actual = Product.TypeFinder(type);
       //     Assert.AreEqual(expected, actual);
      //  }
    }
}