using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class User : IUser {
                       public  bool ChangeData(string UserName, string UserPassword) {
            throw new NotImplementedException();
        }
       
      public  bool Login(string UserName, string UserPassword) {
            bool userok = false;

           Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("User1", "user1");
            users.Add("User2", "user2");
            users.Add("User3", "user3");
            string value = "";
            users.TryGetValue(UserName, out value);
            if (value == UserPassword) {
                userok = true;
            }
            return userok;

        }

       public  bool Logout() {
            throw new NotImplementedException();
        }

      public  bool Register(string UserName, string UserPassword, string UserEmail) {
            throw new NotImplementedException();
        }

        

    }
}
