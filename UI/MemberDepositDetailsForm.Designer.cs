namespace ACM.UI
{
    partial class MemberDepositDetailsForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDepositFeeAmount = new System.Windows.Forms.TextBox();
            this.btnCancelMemberDetails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMemberMobileNo = new System.Windows.Forms.TextBox();
            this.txtBoxMemberName = new System.Windows.Forms.TextBox();
            this.btnNewDeposit = new System.Windows.Forms.Button();
            this.dataGridViewMemberDetails = new System.Windows.Forms.DataGridView();
            this.slNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxTotalPay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDueAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDueAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBoxTotalPay);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxDepositFeeAmount);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 139);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Member Fee Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fee Amount";
            // 
            // txtBoxDepositFeeAmount
            // 
            this.txtBoxDepositFeeAmount.Location = new System.Drawing.Point(138, 36);
            this.txtBoxDepositFeeAmount.Name = "txtBoxDepositFeeAmount";
            this.txtBoxDepositFeeAmount.ReadOnly = true;
            this.txtBoxDepositFeeAmount.Size = new System.Drawing.Size(185, 20);
            this.txtBoxDepositFeeAmount.TabIndex = 0;
            this.txtBoxDepositFeeAmount.Text = "0";
            // 
            // btnCancelMemberDetails
            // 
            this.btnCancelMemberDetails.Location = new System.Drawing.Point(692, 415);
            this.btnCancelMemberDetails.Name = "btnCancelMemberDetails";
            this.btnCancelMemberDetails.Size = new System.Drawing.Size(87, 34);
            this.btnCancelMemberDetails.TabIndex = 6;
            this.btnCancelMemberDetails.Text = "Cancel";
            this.btnCancelMemberDetails.UseVisualStyleBackColor = true;
            this.btnCancelMemberDetails.Click += new System.EventHandler(this.btnCancelMemberDetails_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxMemberMobileNo);
            this.groupBox1.Controls.Add(this.txtBoxMemberName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 221);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Info";
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
            this.txtBoxMemberMobileNo.ReadOnly = true;
            this.txtBoxMemberMobileNo.Size = new System.Drawing.Size(217, 20);
            this.txtBoxMemberMobileNo.TabIndex = 1;
            // 
            // txtBoxMemberName
            // 
            this.txtBoxMemberName.Location = new System.Drawing.Point(106, 48);
            this.txtBoxMemberName.Name = "txtBoxMemberName";
            this.txtBoxMemberName.ReadOnly = true;
            this.txtBoxMemberName.Size = new System.Drawing.Size(217, 20);
            this.txtBoxMemberName.TabIndex = 0;
            // 
            // btnNewDeposit
            // 
            this.btnNewDeposit.Location = new System.Drawing.Point(785, 415);
            this.btnNewDeposit.Name = "btnNewDeposit";
            this.btnNewDeposit.Size = new System.Drawing.Size(87, 34);
            this.btnNewDeposit.TabIndex = 4;
            this.btnNewDeposit.Text = "Deposit";
            this.btnNewDeposit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMemberDetails
            // 
            this.dataGridViewMemberDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMemberDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemberDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slNo});
            this.dataGridViewMemberDetails.Location = new System.Drawing.Point(380, 12);
            this.dataGridViewMemberDetails.Name = "dataGridViewMemberDetails";
            this.dataGridViewMemberDetails.ReadOnly = true;
            this.dataGridViewMemberDetails.RowHeadersVisible = false;
            this.dataGridViewMemberDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMemberDetails.Size = new System.Drawing.Size(492, 386);
            this.dataGridViewMemberDetails.TabIndex = 8;
            this.dataGridViewMemberDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewMemberDetails_RowPostPaint);
            // 
            // slNo
            // 
            this.slNo.HeaderText = "Sl No";
            this.slNo.Name = "slNo";
            this.slNo.ReadOnly = true;
            // 
            // txtBoxTotalPay
            // 
            this.txtBoxTotalPay.Location = new System.Drawing.Point(138, 64);
            this.txtBoxTotalPay.Name = "txtBoxTotalPay";
            this.txtBoxTotalPay.ReadOnly = true;
            this.txtBoxTotalPay.Size = new System.Drawing.Size(185, 20);
            this.txtBoxTotalPay.TabIndex = 0;
            this.txtBoxTotalPay.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Pay";
            // 
            // txtDueAmount
            // 
            this.txtDueAmount.Location = new System.Drawing.Point(138, 92);
            this.txtDueAmount.Name = "txtDueAmount";
            this.txtDueAmount.ReadOnly = true;
            this.txtDueAmount.Size = new System.Drawing.Size(185, 20);
            this.txtDueAmount.TabIndex = 0;
            this.txtDueAmount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Due Amount";
            // 
            // MemberDepositDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridViewMemberDetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelMemberDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewDeposit);
            this.Name = "MemberDepositDetailsForm";
            this.Text = "Member Deposit Details Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDepositFeeAmount;
        private System.Windows.Forms.Button btnCancelMemberDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMemberMobileNo;
        private System.Windows.Forms.TextBox txtBoxMemberName;
        private System.Windows.Forms.Button btnNewDeposit;
        private System.Windows.Forms.DataGridView dataGridViewMemberDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn slNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDueAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTotalPay;
    }
}