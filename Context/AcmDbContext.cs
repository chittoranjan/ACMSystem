using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Models;

namespace ACM.Context
{
    public class AcmDbContext:DbContext

    {
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberFeeAmount> MemberFeeAmounts { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<DepositMemberList> DepositMemberLists { get; set; }
        public DbSet<Withdraw> Withdraws { get; set; }

    }
}
