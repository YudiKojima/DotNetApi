namespace DotNetApi.Domain.Customers
{
    public interface ICustomerRepository
    {
        void Create(Customer customer);
        List<Customer> Get();
    }
}
