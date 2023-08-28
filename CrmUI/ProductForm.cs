using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class ProductForm : Form
    {
       public Product Product { get; set; } 
        public ProductForm()
        {
            InitializeComponent();
        }

        private void resultProductButton_Click(object sender, EventArgs e)
        {
            Product = new Product
            {
                Name = productNameTextBox.Text,
                Price = productCostTextBox.Value,
                Count = Convert.ToInt32(quantityTextBox.Value)
            };
            Close();
        
        }
    }
}
