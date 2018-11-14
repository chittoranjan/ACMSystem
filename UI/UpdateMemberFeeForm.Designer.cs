namespace ACM.UI
{
    partial class UpdateMemberFeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFeeUpdateCancel = new System.Windows.Forms.Button();
            this.btnFeeUpdate = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMemberSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxOldFeeAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMemberMobileNo = new System.Windows.Forms.TextBox();
            this.txtBoxMemberName = new System.Windows.Forms.TextBox();
            this.txtBoxNewFeeAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFeeUpdateCancel
            // 
            this.btnFeeUpdateCancel.Location = new System.Drawing.Point(703, 393);
            this.btnFeeUpdateCancel.Name = "btnFeeUpdateCancel";
            this.btnFeeUpdateCancel.Size = new System.Drawing.Size(75, 23);
            this.btnFeeUpdateCancel.TabIndex = 12;
            this.btnFeeUpdateCancel.Text = "Cancel";
            this.btnFeeUpdateCancel.UseVisualStyleBackColor = true;
            this.btnFeeUpdateCancel.Click += new System.EventHandler(this.btnFeeUpdateCancel_Click);
            // 
            // btnFeeUpdate
            // 
            this.btnFeeUpdate.Enabled = false;
            this.btnFeeUpdate.Location = new System.Drawing.Point(784, 393);
            this.btnFeeUpdate.Name = "btnFeeUpdate";
            this.btnFeeUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnFeeUpdate.TabIndex = 11;
            this.btnFeeUpdate.Text = "Update";
            this.btnFeeUpdate.UseVisualStyleBackColor = true;
            this.btnFeeUpdate.Click += new System.EventHandler(this.btnFeeUpdate_Click);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(784, 45);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(88, 23);
            this.btnSearchMember.TabIndex = 9;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search Member";
            // 
            // txtBoxMemberSearch
            // 
            this.txtBoxMemberSearch.Location = new System.Drawing.Point(504, 48);
            this.txtBoxMemberSearch.Name = "txtBoxMemberSearch";
            this.txtBoxMemberSearch.Size = new System.Drawing.Size(250, 20);
            this.txtBoxMemberSearch.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBoxNewFeeAmount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBoxOldFeeAmount);
            this.groupBox2.Location = new System.Drawing.Point(452, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 230);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fee Amount Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Current Fee Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name :";
            // 
            // txtBoxOldFeeAmount
            // 
            this.txtBoxOldFeeAmount.Location = new System.Drawing.Point(144, 46);
            this.txtBoxOldFeeAmount.Name = "txtBoxOldFeeAmount";
            this.txtBoxOldFeeAmount.ReadOnly = true;
            this.txtBoxOldFeeAmount.Size = new System.Drawing.Size(217, 20);
            this.txtBoxOldFeeAmount.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxMemberMobileNo);
            this.groupBox1.Controls.Add(this.txtBoxMemberName);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 230);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mobile No :";
            // 
            // txtBoxMemberMobileNo
            // 
            this.txtBoxMemberMobileNo.Location = new System.Drawing.Point(114, 94);
            this.txtBoxMemberMobileNo.Name = "txtBoxMemberMobileNo";
            this.txtBoxMemberMobileNo.ReadOnly = true;
            this.txtBoxMemberMobileNo.Size = new System.Drawing.Size(217, 20);
            this.txtBoxMemberMobileNo.TabIndex = 20;
            this.txtBoxMemberMobileNo.TabStop = false;
            // 
            // txtBoxMemberName
            // 
            this.txtBoxMemberName.Location = new System.Drawing.Point(114, 46);
            this.txtBoxMemberName.Name = "txtBoxMemberName";
            this.txtBoxMemberName.ReadOnly = true;
            this.txtBoxMemberName.Size = new System.Drawing.Size(217, 20);
            this.txtBoxMemberName.TabIndex = 19;
            this.txtBoxMemberName.TabStop = false;
            // 
            // txtBoxNewFeeAmount
            // 
            this.txtBoxNewFeeAmount.Location = new System.Drawing.Point(144, 94);
            this.txtBoxNewFeeAmount.Name = "txtBoxNewFeeAmount";
            this.txtBoxNewFeeAmount.ReadOnly = true;
            this.txtBoxNewFeeAmount.Size = new System.Drawing.Size(217, 20);
            this.txtBoxNewFeeAmount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "New Fee Amount :";
            // 
            // UpdateMemberFeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnFeeUpdateCancel);
            this.Controls.Add(this.btnFeeUpdate);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMemberSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateMemberFeeForm";
            this.Text = "Update Member Fee Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFeeUpdateCancel;
        private System.Windows.Forms.Button btnFeeUpdate;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMemberSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxOldFeeAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMemberMobileNo;
        private System.Windows.Forms.TextBox txtBoxMemberName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNewFeeAmount;
    }
}