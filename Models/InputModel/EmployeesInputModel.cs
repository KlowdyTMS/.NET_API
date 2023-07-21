namespace PrimeiraAPI.Models.InputModel;

public class EmployeesInputModelCreated
{
    public string UserName { get; private set; }
    public string Password { get; private set; }

    public EmployeesInputModelCreated(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }
}

public class EmployeesInputModelUpdate
{
    public string UserName { get; private set; }

    public EmployeesInputModelUpdate(string userName)
    {
        UserName = userName;
    }
}