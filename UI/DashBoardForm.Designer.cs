namespace ACM.UI
{
    partial class DashBoardForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.reportGroupBox = new System.Windows.Forms.GroupBox();
            this.operationGroupBox = new System.Windows.Forms.GroupBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.btnMemberFee = new System.Windows.Forms.Button();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.btnDepositMemberList = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.reportGroupBox.SuspendLayout();
            this.operationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // reportGroupBox
            // 
            this.reportGroupBox.Controls.Add(this.button1);
            this.reportGroupBox.Controls.Add(this.button4);
            this.reportGroupBox.Controls.Add(this.button2);
            this.reportGroupBox.Controls.Add(this.button3);
            this.reportGroupBox.Location = new System.Drawing.Point(65, 316);
            this.reportGroupBox.Name = "reportGroupBox";
            this.reportGroupBox.Size = new System.Drawing.Size(750, 103);
            this.reportGroupBox.TabIndex = 1;
            this.reportGroupBox.TabStop = false;
            this.reportGroupBox.Text = "Reports";
            // 
            // operationGroupBox
            // 
            this.operationGroupBox.Controls.Add(this.btnCreateMember);
            this.operationGroupBox.Controls.Add(this.btnWithdraw);
            this.operationGroupBox.Controls.Add(this.btnDeposit);
            this.operationGroupBox.Controls.Add(this.btnMemberFee);
            this.operationGroupBox.Controls.Add(this.btnMemberList);
            this.operationGroupBox.Controls.Add(this.btnDepositMemberList);
            this.operationGroupBox.Location = new System.Drawing.Point(65, 51);
            this.operationGroupBox.Name = "operationGroupBox";
            this.operationGroupBox.Size = new System.Drawing.Size(750, 199);
            this.operationGroupBox.TabIndex = 1;
            this.operationGroupBox.TabStop = false;
            this.operationGroupBox.Text = "Operations";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.Location = new System.Drawing.Point(34, 29);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(150, 50);
            this.btnCreateMember.TabIndex = 0;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // btnMemberFee
            // 
            this.btnMemberFee.Location = new System.Drawing.Point(577, 29);
            this.btnMemberFee.Name = "btnMemberFee";
            this.btnMemberFee.Size = new System.Drawing.Size(150, 50);
            this.btnMemberFee.TabIndex = 0;
            this.btnMemberFee.Text = "Member Fee";
            this.btnMemberFee.UseVisualStyleBackColor = true;
            // 
            // btnMemberList
            // 
            this.btnMemberList.Location = new System.Drawing.Point(208, 29);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Size = new System.Drawing.Size(150, 50);
            this.btnMemberList.TabIndex = 0;
            this.btnMemberList.Text = "Member List";
            this.btnMemberList.UseVisualStyleBackColor = true;
            // 
            // btnDepositMemberList
            // 
            this.btnDepositMemberList.Location = new System.Drawing.Point(390, 29);
            this.btnDepositMemberList.Name = "btnDepositMemberList";
            this.btnDepositMemberList.Size = new System.Drawing.Size(150, 50);
            this.btnDepositMemberList.TabIndex = 0;
            this.btnDepositMemberList.Text = "Deposit Member List";
            this.btnDepositMemberList.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(34, 113);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(150, 50);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(208, 113);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(150, 50);
            this.btnWithdraw.TabIndex = 0;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.operationGroupBox);
            this.Controls.Add(this.reportGroupBox);
            this.Name = "DashBoardForm";
            this.Text = "Dash Board";
            this.reportGroupBox.ResumeLayout(false);
            this.operationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox reportGroupBox;
        private System.Windows.Forms.GroupBox operationGroupBox;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.Button btnMemberFee;
        private System.Windows.Forms.Button btnMemberList;
        private System.Windows.Forms.Button btnDepositMemberList;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
    }
}