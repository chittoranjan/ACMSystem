using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.Context;
using ACM.Models;

namespace ACM.UI
{
    public partial class UpdateMemberFeeForm : Form
    {
        public UpdateMemberFeeForm()
        {
            InitializeComponent();
        }

        private AcmDbContext _db;
        private int _updateFeeId;
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            _db = new AcmDbContext();
            var serchTxt = txtBoxMemberSearch.Text;

            var member = _db.Members.FirstOrDefault(c => c.MobileNo == serchTxt || c.Name == serchTxt);
            var feeAmount = _db.MemberFeeAmounts.FirstOrDefault(c => c.MemberId == member.Id);
            if (member == null)
            {
                MessageBox.Show("Have not any member whth this information! Please input valid information!");
            }
            else
            {
                txtBoxMemberName.Text = member.Name;
                txtBoxMemberMobileNo.Text = member.MobileNo;
                if (feeAmount != null)
                {
                    txtBoxOldFeeAmount.Text = feeAmount.FeeAmount.ToString(CultureInfo.InvariantCulture);
                    _updateFeeId = feeAmount.Id;
                }
                txtBoxNewFeeAmount.ReadOnly=false;
                btnFeeUpdate.Enabled=true;
                
            }
        }

        private void btnFeeUpdate_Click(object sender, EventArgs e)
        {
            _db=new AcmDbContext();
            var memberFeeAmount=_db.MemberFeeAmounts.FirstOrDefault(c => c.Id == _updateFeeId);
            if (memberFeeAmount != null)
            {
                memberFeeAmount.FeeAmount = Convert.ToDouble(txtBoxNewFeeAmount.Text);
                _db.MemberFeeAmounts.Attach(memberFeeAmount);
                _db.Entry(memberFeeAmount).State=EntityState.Modified;
                _db.SaveChanges();
                MessageBox.Show("Member fee amount updated successfully");
            }
            else
            {
                MessageBox.Show("Failed to update!");
                txtBoxNewFeeAmount.Clear();
            }
        }

        private void btnFeeUpdateCancel_Click(object sender, EventArgs e)
        {
            txtBoxNewFeeAmount.Clear();
            this.Close();
        }
    }
}
