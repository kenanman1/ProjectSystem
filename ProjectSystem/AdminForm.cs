namespace ProjectSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string[] path = currentDir.Split("\\bin");
            Directory.CreateDirectory($"{path[0]}\\Pictures");
            Task.Run(() => FillCategoryAsync());
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async Task FillCategoryAsync()
        {
            listBoxCategories.Items.Clear();
            List<ProductCategory> categories = await Database.GetProductCategoriesAsync();
            foreach (var item in categories)
            {
                listBoxCategories.Items.Add(item.Name);
            }
        }

        private async Task FillProductsAsync()
        {
            listBoxProducts.Items.Clear();
            List<Product> products = await Database.GetProductsByCategoryAsync(listBoxCategories.SelectedItem.ToString());
            foreach (var item in products)
            {
                listBoxProducts.Items.Add($"Name - {item.Name}; Price - {item.Price}; Quantity - {item.Count}");
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private async void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedIndex != -1)
            {
                listBoxProducts.Items.Clear();
                textBoxProductName.Enabled = true;
                textBoxQuantity.Enabled = true;
                buttonDeleteCategory.Enabled = true;
                await FillProductsAsync();
            }
        }

        private async void buttonAddCategory_Click(object sender, EventArgs e)
        {
            if (textBoxAddCategory.Text.Length > 0)
            {
                if (listBoxCategories.Items.Contains(textBoxAddCategory.Text))
                {
                    MessageBox.Show("Category already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    await Database.AddCategoryAsync(textBoxAddCategory.Text);
                    await FillCategoryAsync();
                    MessageBox.Show("Category has been added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxAddCategory.Text = "";
                }
            }
        }

        private void textBoxAddCategory_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAddCategory.Text.Length == 1)
            {
                string ch = textBoxAddCategory.Text.ToUpper();
                textBoxAddCategory.Text = ch;
                textBoxAddCategory.SelectionStart = textBoxAddCategory.TextLength;
            }
        }

        private async void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.Items.Contains(textBoxProductName.Text))
            {
                MessageBox.Show("Product already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                await Database.AddProduct(textBoxProductName.Text, int.Parse(textBoxQuantity.Text),
                    double.Parse(textBoxPrice.Text), listBoxCategories.SelectedItem.ToString());
                await FillProductsAsync();
                MessageBox.Show("Product has been added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxProductName.Text = "";
                textBoxPrice.Text = "";
                textBoxQuantity.Text = "";
                buttonAddImage.Text = "Add Image";
                buttonAddImage.Enabled = false;
                buttonAddProduct.Enabled = false;
            }
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProductName.TextLength > 0 && textBoxQuantity.TextLength > 0 && textBoxPrice.TextLength > 0)
                buttonAddImage.Enabled = true;
        }

        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProductName.TextLength > 0 && textBoxQuantity.TextLength > 0 && textBoxPrice.TextLength > 0)
                buttonAddImage.Enabled = true;
            if (textBoxProductName.TextLength == 1)
            {
                string ch = textBoxProductName.Text.ToUpper();
                textBoxProductName.Text = ch;
                textBoxProductName.SelectionStart = textBoxProductName.TextLength;
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProductName.TextLength > 0 && textBoxQuantity.TextLength > 0 && textBoxPrice.TextLength > 0)
                buttonAddImage.Enabled = true;
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteProduct.Enabled = true;
        }

        private async void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteImage();

            string productName = listBoxProducts.SelectedItem.ToString().Substring(7, listBoxProducts.SelectedItem.ToString().IndexOf(";") - 7);
            await Database.DeleteProductAsync(productName, listBoxCategories.SelectedItem.ToString());
            MessageBox.Show("Product has been deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await FillProductsAsync();
            if (listBoxProducts.Items.Count < 1)
                buttonDeleteProduct.Enabled = false;
        }
        private void DeleteImage()
        {
            string productName = listBoxProducts.SelectedItem.ToString().Substring(7, listBoxProducts.SelectedItem.ToString().IndexOf(";") - 7);
            DirectoryInfo dir =
                new DirectoryInfo($"C:\\Users\\USER\\source\\repos\\ProjectSystem\\ProjectSystem\\Pictures\\{productName}.png");
            File.Delete(dir.FullName);
        }

        private async void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            await Database.DeleteCategoryAsync(listBoxCategories.SelectedItem.ToString());
            MessageBox.Show("Category has been deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await FillCategoryAsync();
            listBoxProducts.Items.Clear();
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PNG|*.png";
            DialogResult result = open.ShowDialog();
            string[] files = { };
            string p = open.FileName;
            p = p.Substring(0, p.LastIndexOf('\\'));
            if (result == DialogResult.OK)
                files = Directory.GetFiles($@"{p}", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                if (file == open.FileName)
                {
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;
                    string[] path = currentDir.Split("\\bin");
                    DirectoryInfo dir =
                        new DirectoryInfo($"{path[0]}\\Pictures\\{textBoxProductName.Text}.png");
                    if (File.Exists(dir.FullName))
                    {
                        MessageBox.Show("Product already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        File.Copy($"{file}", dir.FullName);
                        buttonAddImage.Text = "OK";
                        buttonAddImage.Enabled = false;
                        buttonAddProduct.Enabled = true;
                    }
                }
            }
        }
    }
}
