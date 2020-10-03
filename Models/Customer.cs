using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamWebApp.Models
{
    public class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string CustManager { get; set; }

    }
    public override string ToString()
        {
            return $"<p>Customer Id: {CustId}</P><p>Customer Name: {CustName}</p><p>Customer Address: {CustAddress}</p><p>Customer Manager: {CustManager}</p>";
        }
}
