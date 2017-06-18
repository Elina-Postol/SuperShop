
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeveragesShop_ClassLibrary_;

namespace BeverageReview {
    class Program {
        public static string clientslist;
        public static string productname="new";

        static void Main(string[] args) {

            Customer client = new Customer();
            Customer client2 = new Customer();
            Customer client3 = new Customer();

            client.FirstName = "ClientF1";
            client.LastName = "ClientL1";
            var customer = client.FullName;
            client2.FirstName = "ClientF2";
            client2.LastName = "ClientL2";
            var customer2 = client2.FullName;
            client3.FirstName = "ClientF3";
            client3.LastName = "ClientL3";
            var customer3 = client3.FullName;
            clientslist = customer + "," + customer2 + "," + customer3;

            String text = ReportView.ShopTypeDescription;

            Juice juicetoshow = new Juice();
          Juice juice = juicetoshow.JuiceList();

            Console.WriteLine( text);
            Console.WriteLine("Clients that system has at this moment : "+clientslist);
           Console.WriteLine("Juice name: "+ juice.JuiceName);
            Console.WriteLine("Juice description: " + juice.Description);
            Console.ReadKey();
        }
    }
}
