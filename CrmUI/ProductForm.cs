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
            Product = product;
            productNameTextBox.Text = Product.Name;
            productCostTextBox.Value = Product.Price;
            quantityTextBox.Value = Product.Count;
        }

        private void resultProductButton_Click(object sender, EventArgs e)
        {
            var p = Product ?? new Product();
            p.Name = productNameTextBox.Text;
            p.Price = productCostTextBox.Value;
            p.Count = Convert.ToInt32(quantityTextBox.Value);


            Close();

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
