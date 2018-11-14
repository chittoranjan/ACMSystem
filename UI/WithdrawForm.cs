using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.Context;
using ACM.Models;

namespace ACM.UI
{
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private AcmDbContext _db;
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            _db=new AcmDbContext();
            Withdraw withdraw=new Withdraw();
            withdraw.Amount = Convert.ToDecimal(txtBoxWithdrawAmount.Text);
            withdraw.WithdrowDateTime = dateTimePickerWithdraw.Value;
            withdraw.Purpose = txtBoxPurpose.Text;
            if (withdraw.Amount>0 && withdraw.Purpose!=null && withdraw.WithdrowDateTime!=null)
            {
                _db.Withdraws.Add(withdraw);
                _db.SaveChanges();
                MessageBox.Show("Successfully withdrawn");
            }
            else
            {
                MessageBox.Show("Failed to withdraw!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBoxPurpose.Clear();
            txtBoxWithdrawAmount.Clear();
            this.Close();
        }
    }
}
