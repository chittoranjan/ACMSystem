using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.UI;

namespace ACM
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DashBoardForm dashBoardForm=new DashBoardForm();
            dashBoardForm.Show();
        }

        private void btnLogInCancel_Click(object sender, EventArgs e)
        {
            txtBoxUserId.Clear();
            txtBoxPassword.Clear();
        }
    }
}
