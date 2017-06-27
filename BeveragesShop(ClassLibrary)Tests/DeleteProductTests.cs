using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeveragesShop_ClassLibrary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_.Tests {
    [TestClass()]
    public class DeleteProductTests {
        [TestMethod()]
        public void DeleteRowTest() {

            Filler.AddSetOfProduct();
            IProduct iproduct = new Product();
            int id = 1;
            var row = Filler.products[id];

            string expectedRow = row.ProductName + " " + row.Description + " " + row.ProductType + " " + row.CurrentPrice;

            string updateRow = iproduct.DeleteRow(id);

            Assert.AreEqual(expectedRow, updateRow);
        }
    }
}