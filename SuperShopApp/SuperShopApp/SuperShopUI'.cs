using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopApp
{
    public partial class SuperShopUI : Form
    {
        private List<Product> ProductsList;
        public SuperShopUI(List<Product> aProducts)
        {
            InitializeComponent();
            ProductsList = aProducts;
        }
        
        Shop aShop = new Shop();
       
        private void SuperShopUI_Load(object sender, EventArgs e)
        {
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(nameTextBox.Text,addressTextBox.Text);
            MessageBox.Show("Shop Created");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product(idTextBox.Text, Convert.ToDouble(quantityTextBox.Text));
            aShop.AddItems(idTextBox.Text, aProduct);
            MessageBox.Show("Item Saved Successfully");


        }
    }
}
