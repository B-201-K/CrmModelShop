namespace CrmUI
{
    partial class SellerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sellerResultButton = new System.Windows.Forms.Button();
            this.sellerEnterNameLable = new System.Windows.Forms.Label();
            this.sellerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sellerResultButton
            // 
            this.sellerResultButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sellerResultButton.Location = new System.Drawing.Point(293, 255);
            this.sellerResultButton.Name = "sellerResultButton";
            this.sellerResultButton.Size = new System.Drawing.Size(75, 23);
            this.sellerResultButton.TabIndex = 0;
            this.sellerResultButton.Text = "button1";
            this.sellerResultButton.UseVisualStyleBackColor = true;
            this.sellerResultButton.Click += new System.EventHandler(this.sellerResultButton_Click);
            // 
            // sellerEnterNameLable
            // 
            this.sellerEnterNameLable.AutoSize = true;
            this.sellerEnterNameLable.Location = new System.Drawing.Point(12, 24);
            this.sellerEnterNameLable.Name = "sellerEnterNameLable";
            this.sellerEnterNameLable.Size = new System.Drawing.Size(75, 15);
            this.sellerEnterNameLable.TabIndex = 1;
            this.sellerEnterNameLable.Text = "Введите имя";
            // 
            // sellerTextBox
            // 
            this.sellerTextBox.Location = new System.Drawing.Point(93, 21);
            this.sellerTextBox.Name = "sellerTextBox";
            this.sellerTextBox.Size = new System.Drawing.Size(166, 23);
            this.sellerTextBox.TabIndex = 2;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.sellerTextBox);
            this.Controls.Add(this.sellerEnterNameLable);
            this.Controls.Add(this.sellerResultButton);
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sellerResultButton;
        private Label sellerEnterNameLable;
        private TextBox sellerTextBox;
    }
}