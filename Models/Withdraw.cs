using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Models
{
    public class Withdraw
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime WithdrowDateTime { get; set; }
        public string Purpose { get; set; }
    }
}
