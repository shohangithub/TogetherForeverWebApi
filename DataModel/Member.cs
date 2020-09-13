using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class Member
    {
        public Member()
        {
            AddedDate = DateTime.Now;
        }
        public Guid MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberEmail { get; set; }
        public string MemberContact { get; set; }
        public bool IsManager { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public string Password { get; set; }
        public DateTime AddedDate { get; set; }
        public Guid AddedBy { get; set; }
        public List<Mill> Mills { get; set; }
    }
}
