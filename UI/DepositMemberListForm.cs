using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.Context;
using ACM.Models;

namespace ACM.UI
{
    public partial class DepositMemberListForm : Form
    {
        public DepositMemberListForm()
        {
            InitializeComponent();
            LoadDataGridView();
        }
        private AcmDbContext _db;
        private void LoadDataGridView()
        {
            try
            {
                _db = new AcmDbContext();

                List<DepositMemberList> depositMemberList = _db.DepositMemberLists.Include(c=>c.Member).ToList();
                var dgvList = (from memberList in depositMemberList
                    select new
                    {
                        Name = memberList.Member.Name,
                        MobileNo = memberList.Member.MobileNo,
                        JoinDate = memberList.Member.CreateDateTime,
                        memberList.DepositStartDate

                    }).ToList();
                        
                dataGridViewDepositMemberList.DataSource = dgvList;
                var dataGridViewColumn = dataGridViewDepositMemberList.Columns["Id"];
                if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Get an exception. The exception is -" + Environment.NewLine + ex.ToString());
            }

        }
        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            try
            {
                _db = new AcmDbContext();
                var serchTxt = txtBoxMemberSearch.Text;

                var member = _db.DepositMemberLists.Include(d=>d.Member).Where(c => c.Member.MobileNo.StartsWith(serchTxt) || c.Member.Name.StartsWith(serchTxt)).ToList();
                if (member.Count == 0)
                {
                    MessageBox.Show("Have not any deposit member whth this information! Please input valid information!");
                    return;
                }
                dataGridViewDepositMemberList.Refresh();
                var srcDepositMember=(from srcMem in member 
                select new 
                {
                    Name = srcMem.Member.Name,
                    MobileNo = srcMem.Member.MobileNo,
                    JoinDate = srcMem.Member.CreateDateTime,
                    srcMem.DepositStartDate
                }).ToList();
                dataGridViewDepositMemberList.DataSource = srcDepositMember;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Get an exception. The exception is -" + Environment.NewLine + ex.ToString());
            }
        }

        private void dataGridViewDepositMemberList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewDepositMemberList.Rows[e.RowIndex].Cells["slNo"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnMemberListClose_Click(object sender, EventArgs e)
        {
            txtBoxMemberSearch.Clear();
            this.Close();
        }
    }
}
