using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Models.Employees;
using PrimeiraAPI.Models.InputModel;
using PrimeiraAPI.Models.ViewModel;
using PrimeiraAPI.Services.Interfaces;

namespace PrimeiraAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesService _service;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeesService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
           List<Employees> result = _service.GetAll();
           var viewModel = _mapper.Map<List<EmployeesViewModel>>(result);

           return Ok(viewModel);
            
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                Employees result = _service.GetById(id);
                var viewModel = _mapper.Map<EmployeesViewModel>(result);
                return Ok(viewModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Created(EmployeesInputModelCreated user)
        {
            var employees = _mapper.Map<Employees>(user);

            bool result = _service.Created(employees);

            if(result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, EmployeesInputModelUpdate user)
        {
            bool result = _service.Update(id, user);

            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            bool result = _service.Delete(id);

            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
