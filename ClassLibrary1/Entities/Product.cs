public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Count { get; set; }
    public ProductCategory ProductCategory { get; set; }
    public int ProductCategoryId { get; set; }
}