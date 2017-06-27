using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class UserLog : Product {
        public static List<string> loggingdata = new List<string>();
        public static void Log(string text) {
            loggingdata.Add(text);
        }
    }
}
