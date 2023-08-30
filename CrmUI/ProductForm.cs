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
        public ProductForm(Product product) : this()
        {
            Product = product?? new Product();
            productNameTextBox.Text = Product.Name;
            productCostTextBox.Value = Product.Price;
            quantityTextBox.Value = Product.Count;
        }

        private void resultProductButton_Click(object sender, EventArgs e)
        {
            Product = Product ?? new Product();
            Product.Name = productNameTextBox.Text;
            Product.Price = productCostTextBox.Value;
            Product.Count = Convert.ToInt32(quantityTextBox.Value);


            Close();

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
