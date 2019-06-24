using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopManagementSystem.Model
{
    public class Product
    {
        public int ProId
        { get; set; }
        public string ProductName
        { get; set; }
        public string Description
        { get; set; }
        public float Price
        { get; set; }
        public string Model
        { get; set; }
        public string Color
        { get; set; }
        public string Brand
        { get; set; }
        public string IMEI
        { get; set; }
        public int CustId
        { get; set; }
    }
}
