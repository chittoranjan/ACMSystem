using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.Context;

namespace ACM.UI
{
    public partial class MemberListForm : Form
    {
        public MemberListForm()
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
                var memberList = _db.Members.ToList();
                dataGridViewMemberList.DataSource = memberList;
                var dataGridViewColumn = dataGridViewMemberList.Columns["Id"];
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

                var member = _db.Members.Where(c => c.MobileNo.StartsWith(serchTxt) || c.Name.StartsWith(serchTxt)).ToList();
                if (member.Count==0)
                {
                    MessageBox.Show("Have not any member whth this information! Please input valid information!");
                    return;
                }
                dataGridViewMemberList.Refresh();
                dataGridViewMemberList.DataSource = member;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Get an exception. The exception is -" + Environment.NewLine + ex.ToString());
            }
        }

        private void btnMemberListClose_Click(object sender, EventArgs e)
        {
            txtBoxMemberSearch.Clear();
            this.Close();
        }
    }
}
