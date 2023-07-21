using AutoMapper;
using PrimeiraAPI.Models.Employees;
using PrimeiraAPI.Models.InputModel;
using PrimeiraAPI.Models.ViewModel;

namespace PrimeiraAPI.Mappers;

public class EmployeesMapper: Profile
{
	public EmployeesMapper()
	{
		CreateMap<EmployeesInputModelCreated, Employees>();

		CreateMap<Employees, EmployeesViewModel>();
	}
}
