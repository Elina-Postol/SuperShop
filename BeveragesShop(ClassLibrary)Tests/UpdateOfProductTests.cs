using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeveragesShop_ClassLibrary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_.Tests {
    [TestClass()]
    public class UpdateOfProductTests {
        [TestMethod()]
        public void UpdateTest() {
            Filler.AddSetOfProduct();
            int id = 1;
            string newname = "TEST";
            string descrip = "My new test";
            string type = "Juice";
            int newprice = 100;
            string expectedRow = String.Concat(newname, type,descrip, newprice);
            string updateRow = UpdateOfProduct.UpdateOfRow(id, newname, descrip, newprice);

            Assert.AreEqual(expectedRow, updateRow);
            
        }
    }
}