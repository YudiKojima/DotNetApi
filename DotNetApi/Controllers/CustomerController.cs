using DotNetApi.Application.Model.Customers;
using DotNetApi.Domain.Customers;
using Microsoft.AspNetCore.Mvc;

namespace DotNetApi.Controllers
{
    [ApiController]
    [Route("api/v1/customer")]
    public class CustomerController(ICustomerRepository customerRepository) : ControllerBase
    {
        private readonly ICustomerRepository customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(customerRepository.Get());
        }

        [HttpPost]
        public IActionResult Post(CustomerDto dto)
        {
            var customer = new Customer(dto.federaltaxnumber, dto.name, dto.email, dto.phone);
            customerRepository.Create(customer);

            return Ok(customer);
        }
    }
}
