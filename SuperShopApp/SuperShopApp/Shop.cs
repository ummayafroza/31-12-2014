using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp
{
    public class Shop
    {
        public string Name { set; get; }
        public string Address { set; get; }
        //public List<Product> AProducts { set; get; }

        public Dictionary<string,Product> AProducts { set; get; }

        public Shop(string name, string address):this()
        {
            Name = name;
            Address = address;
        }

        public Shop()
        {
            //AProducts = new List<Product>();

            AProducts = new Dictionary<string, Product>();
        }

        public void AddItems(string id, Product aProduct)
        {
            if (AProducts.ContainsKey(id))
            {
                AProducts[id].Quantity += aProduct.Quantity;
            }
            else
            {
                AProducts.Add(id,aProduct);
            }
        }

        public Product[] GetAllProducts()
        {
            return AProducts.Values.ToArray();

        }

    }
}
