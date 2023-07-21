namespace PrimeiraAPI.Models.Employees;

public class Employees
{
    public Guid? Id { get; private set; }
    public string Username { get; private set; }
    public string Password { get; private set; }
    public bool isDeleted { get; private set; } = false;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; private set; }

    public Employees(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public void MarkAsDeleted()
    {
        UpdatedAt = DateTime.UtcNow;
        isDeleted = true;
    }

    public void UpdatedEmployee(string userName)
    {
        Username= userName;
        UpdatedAt= DateTime.UtcNow;
    }
}
