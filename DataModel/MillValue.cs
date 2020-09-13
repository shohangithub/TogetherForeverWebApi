using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class MillValue
    {
        public Guid MessId { get; set; }
        public float BreakFast { get; set; }
        public float Lunch { get; set; }
        public float Dinner { get; set; }
        public DateTime AddedDate { get; set; }
        public Guid AddedBy { get; set; }
    }
}
