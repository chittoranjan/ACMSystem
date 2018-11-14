using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACM.UI
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            var createMemberForm=new CreateMemberForm();
            createMemberForm.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositForm=new DepositForm();
            depositForm.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm=new WithdrawForm();
            withdrawForm.Show();
        }

        private void btnMemberFee_Click(object sender, EventArgs e)
        {
            UpdateMemberFeeForm updateMemberFeeForm=new UpdateMemberFeeForm();
            updateMemberFeeForm.Show();
        }
    }
}
