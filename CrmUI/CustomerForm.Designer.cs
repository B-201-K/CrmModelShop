namespace CrmUI
{
    partial class CustomerForm
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
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.enterName = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterNameTextBox.Location = new System.Drawing.Point(93, 21);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.Size = new System.Drawing.Size(166, 23);
            this.enterNameTextBox.TabIndex = 0;
            // 
            // enterName
            // 
            this.enterName.AutoSize = true;
            this.enterName.Location = new System.Drawing.Point(12, 24);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(75, 15);
            this.enterName.TabIndex = 1;
            this.enterName.Text = "Введите имя";
            // 
            // resultButton
            // 
            this.resultButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.resultButton.Location = new System.Drawing.Point(293, 255);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(79, 23);
            this.resultButton.TabIndex = 2;
            this.resultButton.Text = "button1";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.sellerResultButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.enterName);
            this.Controls.Add(this.enterNameTextBox);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox enterNameTextBox;
        private Label enterName;
        private Button resultButton;
    }
}