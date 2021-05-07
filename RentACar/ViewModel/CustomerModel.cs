using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.ViewModel
{
    public class CustomerModel
    {
        public string customerId { get; set; }
        public string customerName { get; set; }

        public System.DateTime customerBirthDate { get; set; }
        public string customerMail { get; set; }
    }
}