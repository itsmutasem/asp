namespace WebApplication.Models;

public class User
{
    public User()
    {
        
    }

    public User(int id)
    {
        this.Id = id;
    }
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
}