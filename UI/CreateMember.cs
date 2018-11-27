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
    public partial class CreateMemberForm : Form
    {
        public CreateMemberForm()
        {
            InitializeComponent();
        }

        private AcmDbContext _db;
        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBoxMemberName.Text))
                {
                    MessageBox.Show("Please provide member name!");
                    return;
                }
                if (string.IsNullOrEmpty(txtBoxMemberMobileNo.Text))
                {
                    MessageBox.Show("Please provide member mobile no!");
                    return;
                }
                _db = new AcmDbContext();

                Member member = new Member
                {
                    Name = txtBoxMemberName.Text,
                    MobileNo = txtBoxMemberMobileNo.Text,
                    CreateDateTime = DateTime.Now
                };

                if (member.Name != "" && member.MobileNo != "")
                {
                    _db.Members.Add(member);
                    _db.SaveChanges();

                    var feeAmount = Convert.ToDouble(txtBoxDepositFeeAmount.Text);
                    if (feeAmount>0 && member.Id > 0)
                    {
                        MemberFeeAmount memberFeeAmount = new MemberFeeAmount
                        {
                            MemberId = member.Id,
                            FeeAmount = Convert.ToDouble(txtBoxDepositFeeAmount.Text)
                        };
                        _db.MemberFeeAmounts.Add(memberFeeAmount);
                        _db.SaveChanges();
                        ClearTextBox();
                        MessageBox.Show("Member created successfully with fee amount");
                    }
                    else
                    {
                        ClearTextBox();
                        MessageBox.Show("Member created successully but fee amount not created");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create member");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Get an exception. The exception is -" + Environment.NewLine + ex.ToString());
            }
            

        }

        private void ClearTextBox()
        {
            txtBoxMemberName.Clear();
            txtBoxMemberMobileNo.Clear();
            txtBoxDepositFeeAmount.Text = 0.ToString();
        }

        private void btnCancelMemberCreate_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            this.Close();
        }
    }
}
