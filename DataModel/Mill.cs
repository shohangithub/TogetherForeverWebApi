using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class Mill
    {
        public Guid MillId { get; set; }
        public Guid MemberId { get; set; }
        public DateTime MillDate { get; set; }
        public bool BreakFast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }
        public string ManagerId { get; set; }
        public string MemberName { get; set; }
        public string BreakFastFlag => "B";
        public string BreakFastColor => BreakFast ? "Green" : "Red";
        public string LunchFlag => "L";
        public string LunchColor => Lunch ? "Green" : "Red";
        public string DinnerFlag => "D";
        public string DinnerColor => Dinner ? "Green" : "Red";
        public DateTime AddedDate { get; set; }
        public Guid AddedBy { get; set; }
    }
}
