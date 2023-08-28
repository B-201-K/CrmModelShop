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

        private void sellerResultButton_Click(object sender, EventArgs e)
        {
            Seller = new Seller()
            {
                Name = sellerTextBox.Text

            };
            Close();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
