using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    public class Customer
    {

        public string CustomerID { get; set; }
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
    }
}
