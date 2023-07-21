using PrimeiraAPI.Models.Employees;
using PrimeiraAPI.Models.InputModel;

namespace PrimeiraAPI.Services.Interfaces;

public interface IEmployeesService
{
    List<Employees> GetAll();
    Employees GetById(Guid id);
    bool Created(Employees employees);
    bool Update(Guid id, EmployeesInputModelUpdate employees);
    bool Delete(Guid id);
}
