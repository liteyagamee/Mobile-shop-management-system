using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopManagementSystem.Model
{
    public class Bill
    {
        public int BillId
        { get; set; }
        public int CustId
        { get; set; }
        public DateTime Date
        { get; set; }
        public float TotalAmt
        { get; set; }
        public float Discount
        { get; set; }
        public float GrandTotal
        { get; set; }
        public string Payment
        { get; set; }
    }
}
