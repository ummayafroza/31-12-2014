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
    public partial class ViewUI : Form
    {
        private List<Product> ProductsList;
        public ViewUI(List<Product> AProducts)
        {
            InitializeComponent();
            ProductsList = AProducts;
        }

        private void ViewUI_Load(object sender, EventArgs e)
        {
            
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ProductsList.Count.ToString());
        }
    }
}
