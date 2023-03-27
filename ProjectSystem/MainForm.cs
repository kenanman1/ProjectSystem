using ClassLibrary1;
using System.Text;

namespace ProjectSystem
{
    public partial class MainForm : Form
    {
        static string selectedCategory;
        public MainForm()
        {
            InitializeComponent();
            MessageBox.Show("Welcome");
            Task.Run(() => AddCategories());
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private async Task AddCategories()
        {
            List<ProductCategory> categories = await Database.GetProductCategoriesAsync();
            foreach (var item in categories)
            {
                categoriesToolStripMenuItem.DropDownItems.Add(item.Name);
                categoriesToolStripMenuItem.DropDown.Name = item.Name;
            }
        }

        private async void categoriesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            labelPrice.Text = "";
            labelQuantity.Text = "";
            selectedCategory = e.ClickedItem.Text;
            labelCategoryName.Text = selectedCategory;
            listBoxProducts.Items.Clear();
            List<Product> products = await Database.GetProductsByCategoryAsync(selectedCategory);
            foreach (var item in products)
            {
                listBoxProducts.Items.Add(item.Name);
            }
            buttonShowPicture.Enabled = false;
            buttonAddToBasket.Enabled = false;
        }

        private void buttonShowPicture_Click(object sender, EventArgs e)
        {
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string[] path = currentDir.Split("\\bin");
            DirectoryInfo dir =
                new DirectoryInfo($"{path[0]}\\Pictures\\{listBoxProducts.SelectedItem}.png");
            pictureBox1.Image = Image.FromFile(dir.FullName);
        }

        private async void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex != -1)
            {
                buttonAddToBasket.Enabled = true;
                pictureBox1.Image = null;
                buttonShowPicture.Enabled = true;
                await SetProductInfoAsync();
            }

        }

        private void buttonAddToBasket_Click(object sender, EventArgs e)
        {
            buttonMakePurchase.Enabled = true;
            string[] getPrice = labelPrice.Text.Split(' ');
            string[] getQuantity = labelQuantity.Text.Split(' ');
            if (getQuantity[1] == "0")
                MessageBox.Show("Product is out of stock", "Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                listBoxBasket.Items.Add($"{selectedCategory}: {listBoxProducts.SelectedItem} - {getPrice[1]}");
                int newQuantity = int.Parse(getQuantity[1]) - 1;
                labelQuantity.Text = $"Quantity: {newQuantity}";
                int total = int.Parse(labelTotalSum.Text);
                total += int.Parse(getPrice[1]);
                labelTotalSum.Text = total.ToString();
            }
        }

        private async void buttonClearBasket_Click(object sender, EventArgs e)
        {
            if (listBoxBasket.Items.Count == 1) //if only "BASKET" word
                MessageBox.Show("Basket already empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                listBoxBasket.Items.Clear();
                listBoxBasket.Items.Add("BASKET:");
                labelTotalSum.Text = "0";
                await SetProductInfoAsync();
                buttonMakePurchase.Enabled = false;
            }
        }

        private async Task SetProductInfoAsync()
        {
            int countInBasket = 0;
            List<Product> products = await Database.GetProductsByCategoryAsync(selectedCategory);
            foreach (var item in products)
            {
                if (listBoxProducts.SelectedItem.ToString() == item.Name)
                {
                    foreach (var item2 in listBoxBasket.Items)
                    {
                        if (listBoxBasket.Items.Count > 1
                            && item2.ToString().Contains("BASKET:") == false) //check if there is smth in basket
                        {
                            string[] getName = item2.ToString().Split("- ");
                            if (getName[0].Contains(item.Name))
                                countInBasket++;
                        }
                    }
                    labelPrice.Text = $"Price: {item.Price}";
                    labelQuantity.Text = $"Quantity: {item.Count - countInBasket}";

                }
            }
        }

        private async void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            string[] getPrice = listBoxBasket.SelectedItem.ToString().Split("- ");
            int total = int.Parse(labelTotalSum.Text) - int.Parse(getPrice[1]);
            labelTotalSum.Text = total.ToString();
            listBoxBasket.Items.RemoveAt(listBoxBasket.SelectedIndex);
            await SetProductInfoAsync();
            if (listBoxBasket.Items.Count <= 1)
                buttonMakePurchase.Enabled = false;
        }

        private void listBoxBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBasket.SelectedIndex >= 1)
                buttonDeleteItem.Enabled = true;
            else
                buttonDeleteItem.Enabled = false;
        }

        private async void buttonMakePurchase_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("orders.txt"))
            {
                foreach (var item in listBoxBasket.Items)
                {
                    if (item.ToString().Contains("BASKET:") == false)
                        await writer.WriteLineAsync(item.ToString());
                }
            }

            StringBuilder products = new StringBuilder();
            foreach (var item in listBoxBasket.Items)
            {
                if (item.ToString().Contains("BASKET:") == false)
                {
                    string[] getName = item.ToString().Split(" - ");
                    products.AppendLine(getName[0]);
                }
            }
            DialogResult result = MessageBox.Show(products.ToString(), $"Confirm order? Total sum - {labelTotalSum.Text}",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await Database.MakeOrderAsync(int.Parse(labelTotalSum.Text));
                MessageBox.Show("Thanks for your order", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxBasket.Items.Clear();
                listBoxBasket.Items.Add("BASKET:");
                labelTotalSum.Text = "0";
                await SetProductInfoAsync();
                buttonMakePurchase.Enabled = false;
            }
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new OrdersForm();
            form.ShowDialog();
        }
    }
}