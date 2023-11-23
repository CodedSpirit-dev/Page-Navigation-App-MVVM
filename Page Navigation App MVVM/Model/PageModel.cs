using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_Navigation_App_MVVM.Model
{
    public class PageModel
    {
        public int CostumerCount { get; set; }
        public int ProductStatus {  get; set; }
        public DateOnly OrderDate { get; set; }
        public decimal TransactionAmount { get; set; }
        public TimeOnly ShipmentDelivery {  get; set; }
        public bool LocationStatus { get; set; }
    }
}
