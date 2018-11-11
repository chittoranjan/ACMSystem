using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Models
{
    public class DepositMemberList
    {
        public int Id { get; set; }
        public DateTime DepositStartDate { get; set; }

        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
