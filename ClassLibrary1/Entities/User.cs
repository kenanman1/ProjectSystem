using Microsoft.EntityFrameworkCore;

[Index("Login", IsUnique = true, Name = "Login_IX")]
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Mail { get; set; }
    public List<Orders> Orders { get; set; }

}