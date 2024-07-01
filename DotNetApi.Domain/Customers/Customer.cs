using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetApi.Domain.Customers
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        public int id { get; private set; }
        public string federaltaxnumber { get; private set; }
        public string name { get; private set; }
        public string email { get; private set; }
        public string phone { get; private set; }
        public string? neighborhood { get; private set; }
        public string? city { get; private set; }
        public int? batch { get; private set; }
        public string? complement { get; private set; }

        public Customer()
        {

        }

        public Customer(string name, string federaltaxnumber, string email, string phone)
        {
            this.federaltaxnumber = federaltaxnumber;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }
    }
}
