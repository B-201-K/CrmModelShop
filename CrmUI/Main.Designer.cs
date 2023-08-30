namespace CrmUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.сущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerAddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerAddToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.cartTextLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.paymentButton = new System.Windows.Forms.Button();
            this.registrationLink = new System.Windows.Forms.LinkLabel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem,
            this.modelToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.sellerToolStripMenuItem,
            this.chequeToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.сущностиToolStripMenuItem.Text = "Сущности";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productAddToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.productToolStripMenuItem.Text = "Товар";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // productAddToolStripMenuItem
            // 
            this.productAddToolStripMenuItem.Name = "productAddToolStripMenuItem";
            this.productAddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.productAddToolStripMenuItem.Text = "Добавить";
            this.productAddToolStripMenuItem.Click += new System.EventHandler(this.productAddToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAddToolStripMenuItem1});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.customerToolStripMenuItem.Text = "Покупатель";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // customerAddToolStripMenuItem1
            // 
            this.customerAddToolStripMenuItem1.Name = "customerAddToolStripMenuItem1";
            this.customerAddToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.customerAddToolStripMenuItem1.Text = "Добавить";
            this.customerAddToolStripMenuItem1.Click += new System.EventHandler(this.customerAddToolStripMenuItem1_Click);
            // 
            // sellerToolStripMenuItem
            // 
            this.sellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellerAddToolStripMenuItem2});
            this.sellerToolStripMenuItem.Name = "sellerToolStripMenuItem";
            this.sellerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sellerToolStripMenuItem.Text = "Продавец";
            this.sellerToolStripMenuItem.Click += new System.EventHandler(this.sellerToolStripMenuItem_Click);
            // 
            // sellerAddToolStripMenuItem2
            // 
            this.sellerAddToolStripMenuItem2.Name = "sellerAddToolStripMenuItem2";
            this.sellerAddToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.sellerAddToolStripMenuItem2.Text = "Добавить";
            this.sellerAddToolStripMenuItem2.Click += new System.EventHandler(this.sellerAddToolStripMenuItem2_Click);
            // 
            // chequeToolStripMenuItem
            // 
            this.chequeToolStripMenuItem.Name = "chequeToolStripMenuItem";
            this.chequeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.chequeToolStripMenuItem.Text = "Чек";
            this.chequeToolStripMenuItem.Click += new System.EventHandler(this.chequeToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.modelToolStripMenuItem.Text = "Моделирование";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 15;
            this.productsListBox.Location = new System.Drawing.Point(13, 54);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(289, 379);
            this.productsListBox.TabIndex = 1;
            this.productsListBox.DoubleClick += new System.EventHandler(this.productsListBox_DoubleClick);
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 15;
            this.cartListBox.Location = new System.Drawing.Point(360, 54);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(261, 349);
            this.cartListBox.TabIndex = 2;
            // 
            // cartTextLabel
            // 
            this.cartTextLabel.AutoSize = true;
            this.cartTextLabel.Location = new System.Drawing.Point(357, 34);
            this.cartTextLabel.Name = "cartTextLabel";
            this.cartTextLabel.Size = new System.Drawing.Size(53, 15);
            this.cartTextLabel.TabIndex = 3;
            this.cartTextLabel.Text = "Корзина";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(13, 31);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(48, 15);
            this.productsLabel.TabIndex = 4;
            this.productsLabel.Text = "Товары";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(363, 417);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(40, 15);
            this.totalCostLabel.TabIndex = 5;
            this.totalCostLabel.Text = "Итого";
            // 
            // paymentButton
            // 
            this.paymentButton.Location = new System.Drawing.Point(363, 439);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(176, 23);
            this.paymentButton.TabIndex = 6;
            this.paymentButton.Text = "Оплатить";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // registrationLink
            // 
            this.registrationLink.AutoSize = true;
            this.registrationLink.Location = new System.Drawing.Point(670, 29);
            this.registrationLink.Name = "registrationLink";
            this.registrationLink.Size = new System.Drawing.Size(101, 15);
            this.registrationLink.TabIndex = 7;
            this.registrationLink.TabStop = true;
            this.registrationLink.Text = "Здравствуй гость";
            this.registrationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrationLink_LinkClicked);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(661, 440);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(126, 23);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Выйти из аккаунта";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.registrationLink);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.cartTextLabel);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem сущностиToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem sellerToolStripMenuItem;
        private ToolStripMenuItem chequeToolStripMenuItem;
        private ToolStripMenuItem productAddToolStripMenuItem;
        private ToolStripMenuItem customerAddToolStripMenuItem1;
        private ToolStripMenuItem sellerAddToolStripMenuItem2;
        private ToolStripMenuItem modelToolStripMenuItem;
        private ListBox productsListBox;
        private ListBox cartListBox;
        private Label cartTextLabel;
        private Label productsLabel;
        private Label totalCostLabel;
        private Button paymentButton;
        private LinkLabel registrationLink;
        private Button logoutButton;
    }
}