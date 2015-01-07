using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp
{
     public class Product
    {
         public string Id { set; get; }
         public double Quantity { set; get; }

         public Product(string id, double quantity)
         {
             Id = id;
             Quantity = quantity;

         }
    }
}
