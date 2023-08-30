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
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }
        public SellerForm()
        {
            InitializeComponent();
        }
        public SellerForm(Seller seller) : this()
        {
            Seller = seller;
            sellerTextBox.Text = seller.Name;

        }

        private void sellerResultButton_Click(object sender, EventArgs e)
        {
            Seller = Seller ?? new Seller();
            Seller.Name = sellerTextBox.Text;
            Close();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
