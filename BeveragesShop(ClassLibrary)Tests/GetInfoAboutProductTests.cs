using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeveragesShop_ClassLibrary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_.Tests {
    [TestClass()]
    public class GetInfoAboutProductTests {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyProductTypeOnReadTest() {
            GetInfoAboutProduct selectedList = new GetInfoAboutProduct();
            string type = "";
            try { selectedList.Read(type); }
              catch (Exception ex) { 
                Assert.AreEqual("Product Type can't be null or empty.", ex.Message);
                throw;
            }
        }

        }
    }
