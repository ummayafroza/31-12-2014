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
    public partial class MainUI : Form
    {
       List<Product> AProducts = new List<Product>();

        public MainUI()
        {
            InitializeComponent();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            SuperShopUI aSuperShopUi = new SuperShopUI(AProducts);
            aSuperShopUi.Show();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ViewUI aViewUi = new ViewUI(AProducts);
            aViewUi.Show();
        }
    }
}
