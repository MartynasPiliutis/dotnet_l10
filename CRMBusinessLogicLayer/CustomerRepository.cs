using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAdress = "vardas.pavarde@mail.com";
                customer.FirstName = "Vardas";
                customer.LastName = "Pavarde";
            }
            return customer;
        }
    }
}
