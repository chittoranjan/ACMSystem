namespace ACM.UI
{
    partial class DepositMemberListForm
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
            this.dataGridViewDepositMemberList = new System.Windows.Forms.DataGridView();
            this.slNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxMemberSearch = new System.Windows.Forms.TextBox();
            this.btnMemberListClose = new System.Windows.Forms.Button();
            this.btnMemberSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepositMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDepositMemberList
            // 
            this.dataGridViewDepositMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepositMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepositMemberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slNo});
            this.dataGridViewDepositMemberList.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewDepositMemberList.Name = "dataGridViewDepositMemberList";
            this.dataGridViewDepositMemberList.ReadOnly = true;
            this.dataGridViewDepositMemberList.RowHeadersVisible = false;
            this.dataGridViewDepositMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepositMemberList.Size = new System.Drawing.Size(860, 366);
            this.dataGridViewDepositMemberList.TabIndex = 6;
            this.dataGridViewDepositMemberList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewDepositMemberList_RowPostPaint);
            // 
            // slNo
            // 
            this.slNo.HeaderText = "Sl No";
            this.slNo.Name = "slNo";
            this.slNo.ReadOnly = true;
            // 
            // txtBoxMemberSearch
            // 
            this.txtBoxMemberSearch.Location = new System.Drawing.Point(586, 15);
            this.txtBoxMemberSearch.Name = "txtBoxMemberSearch";
            this.txtBoxMemberSearch.Size = new System.Drawing.Size(196, 20);
            this.txtBoxMemberSearch.TabIndex = 5;
            // 
            // btnMemberListClose
            // 
            this.btnMemberListClose.Location = new System.Drawing.Point(797, 426);
            this.btnMemberListClose.Name = "btnMemberListClose";
            this.btnMemberListClose.Size = new System.Drawing.Size(75, 23);
            this.btnMemberListClose.TabIndex = 3;
            this.btnMemberListClose.Text = "Close";
            this.btnMemberListClose.UseVisualStyleBackColor = true;
            this.btnMemberListClose.Click += new System.EventHandler(this.btnMemberListClose_Click);
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.Location = new System.Drawing.Point(788, 12);
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.Size = new System.Drawing.Size(75, 23);
            this.btnMemberSearch.TabIndex = 4;
            this.btnMemberSearch.Text = "Search";
            this.btnMemberSearch.UseVisualStyleBackColor = true;
            this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
            // 
            // DepositMemberListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridViewDepositMemberList);
            this.Controls.Add(this.txtBoxMemberSearch);
            this.Controls.Add(this.btnMemberListClose);
            this.Controls.Add(this.btnMemberSearch);
            this.Name = "DepositMemberListForm";
            this.Text = "Deposit Member List Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepositMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDepositMemberList;
        private System.Windows.Forms.DataGridViewTextBoxColumn slNo;
        private System.Windows.Forms.TextBox txtBoxMemberSearch;
        private System.Windows.Forms.Button btnMemberListClose;
        private System.Windows.Forms.Button btnMemberSearch;
    }
}