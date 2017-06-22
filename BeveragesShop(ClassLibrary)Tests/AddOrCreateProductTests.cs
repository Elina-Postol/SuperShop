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
        [TestMethod()]
         [ExpectedException (typeof (ArgumentException)) ]
        public void CheckIfProductDescrIsNull() {
            var create = new AddOrCreateProduct();
            string name = "My ";
            string type = "S";
            string description = "";
            string price = "8";

            try {
                create.Create(name, type, description, price);
            } 
            catch (Exception ex) {
                Assert.AreEqual("Description can't be null or empty.", ex.Message);
                throw;
            }
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ChckIfProductTypeIsNull() {
            var create2 = new AddOrCreateProduct();
            string name = "ColaCola";
            string type = "";
            string description = "my test";
            string price = "8";

            try {
                create2.Create(name, type, description, price);
            } catch (Exception ex) {
                Assert.AreEqual("Product type can't be null or empty.", ex.Message);
                throw;
            }
        }

     
        }
    }
