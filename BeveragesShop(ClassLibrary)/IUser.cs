using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public interface IUser {
        bool Login(string UserName,string UserPassword);
        bool Logout();
        bool Register(string UserName,string UserPassword,string UserEmail);

        bool ChangeData(string UserName,string UserPassword);

    }
}
