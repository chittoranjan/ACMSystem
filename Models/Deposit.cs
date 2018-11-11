using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Models
{
    public class Deposit
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DepositDateTime { get; set; }

        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
