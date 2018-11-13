namespace ACM.UI
{
    partial class DepositForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMemberMobileNo = new System.Windows.Forms.TextBox();
            this.txtBoxMemberName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depositDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBoxMemberSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnDepositCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxMemberMobileNo);
            this.groupBox1.Controls.Add(this.txtBoxMemberName);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 230);
            this.groupBox1.TabIndex = 0;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.depositDateTimePicker);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBoxDepositAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(452, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 230);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposit Info";
            // 
            // depositDateTimePicker
            // 
            this.depositDateTimePicker.Location = new System.Drawing.Point(118, 94);
            this.depositDateTimePicker.Name = "depositDateTimePicker";
            this.depositDateTimePicker.Size = new System.Drawing.Size(217, 20);
            this.depositDateTimePicker.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Amount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Date :";
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
            // txtBoxDepositAmount
            // 
            this.txtBoxDepositAmount.Location = new System.Drawing.Point(118, 46);
            this.txtBoxDepositAmount.Name = "txtBoxDepositAmount";
            this.txtBoxDepositAmount.ReadOnly = true;
            this.txtBoxDepositAmount.Size = new System.Drawing.Size(217, 20);
            this.txtBoxDepositAmount.TabIndex = 2;
            this.txtBoxDepositAmount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtBoxMemberSearch
            // 
            this.txtBoxMemberSearch.Location = new System.Drawing.Point(504, 27);
            this.txtBoxMemberSearch.Name = "txtBoxMemberSearch";
            this.txtBoxMemberSearch.Size = new System.Drawing.Size(250, 20);
            this.txtBoxMemberSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Member";
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(784, 24);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(88, 23);
            this.btnSearchMember.TabIndex = 1;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Enabled = false;
            this.btnDeposit.Location = new System.Drawing.Point(784, 372);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnDepositCancel
            // 
            this.btnDepositCancel.Location = new System.Drawing.Point(703, 372);
            this.btnDepositCancel.Name = "btnDepositCancel";
            this.btnDepositCancel.Size = new System.Drawing.Size(75, 23);
            this.btnDepositCancel.TabIndex = 5;
            this.btnDepositCancel.Text = "Cancel";
            this.btnDepositCancel.UseVisualStyleBackColor = true;
            this.btnDepositCancel.Click += new System.EventHandler(this.btnDepositCancel_Click);
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnDepositCancel);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMemberSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DepositForm";
            this.Text = "Deposit Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxMemberSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMemberMobileNo;
        private System.Windows.Forms.TextBox txtBoxMemberName;
        private System.Windows.Forms.DateTimePicker depositDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxDepositAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnDepositCancel;
    }
}