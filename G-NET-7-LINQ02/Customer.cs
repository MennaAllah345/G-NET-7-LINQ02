using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_LINQ02
{
    internal class Customer
    {
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public List<Order> Orders { get; set; }
    }
}
