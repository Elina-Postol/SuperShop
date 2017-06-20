﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeveragesShop_ClassLibrary_ {
    public class Product {

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string Description { get; set; }
        public int CurrentPrice { get; set; }
        public string ProductStorageType { get; set; }
        // Product product = new Product();
        //

        // public Product ProductList(int val) {



        //  product.ProductId = 1;
        //  product.Descriprion = "Min water";
        //   product.ProductType = "MineralWater";
        //   product.ProductName = "new";
        //   return product;
        //}

        public Juice JuiceList() {
            var juicetype = new Juice() {
                JuiceName = "Sandora",
                Description = "Apple nectar",
                ProductType = "Juice",
                ProductName = "Sandora juice",
                ProductId = 2

            };
            return juicetype;
        }
 

        public static int InstanceCount { get; set; }

        public static string TypeFinder(string sign) {
string type = null;
            
            
             sign = sign.ToUpper();
     

          
            switch (sign) {
                case "J":
              type = "Juice";
                break;
                case "M":
                type = "Mineral water";
                break;
                case "S":
                type = "Soft drink";
                break;
               
            }
           
            return  type;
          
            
            } 
        }  
       
    } 
    
 
    

