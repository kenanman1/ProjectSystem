using System.ComponentModel.DataAnnotations.Schema;
public class Orders
{
    public int Id { get; set; }
    public double Price { get; set; }
    [Column(TypeName = "date")]
    public DateTime date { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }

}