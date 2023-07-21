namespace PrimeiraAPI.Models.ViewModel;

public class EmployeesViewModel
{
    public Guid Id { get; set; }
    public string UserName { get; private set; }

    public EmployeesViewModel(Guid id, string userName)
    {
        Id = id;
        UserName = userName;
    }
}
