using DotNetApi.Domain.Customers;

namespace DotNetApi.Infrastructure.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ConnectionContext context = new ConnectionContext();

        public void Create(Customer customer)
        {
            context.Customer.Add(customer);
            context.SaveChanges();
        }

        public List<Customer> Get()
        {
            return [.. context.Customer];
        }
    }
}
