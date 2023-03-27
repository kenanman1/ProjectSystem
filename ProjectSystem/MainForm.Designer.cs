namespace ProjectSystem
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            listBoxBasket = new ListBox();
            groupBox1 = new GroupBox();
            labelCategoryName = new Label();
            labelQuantity = new Label();
            labelPrice = new Label();
            buttonAddToBasket = new Button();
            buttonShowPicture = new Button();
            pictureBox1 = new PictureBox();
            listBoxProducts = new ListBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            buttonClearBasket = new Button();
            buttonDeleteItem = new Button();
            label12 = new Label();
            labelTotalSum = new Label();
            buttonMakePurchase = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { categoriesToolStripMenuItem, ordersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1251, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(94, 24);
            categoriesToolStripMenuItem.Text = "Categories";
            categoriesToolStripMenuItem.DropDownItemClicked += categoriesToolStripMenuItem_DropDownItemClicked;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(115, 24);
            ordersToolStripMenuItem.Text = "Orders history";
            ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
            // 
            // listBoxBasket
            // 
            listBoxBasket.Dock = DockStyle.Right;
            listBoxBasket.FormattingEnabled = true;
            listBoxBasket.ItemHeight = 20;
            listBoxBasket.Items.AddRange(new object[] { "BASKET:" });
            listBoxBasket.Location = new Point(1030, 28);
            listBoxBasket.Name = "listBoxBasket";
            listBoxBasket.Size = new Size(221, 650);
            listBoxBasket.TabIndex = 2;
            listBoxBasket.SelectedIndexChanged += listBoxBasket_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelCategoryName);
            groupBox1.Controls.Add(labelQuantity);
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Controls.Add(buttonAddToBasket);
            groupBox1.Controls.Add(buttonShowPicture);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(listBoxProducts);
            groupBox1.Location = new Point(117, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(708, 527);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // labelCategoryName
            // 
            labelCategoryName.AutoSize = true;
            labelCategoryName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoryName.Location = new Point(5, 23);
            labelCategoryName.Name = "labelCategoryName";
            labelCategoryName.Size = new Size(0, 20);
            labelCategoryName.TabIndex = 9;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(195, 23);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(0, 20);
            labelQuantity.TabIndex = 5;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(107, 23);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(0, 20);
            labelPrice.TabIndex = 4;
            // 
            // buttonAddToBasket
            // 
            buttonAddToBasket.Enabled = false;
            buttonAddToBasket.Location = new Point(358, 26);
            buttonAddToBasket.Name = "buttonAddToBasket";
            buttonAddToBasket.Size = new Size(128, 56);
            buttonAddToBasket.TabIndex = 3;
            buttonAddToBasket.Text = "Add to basket";
            buttonAddToBasket.UseVisualStyleBackColor = true;
            buttonAddToBasket.Click += buttonAddToBasket_Click;
            // 
            // buttonShowPicture
            // 
            buttonShowPicture.Enabled = false;
            buttonShowPicture.Location = new Point(358, 88);
            buttonShowPicture.Name = "buttonShowPicture";
            buttonShowPicture.Size = new Size(128, 43);
            buttonShowPicture.TabIndex = 2;
            buttonShowPicture.Text = "Show Image";
            buttonShowPicture.UseVisualStyleBackColor = true;
            buttonShowPicture.Click += buttonShowPicture_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(358, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 20;
            listBoxProducts.Location = new Point(6, 46);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.ScrollAlwaysVisible = true;
            listBoxProducts.Size = new Size(277, 364);
            listBoxProducts.TabIndex = 0;
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // buttonClearBasket
            // 
            buttonClearBasket.Location = new Point(883, 430);
            buttonClearBasket.Name = "buttonClearBasket";
            buttonClearBasket.Size = new Size(101, 55);
            buttonClearBasket.TabIndex = 4;
            buttonClearBasket.Text = "Clear basket";
            buttonClearBasket.UseVisualStyleBackColor = true;
            buttonClearBasket.Click += buttonClearBasket_Click;
            // 
            // buttonDeleteItem
            // 
            buttonDeleteItem.Enabled = false;
            buttonDeleteItem.Location = new Point(883, 341);
            buttonDeleteItem.Name = "buttonDeleteItem";
            buttonDeleteItem.Size = new Size(101, 50);
            buttonDeleteItem.TabIndex = 5;
            buttonDeleteItem.Text = "Delete item";
            buttonDeleteItem.UseVisualStyleBackColor = true;
            buttonDeleteItem.Click += buttonDeleteItem_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(831, 61);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 6;
            label12.Text = "Total sum:";
            // 
            // labelTotalSum
            // 
            labelTotalSum.AutoSize = true;
            labelTotalSum.Location = new Point(913, 61);
            labelTotalSum.Name = "labelTotalSum";
            labelTotalSum.Size = new Size(17, 20);
            labelTotalSum.TabIndex = 7;
            labelTotalSum.Text = "0";
            // 
            // buttonMakePurchase
            // 
            buttonMakePurchase.Enabled = false;
            buttonMakePurchase.Location = new Point(883, 241);
            buttonMakePurchase.Name = "buttonMakePurchase";
            buttonMakePurchase.Size = new Size(101, 51);
            buttonMakePurchase.TabIndex = 8;
            buttonMakePurchase.Text = "Make a purchase";
            buttonMakePurchase.UseVisualStyleBackColor = true;
            buttonMakePurchase.Click += buttonMakePurchase_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 678);
            Controls.Add(buttonMakePurchase);
            Controls.Add(labelTotalSum);
            Controls.Add(label12);
            Controls.Add(buttonDeleteItem);
            Controls.Add(buttonClearBasket);
            Controls.Add(groupBox1);
            Controls.Add(listBoxBasket);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            FormClosing += Main_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ListBox listBoxBasket;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private GroupBox groupBox1;
        private Button buttonShowPicture;
        private PictureBox pictureBox1;
        private ListBox listBoxProducts;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button buttonAddToBasket;
        private Label labelQuantity;
        private Label labelPrice;
        private Button buttonClearBasket;
        private Button buttonDeleteItem;
        private Label label12;
        private Label labelTotalSum;
        private Button buttonMakePurchase;
        private Label labelCategoryName;
    }
}