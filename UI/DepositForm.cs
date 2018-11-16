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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private AcmDbContext _db;
        private int _memberId;
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            try
            {
                _db = new AcmDbContext();
                var serchTxt = txtBoxMemberSearch.Text;

                var member = _db.Members.FirstOrDefault(c => c.MobileNo == serchTxt || c.Name == serchTxt);
                if (member == null)
                {
                    MessageBox.Show("Have not any member whth this information! Please input valid information!");
                }
                else
                {
                    txtBoxMemberName.Text = member.Name;
                    txtBoxMemberMobileNo.Text = member.MobileNo;
                    txtBoxDepositAmount.ReadOnly = false;
                    btnDeposit.Enabled = true;
                    _memberId = member.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Get an exception. The exception is -" + Environment.NewLine + ex.ToString());
            }
            
            
        }
        
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBoxDepositAmount.Text)<=0 || txtBoxDepositAmount.Text=="")
                {
                    MessageBox.Show("Provided amount is not a right value");
                    return;
                }

                Deposit deposit = new Deposit();
                deposit.MemberId = _memberId;
                deposit.Amount = Convert.ToDecimal(txtBoxDepositAmount.Text);
                deposit.DepositDateTime = depositDateTimePicker.Value;

                if (deposit.Amount > 0 && deposit.MemberId > 0 && deposit.DepositDateTime != null)
                {
                    _db = new AcmDbContext();
                    _db.Deposits.Add(deposit);
                    _db.SaveChanges();

                    ClearTextBox();
                    MessageBox.Show("Deposit successfully saved!");
                }
                else
                {
                    MessageBox.Show("Fail to save! Please check your input value!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Get an exception. The exception is -" + Environment.NewLine + ex.ToString());
            }
           

        }

        private void ClearTextBox()
        {
            txtBoxDepositAmount.Clear();
            depositDateTimePicker.Value=DateTime.Now;
            txtBoxMemberSearch.Clear();
            txtBoxMemberName.Clear();
            txtBoxMemberMobileNo.Clear();
            txtBoxDepositAmount.ReadOnly = true;
            btnDeposit.Enabled = false;
            _memberId = 0;

        }

        private void btnDepositCancel_Click(object sender, EventArgs e)
        {
           ClearTextBox();
            this.Close();
        }
    }
}
