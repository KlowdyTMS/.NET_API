using Infra.Data;
using PrimeiraAPI.Models.Employees;
using PrimeiraAPI.Models.InputModel;
using PrimeiraAPI.Services.Interfaces;

namespace PrimeiraAPI.Services;

public class EmployeesService: IEmployeesService
{
    private readonly ApplicationDbContext _context;

    public EmployeesService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Employees> GetAll()
    {
        List<Employees> employees = _context.Employees.Where(e => e.isDeleted == false).ToList();
        return employees;
    }

    public Employees GetById(Guid id)
    {
        var employee = _context.Employees.FirstOrDefault(e => e.Id == id && e.isDeleted == false);

        if (employee == null)
        {
            throw new Exception("Usuário não existe");
        }

        return employee;
    }


    public bool Created(Employees employees)
    {
        _context.Employees.Add(employees);
        _context.SaveChanges();
        return true;
    }

    public bool Update(Guid id, EmployeesInputModelUpdate employees)
    {
        var existingEmployee = _context.Employees.Find(id);

        if(existingEmployee == null)
        {
            throw new Exception("Usuário não existe");
        }

        existingEmployee.UpdatedEmployee(employees.UserName);

        _context.Entry(existingEmployee).CurrentValues.SetValues(employees);
        _context.SaveChanges();

        return true;
    }

    public bool Delete(Guid id)
    {
        var existingEmployee = _context.Employees.Find(id);

        if (existingEmployee == null)
        {
            throw new Exception("Usuário não existe");
        }

        existingEmployee.MarkAsDeleted();
        _context.SaveChanges();

        return true;
    }
}
