using ClassLibrary1;
using Microsoft.EntityFrameworkCore;
/// <summary>
/// Represents the use of the database such as creating, deleting, searching, etc.
/// </summary>
public static class Database
{
    public static async Task CreateAccountAsync(string login, string password, string mail, string name)
    {
        using DataContext context = new();
        User user = new User { Login = login, Mail = mail, Password = password, Name = name };
        await context.AddAsync(user);
        await context.SaveChangesAsync();
    }

    public static async Task<User?> SearchUserAsync(string login, string password)
    {
        using DataContext context = new();
        context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var search = await context.Users.FirstOrDefaultAsync(user => user.Login == login && user.Password == password);
        if (search != null)
            return search;
        return null;
    }

    public static async Task<bool> SearchMailAsync(string mail)
    {
        using DataContext context = new();
        context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var search = await context.Users.FirstOrDefaultAsync(user => user.Mail == mail);
        if (search != null)
            return true;
        return false;
    }

    public static async Task<bool> SearchLoginAsync(string login)
    {
        using DataContext context = new();
        context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var search = await context.Users.FirstOrDefaultAsync(user => user.Login == login);
        if (search != null)
            return true;
        return false;
    }

    public static async Task<List<ProductCategory>> GetProductCategoriesAsync()
    {
        using DataContext context = new();
        context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var search = await context.productCategories.ToListAsync();
        return search;
    }

    public static async Task<List<Product>> GetProductsByCategoryAsync(string categoryName)
    {
        using DataContext context = new();
        context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var search = await context.products.Include(p => p.ProductCategory).Where(p => p.ProductCategory.Name == categoryName).ToListAsync();
        return search;
    }

    public static async Task MakeOrderAsync(double price)
    {
        using StreamReader reader = new StreamReader("orders.txt");

        using DataContext context = new();
        Orders orders = new Orders { date = DateTime.Now, Price = price, UserId = Settings1.Default.UserId };
        await context.AddAsync(orders);

        string line;
        while ((line = await reader.ReadLineAsync()) != null) //read data from file and decrease quantity for each product
        {
            string[] delimiters = { ": ", " - " };
            string[] text = line.Split(delimiters, StringSplitOptions.None);
            var product = await context.products.FirstOrDefaultAsync(p => p.ProductCategory.Name == text[0] && p.Name == text[1]);
            product.Count = product.Count - 1;
        }
        await context.SaveChangesAsync();
    }

    public static async Task<List<Orders>> GetOrders(int UserId)
    {
        using DataContext context = new();
        context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        List<Orders> orders = await context.Orders.Where(p => p.UserId == UserId).ToListAsync();
        return orders;
    }

    public static async Task AddCategoryAsync(string name)
    {
        using DataContext context = new();
        ProductCategory category = new ProductCategory { Name = name };
        await context.AddAsync(category);
        await context.SaveChangesAsync();
    }

    public static async Task AddProduct(string name, int count, double price, string categoryName)
    {
        using DataContext context = new();
        var categoryId = await context.productCategories.FirstOrDefaultAsync(p => p.Name == categoryName);
        Product product = new Product { Count = count, Name = name, Price = price, ProductCategoryId = categoryId.Id };
        await context.AddAsync(product);
        await context.SaveChangesAsync();
    }

    public static async Task DeleteProductAsync(string name, string categoryName)
    {
        using DataContext context = new();
        var categoryId = await context.productCategories.FirstOrDefaultAsync(p => p.Name == categoryName);
        var product = await context.products.FirstOrDefaultAsync(p => p.ProductCategory.Id == categoryId.Id && p.Name == name);
        context.products.Remove(product);
        await context.SaveChangesAsync();
    }
    
    public static async Task DeleteCategoryAsync(string categoryName)
    {
        using DataContext context = new();
        var category = await context.productCategories.FirstOrDefaultAsync(p => p.Name == categoryName);
        context.productCategories.Remove(category);
        await context.SaveChangesAsync();
    }
}