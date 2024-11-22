using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using WebApi.ViewModel;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        [HttpPost]
        /*
        public IActionResult Add(string nome, int idade)
        {
            var employee = new Employee(nome, idade);

            _employeeRepository.Add(employee);

            return Ok();
        }*/
        
        public IActionResult Add(EmployeeViewModel employeeView)
        {
            var employee = new Employee(employeeView.nome, employeeView.idade);

            _employeeRepository.Add(employee);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employee = _employeeRepository.Get();
            return Ok(employee);
        }
    }
}
