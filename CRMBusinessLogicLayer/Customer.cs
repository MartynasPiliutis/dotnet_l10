using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    public class Customer
    {
       

        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                if (FirstName == "" || LastName == "")
                {
                    return LastName + FirstName;
                }
                else return LastName + "," + FirstName; 
            }
        }
        public string EmailAdress { get; set; }
        public string HGomeAddress { get; set; }
        public string WorkAddress { get; set; }

        public Customer()
        {

        }

        public Customer(int CustomerId)
        {
            CustomerId = CustomerID;
        }

        public int CustomerId { get; private set; } //private set nebeduos redaguoti vartotojams customerID po to kai jis jau sukurtas

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;
            return isValid;
        }

        public bool Save()
        {
            //Code that saves the defined customer
            return true;
        }

        public Customer Retrieve(int CustomerID)
        {
            //Code that retrieves the defined customer
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            //Code that retrieves all of the customers
            return new List<Customer>();
        }
    }
}
