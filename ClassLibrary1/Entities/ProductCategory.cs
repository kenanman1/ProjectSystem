using Microsoft.EntityFrameworkCore;

[Index("Name", IsUnique = true)]
public class ProductCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Product> product { get; set; }
}