using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public DateTime CreateDateTime { get; set; }
        public List<DepositMemberList> DepositMemberLists { get; set; }
        public List<MemberFeeAmount> MemberFeeAmounts { get; set; }
    }
}
