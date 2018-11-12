namespace ACM.UI
{
    partial class CreateMemberForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMemberName = new System.Windows.Forms.TextBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMemberMobileNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelMemberCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDepositFeeAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // txtBoxMemberName
            // 
            this.txtBoxMemberName.Location = new System.Drawing.Point(106, 48);
            this.txtBoxMemberName.Name = "txtBoxMemberName";
            this.txtBoxMemberName.Size = new System.Drawing.Size(217, 20);
            this.txtBoxMemberName.TabIndex = 0;
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.Location = new System.Drawing.Point(785, 338);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(87, 34);
            this.btnCreateMember.TabIndex = 2;
            this.btnCreateMember.Text = "Create";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mobile No :";
            // 
            // txtBoxMemberMobileNo
            // 
            this.txtBoxMemberMobileNo.Location = new System.Drawing.Point(106, 96);
            this.txtBoxMemberMobileNo.Name = "txtBoxMemberMobileNo";
            this.txtBoxMemberMobileNo.Size = new System.Drawing.Size(217, 20);
            this.txtBoxMemberMobileNo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxMemberMobileNo);
            this.groupBox1.Controls.Add(this.txtBoxMemberName);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Info";
            // 
            // btnCancelMemberCreate
            // 
            this.btnCancelMemberCreate.Location = new System.Drawing.Point(692, 338);
            this.btnCancelMemberCreate.Name = "btnCancelMemberCreate";
            this.btnCancelMemberCreate.Size = new System.Drawing.Size(87, 34);
            this.btnCancelMemberCreate.TabIndex = 3;
            this.btnCancelMemberCreate.Text = "Cancel";
            this.btnCancelMemberCreate.UseVisualStyleBackColor = true;
            this.btnCancelMemberCreate.Click += new System.EventHandler(this.btnCancelMemberCreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxDepositFeeAmount);
            this.groupBox2.Location = new System.Drawing.Point(461, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 260);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposit Fee Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Deposit Fee Amount";
            // 
            // txtBoxDepositFeeAmount
            // 
            this.txtBoxDepositFeeAmount.Location = new System.Drawing.Point(138, 45);
            this.txtBoxDepositFeeAmount.Name = "txtBoxDepositFeeAmount";
            this.txtBoxDepositFeeAmount.Size = new System.Drawing.Size(217, 20);
            this.txtBoxDepositFeeAmount.TabIndex = 0;
            // 
            // CreateMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelMemberCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreateMember);
            this.Name = "CreateMemberForm";
            this.Text = "Create Member";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMemberName;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMemberMobileNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelMemberCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDepositFeeAmount;
    }
}