namespace CrmUI
{
    partial class Catalog<T>
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.catalogAddButton = new System.Windows.Forms.Button();
            this.catalogRemoveButton = new System.Windows.Forms.Button();
            this.catalogChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 13);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(776, 373);
            this.dataGridView.TabIndex = 0;
            // 
            // catalogAddButton
            // 
            this.catalogAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.catalogAddButton.Location = new System.Drawing.Point(180, 410);
            this.catalogAddButton.Name = "catalogAddButton";
            this.catalogAddButton.Size = new System.Drawing.Size(75, 23);
            this.catalogAddButton.TabIndex = 1;
            this.catalogAddButton.Text = "Добавить";
            this.catalogAddButton.UseVisualStyleBackColor = true;
            this.catalogAddButton.Click += new System.EventHandler(this.catalogAddButton_Click);
            // 
            // catalogRemoveButton
            // 
            this.catalogRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.catalogRemoveButton.Location = new System.Drawing.Point(363, 410);
            this.catalogRemoveButton.Name = "catalogRemoveButton";
            this.catalogRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.catalogRemoveButton.TabIndex = 2;
            this.catalogRemoveButton.Text = "Удалить";
            this.catalogRemoveButton.UseVisualStyleBackColor = true;
            // 
            // catalogChangeButton
            // 
            this.catalogChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.catalogChangeButton.Location = new System.Drawing.Point(537, 410);
            this.catalogChangeButton.Name = "catalogChangeButton";
            this.catalogChangeButton.Size = new System.Drawing.Size(75, 23);
            this.catalogChangeButton.TabIndex = 3;
            this.catalogChangeButton.Text = "Изменить";
            this.catalogChangeButton.UseVisualStyleBackColor = true;
            this.catalogChangeButton.Click += new System.EventHandler(this.catalogChangeButton_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catalogChangeButton);
            this.Controls.Add(this.catalogRemoveButton);
            this.Controls.Add(this.catalogAddButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView;
        private Button catalogAddButton;
        private Button catalogRemoveButton;
        private Button catalogChangeButton;
    }
}