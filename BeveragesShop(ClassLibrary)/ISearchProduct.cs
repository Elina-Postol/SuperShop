using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public interface ISearchProduct {
        string SearchToFindJuiceInfo(string juice);
        string SearchToFindSoftDrinkInfo(string softDrink);
        string SearchToFidMineralWaterInfo(string mineralWater);
    }
}
