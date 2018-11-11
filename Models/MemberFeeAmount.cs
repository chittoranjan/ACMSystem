using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Models
{
    public class MemberFeeAmount
    {
        public int Id { get; set; }
        public double FeeAmount { get; set; }

        [ForeignKey ("Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        
    }
}
