using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class DeliveryType {
        public int PartnerId { get; private set; }

        public int ProductId { get; private set; }

        public string Type { get; set; }

        public DateTime DeliveryTime { get; set; }

            }
}
