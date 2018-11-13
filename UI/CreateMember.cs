﻿using System;
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
            _db=new AcmDbContext();
            Member member = new Member
            {
                Name = txtBoxMemberName.Text,
                MobileNo = txtBoxMemberMobileNo.Text,
                CreateDateTime = DateTime.Now
            };
            if (member.Name!=null && member.MobileNo!=null) 
            {
                _db.Members.Add(member);
                _db.SaveChanges();
            }
            

            if (!string.IsNullOrEmpty(txtBoxDepositFeeAmount.Text))
            {
                MemberFeeAmount memberFeeAmount = new MemberFeeAmount
                {
                    MemberId = member.Id,
                    FeeAmount = Convert.ToDouble(txtBoxDepositFeeAmount.Text)
                };
                _db.MemberFeeAmounts.Add(memberFeeAmount);
                _db.SaveChanges();
            }

        }

        private void btnCancelMemberCreate_Click(object sender, EventArgs e)
        {
            txtBoxMemberName.Clear();
            txtBoxMemberMobileNo.Clear();
            this.Close();
        }
    }
}
