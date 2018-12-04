using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.Context;
using ACM.Models;

namespace ACM.UI
{
    public partial class MemberDepositDetailsForm : Form
    {
        public MemberDepositDetailsForm(int id)
        {
            InitializeComponent();
            GetValueFromEmpId(id);
        }

        private AcmDbContext _db;
        private void GetValueFromEmpId(int id)
        {
            try
            {
                _db = new AcmDbContext();
                var memberInfo = _db.Members.Find(id);
                if (memberInfo != null)
                {
                    txtBoxMemberName.Text = memberInfo.Name;
                    txtBoxMemberMobileNo.Text = memberInfo.MobileNo;
                }

                var memberFeeAmount = _db.MemberFeeAmounts.FirstOrDefault(c => c.MemberId == id);
                if (memberFeeAmount != null)
                {
                    txtBoxDepositFeeAmount.Text = memberFeeAmount.FeeAmount.ToString(CultureInfo.InvariantCulture);
                }

                var memberDepositHistory = _db.Deposits.Where(c => c.MemberId == id).ToList();
                if (memberDepositHistory.Count>0)
                {
                    
                    var dgvList = (from depositList in memberDepositHistory
                        select new
                        {
                            depositList.Id,
                            depositList.Amount,
                            depositList.DepositDateTime,
                            
                        }).ToList();

                    dataGridViewMemberDetails.DataSource = dgvList;
                    var dataGridViewColumn = dataGridViewMemberDetails.Columns["Id"];
                    if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
                    
                    if (memberFeeAmount != null)
                    {
                        var totalPay = memberDepositHistory.Sum(s => Convert.ToDecimal(s.Amount));
                        var amount = memberFeeAmount.FeeAmount;
                        txtDueAmount.Text = (amount - (double) totalPay).ToString(CultureInfo.InvariantCulture);
                        txtBoxTotalPay.Text = totalPay.ToString(CultureInfo.InvariantCulture);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get an exception. The exception is -" + Environment.NewLine + ex.ToString());
            }
            
        }
        private void dataGridViewMemberDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewMemberDetails.Rows[e.RowIndex].Cells["slNo"].Value = (e.RowIndex + 1).ToString();
        }
        private void btnCancelMemberDetails_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
