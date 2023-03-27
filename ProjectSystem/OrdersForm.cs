using ClassLibrary1;

namespace ProjectSystem
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            Task.Run(() => ShowOrders());
        }
        private async Task ShowOrders()
        {
            List<Orders> orders = await Database.GetOrders(Settings1.Default.UserId);
            foreach (var item in orders)
            {
                listBoxOrders.Items.Add($"Order Id - {item.Id}; Price - {item.Price}; Date - {item.date.ToShortDateString()}");
            }
        }
    }
}
