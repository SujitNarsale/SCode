using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCode.Domain_Model
{
    public class CustomerEntity
    {     
            public int CustomerId { get; set; }
            public string CustomerFirstName { get; set; }
            public string CustomerLastName { get; set; }
            public string CustomerAddress { get; set; }
            public string CustomerMobile { get; set; }
            public string CustomerEmail { get; set; }
            public DateTime CustomerBirthdate { get; set; }
            public string CustomerPassword { get; set; }
            public DateTime CreatedOn { get; set; }
    }

}
