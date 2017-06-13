using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public abstract class AddProduct {
        public string text = "test";
        public abstract Product ProductList(string text);
    }
}
