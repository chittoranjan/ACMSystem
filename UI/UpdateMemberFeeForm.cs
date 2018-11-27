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
        private int _memberId;
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            try
            {
                _db = new AcmDbContext();
                var serchTxt = txtBoxMemberSearch.Text;

                var member = _db.Members.FirstOrDefault(c => c.MobileNo == serchTxt || c.Name == serchTxt);
                var feeAmount = _db.MemberFeeAmounts.FirstOrDefault(c => c.MemberId == member.Id);
                if (member == null)
                {
                    MessageBox.Show("Have not any member whth this information! Please input valid information!");
                    return;
                }
                    txtBoxMemberName.Text = member.Name;
                    txtBoxMemberMobileNo.Text = member.MobileNo;
                    _memberId = member.Id;
                if (feeAmount!=null) 
                {
                    txtBoxOldFeeAmount.Text = feeAmount.FeeAmount.ToString(CultureInfo.InvariantCulture);
                    _updateFeeId = feeAmount.Id;
                }
                if (feeAmount==null)
                {
                    btnFeeUpdate.Text = "Add";
                }
                txtBoxNewFeeAmount.ReadOnly = false;
                btnFeeUpdate.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Get an exception. The exception is -" + Environment.NewLine + ex.ToString());
            }
            
        }

        private void btnFeeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBoxNewFeeAmount.Text) <= 0 || txtBoxNewFeeAmount.Text == "")
                {
                    MessageBox.Show("New fee amount value is not a right format");
                    return;
                }

                _db = new AcmDbContext();
                var memberFeeAmount = _db.MemberFeeAmounts.FirstOrDefault(c => c.Id == _updateFeeId);

                if (memberFeeAmount != null)
                {
                    memberFeeAmount.FeeAmount = Convert.ToDouble(txtBoxNewFeeAmount.Text);
                    _db.MemberFeeAmounts.Attach(memberFeeAmount);
                    _db.Entry(memberFeeAmount).State = EntityState.Modified;
                    _db.SaveChanges();
                    ClearTextBox();
                    MessageBox.Show("Member fee amount updated successfully");

                }

                if (memberFeeAmount==null)
                {
                    MemberFeeAmount newFeeAmount=new MemberFeeAmount();
                    newFeeAmount.MemberId = _memberId;
                    newFeeAmount.FeeAmount= Convert.ToDouble(txtBoxNewFeeAmount.Text);
                    _db.MemberFeeAmounts.Add(newFeeAmount);
                    _db.SaveChanges();
                    ClearTextBox();
                    
                    MessageBox.Show("Member fee amount added successfully");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Get an exception. The exception is -" + Environment.NewLine + ex.ToString());
            }
            
        }

        private void ClearTextBox()
        {
            txtBoxMemberSearch.Clear();
            txtBoxMemberName.Clear();
            txtBoxMemberMobileNo.Clear();
            txtBoxOldFeeAmount.Clear();
            txtBoxNewFeeAmount.Clear();
            txtBoxNewFeeAmount.ReadOnly = true;
            btnFeeUpdate.Enabled = false;
            _updateFeeId = 0;
            _memberId = 0;
            btnFeeUpdate.Text = "Update";

        }

        private void btnFeeUpdateCancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            this.Close();
        }
    }
}
