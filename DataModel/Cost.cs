using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class Cost
    {
        public Guid CostId { get; set; }
        public DateTime CostingDate { get; set; }
        public string CostHead { get; set; }
        public decimal Amount { get; set; }
        public Guid CostBy { get; set; }
        public string CostByName { get; set; }
        public DateTime AddedDate { get; set; }
        public Guid AddedBy { get; set; }
    }
}
