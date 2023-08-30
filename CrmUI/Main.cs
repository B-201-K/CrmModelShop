using CrmBL.Model;
using CrmUI;

namespace CrmUI
{
    public partial class Main : Form
    {
        CrmContext db;
        Cart cart;
        Customer customer;
        CashDesk cashDesk;
        Seller seller;
        public Main()
        {
            InitializeComponent();
            db = new CrmContext();
            cart = new Cart(customer);
            cashDesk = new CashDesk(1, db.Sellers.FirstOrDefault(), db)
            {
                IsModel = false
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (customer == null)
            {
                logoutButton.Visible = false;
            }
            Task.Run(() =>
            {
                productsListBox.Invoke((Action)delegate
                {
                    productsListBox.Items.AddRange(db.Products.ToArray());
                    UpdateLists();
                });
            });
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers, db);
            catalogSeller.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customers, db);
            catalogCustomer.Show();
        }

        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCheque = new Catalog<Cheque>(db.Cheques, db);
            catalogCheque.Show();
        }

        private void customerAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void sellerAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        private void productAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ModelForm();
            form.Show();
        }

        private void productsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (productsListBox.SelectedItem is Product product)
            {
                cart.Add(product);
                cartListBox.Items.Add(product);
                UpdateLists();
            }
        }
        private void UpdateLists()
        {
            cartListBox.Items.Clear();
            cartListBox.Items.AddRange(cart.GetAll().ToArray());
          //  cart.TotalPrice = cart.GetAll().Sum(p => p.Price);
            totalCostLabel.Text = $"Итого: {cart.TotalPrice}";
        }

        private void registrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new LogIn();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                logoutButton.Visible = true;
                var tempCustomer = db.Customers.FirstOrDefault(c => c.Name.Equals(form.Customer.Name));
                if (tempCustomer != null)
                {
                    customer = tempCustomer;
                }
                else
                {
                    db.Customers.Add(form.Customer);
                    db.SaveChanges();
                    customer = form.Customer;
                }
                cart.Customer = customer;
                registrationLink.Text = $"Здравствуй, {customer.Name}";
            }
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                cashDesk.Enqueue(cart);
                var price = cashDesk.Dequeue();
                cartListBox.Items.Clear();
                cart = new Cart(customer);
                MessageBox.Show("Покупка выполнена успешно. Сумма: " + price, "Покупка выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Авторизуйтесь, пожалуйста!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            customer = null;
            registrationLink.Text = $"Здравствуй, гость";
            cartListBox.Items.Clear();
            cart.TotalPrice= 0 ;
            totalCostLabel.Text = $"Итого: {cart.TotalPrice}";
            
        }
    }
}
