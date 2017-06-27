using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public interface IProduct {
        string TypeFinder(string sign);
        string DeleteRow(int id);
        void Update();
        string UpdateOfRow(int id, string newname, string newdescrip, int newprice);
        string Read(string productType);
        string Create(string productName, string productType, string description, string currentPrice);
    }
}
