using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeveragesShop_ClassLibrary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_.Tests {
    [TestClass()]
    public class AddOrCreateProductTests {
        IProduct iproduct = new Product();
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckIfProductDescrIsNull() {

            string name = "My ";
            string type = "S";
            string description = "";
            string price = "8";

            try {
                iproduct.Create(name, type, description, price);
            } catch (Exception ex) {
                Assert.AreEqual("Description can't be null or empty.", ex.Message);
                throw;
            }
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ChckIfProductTypeIsNull() {
            string name = "ColaCola";
            string type = "";
            string description = "my test";
            string price = "8";

            try {
                iproduct.Create(name, type, description, price);
            } catch (Exception ex) {
                Assert.AreEqual("Product type can't be null or empty.", ex.Message);
                throw;
            }
        }


    }
}
