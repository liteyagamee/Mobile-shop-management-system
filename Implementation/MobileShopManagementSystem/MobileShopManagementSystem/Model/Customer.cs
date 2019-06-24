using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopManagementSystem.Model
{
    public class Customer
    {
        public int CustId
        { get; set; }
        public string Name
        { get; set; }
        public string Address
        { get; set; }
        public string Email
        { get; set; }
        public string Phone
        { get; set; }
        public int Uid
        { get; set; }
    }
}
