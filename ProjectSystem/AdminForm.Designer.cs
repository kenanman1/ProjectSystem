namespace ProjectSystem
{
    partial class AdminForm
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
            listBoxCategories = new ListBox();
            label1 = new Label();
            listBoxProducts = new ListBox();
            label2 = new Label();
            textBoxProductName = new TextBox();
            buttonAddProduct = new Button();
            label3 = new Label();
            textBoxQuantity = new TextBox();
            textBoxAddCategory = new TextBox();
            buttonAddCategory = new Button();
            textBoxPrice = new TextBox();
            buttonDeleteProduct = new Button();
            buttonDeleteCategory = new Button();
            buttonAddImage = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxCategories
            // 
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.ItemHeight = 20;
            listBoxCategories.Location = new Point(45, 223);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new Size(351, 364);
            listBoxCategories.TabIndex = 0;
            listBoxCategories.SelectedIndexChanged += listBoxCategories_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 178);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 1;
            label1.Text = "All categories";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 20;
            listBoxProducts.Location = new Point(6, 223);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(400, 364);
            listBoxProducts.TabIndex = 2;
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 178);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 3;
            label2.Text = "Products";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Enabled = false;
            textBoxProductName.Location = new Point(34, 97);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.PlaceholderText = "Name";
            textBoxProductName.Size = new Size(125, 27);
            textBoxProductName.TabIndex = 4;
            textBoxProductName.TextChanged += textBoxProductName_TextChanged;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Enabled = false;
            buttonAddProduct.Location = new Point(141, 138);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(94, 52);
            buttonAddProduct.TabIndex = 5;
            buttonAddProduct.Text = "Add Product";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 23);
            label3.Name = "label3";
            label3.Size = new Size(266, 60);
            label3.TabIndex = 6;
            label3.Text = "Select a category and then \r\nenter the product name, quantity, price\r\nand add image";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Enabled = false;
            textBoxQuantity.Location = new Point(192, 97);
            textBoxQuantity.MaxLength = 6;
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.PlaceholderText = "Quantity";
            textBoxQuantity.Size = new Size(125, 27);
            textBoxQuantity.TabIndex = 7;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
            textBoxQuantity.KeyPress += textBoxQuantity_KeyPress;
            // 
            // textBoxAddCategory
            // 
            textBoxAddCategory.Location = new Point(45, 97);
            textBoxAddCategory.Name = "textBoxAddCategory";
            textBoxAddCategory.PlaceholderText = "Name";
            textBoxAddCategory.Size = new Size(136, 27);
            textBoxAddCategory.TabIndex = 8;
            textBoxAddCategory.TextChanged += textBoxAddCategory_TextChanged;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Location = new Point(213, 83);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(94, 54);
            buttonAddCategory.TabIndex = 9;
            buttonAddCategory.Text = "Add category";
            buttonAddCategory.UseVisualStyleBackColor = true;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(349, 97);
            textBoxPrice.MaxLength = 6;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Price";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 10;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            textBoxPrice.KeyPress += textBoxQuantity_KeyPress;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.Enabled = false;
            buttonDeleteProduct.Location = new Point(440, 258);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(94, 57);
            buttonDeleteProduct.TabIndex = 11;
            buttonDeleteProduct.Text = "Delete product";
            buttonDeleteProduct.UseVisualStyleBackColor = true;
            buttonDeleteProduct.Click += buttonDeleteProduct_Click;
            // 
            // buttonDeleteCategory
            // 
            buttonDeleteCategory.Enabled = false;
            buttonDeleteCategory.Location = new Point(185, 178);
            buttonDeleteCategory.Name = "buttonDeleteCategory";
            buttonDeleteCategory.Size = new Size(137, 29);
            buttonDeleteCategory.TabIndex = 12;
            buttonDeleteCategory.Text = "Delete category";
            buttonDeleteCategory.UseVisualStyleBackColor = true;
            buttonDeleteCategory.Click += buttonDeleteCategory_Click;
            // 
            // buttonAddImage
            // 
            buttonAddImage.Enabled = false;
            buttonAddImage.Location = new Point(278, 138);
            buttonAddImage.Name = "buttonAddImage";
            buttonAddImage.Size = new Size(94, 52);
            buttonAddImage.TabIndex = 13;
            buttonAddImage.Text = "Add Image";
            buttonAddImage.UseVisualStyleBackColor = true;
            buttonAddImage.Click += buttonAddImage_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonAddImage);
            groupBox1.Controls.Add(listBoxProducts);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonDeleteProduct);
            groupBox1.Controls.Add(textBoxProductName);
            groupBox1.Controls.Add(textBoxPrice);
            groupBox1.Controls.Add(buttonAddProduct);
            groupBox1.Controls.Add(textBoxQuantity);
            groupBox1.Location = new Point(515, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 638);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adding Product";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxAddCategory);
            groupBox2.Controls.Add(buttonDeleteCategory);
            groupBox2.Controls.Add(listBoxCategories);
            groupBox2.Controls.Add(buttonAddCategory);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(468, 638);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adding Category";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 662);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxCategories;
        private Label label1;
        private ListBox listBoxProducts;
        private Label label2;
        private TextBox textBoxProductName;
        private Button buttonAddProduct;
        private Label label3;
        private TextBox textBoxQuantity;
        private TextBox textBoxAddCategory;
        private Button buttonAddCategory;
        private TextBox textBoxPrice;
        private Button buttonDeleteProduct;
        private Button buttonDeleteCategory;
        private Button buttonAddImage;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}