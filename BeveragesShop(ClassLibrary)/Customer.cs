using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class created to have information about partners who provides with goods
/// </summary>
namespace BeveragesShop_ClassLibrary_ {
    public class Customer {
        private string _lastName;
        public string fullName;

        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FirstName { get; set; }
        public string EmailAdress { get; set; }
        public string Adress { get; set; }
        public int CustomerId { get; private set; }

        public string FullName {
            get {
                String fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName)) {
                    if (string.IsNullOrWhiteSpace(fullName)) { fullName += ", "; }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
    }
}
