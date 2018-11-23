namespace ACM.UI
{
    partial class MemberListForm
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
            this.btnMemberSearch = new System.Windows.Forms.Button();
            this.txtBoxMemberSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewMemberList = new System.Windows.Forms.DataGridView();
            this.btnMemberListClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.Location = new System.Drawing.Point(788, 12);
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.Size = new System.Drawing.Size(75, 23);
            this.btnMemberSearch.TabIndex = 0;
            this.btnMemberSearch.Text = "Search";
            this.btnMemberSearch.UseVisualStyleBackColor = true;
            this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
            // 
            // txtBoxMemberSearch
            // 
            this.txtBoxMemberSearch.Location = new System.Drawing.Point(586, 15);
            this.txtBoxMemberSearch.Name = "txtBoxMemberSearch";
            this.txtBoxMemberSearch.Size = new System.Drawing.Size(196, 20);
            this.txtBoxMemberSearch.TabIndex = 1;
            // 
            // dataGridViewMemberList
            // 
            this.dataGridViewMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemberList.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewMemberList.Name = "dataGridViewMemberList";
            this.dataGridViewMemberList.ReadOnly = true;
            this.dataGridViewMemberList.RowHeadersVisible = false;
            this.dataGridViewMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMemberList.Size = new System.Drawing.Size(860, 366);
            this.dataGridViewMemberList.TabIndex = 2;
            // 
            // btnMemberListClose
            // 
            this.btnMemberListClose.Location = new System.Drawing.Point(797, 426);
            this.btnMemberListClose.Name = "btnMemberListClose";
            this.btnMemberListClose.Size = new System.Drawing.Size(75, 23);
            this.btnMemberListClose.TabIndex = 0;
            this.btnMemberListClose.Text = "Close";
            this.btnMemberListClose.UseVisualStyleBackColor = true;
            this.btnMemberListClose.Click += new System.EventHandler(this.btnMemberListClose_Click);
            // 
            // MemberListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridViewMemberList);
            this.Controls.Add(this.txtBoxMemberSearch);
            this.Controls.Add(this.btnMemberListClose);
            this.Controls.Add(this.btnMemberSearch);
            this.Name = "MemberListForm";
            this.Text = "Member List Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMemberSearch;
        private System.Windows.Forms.TextBox txtBoxMemberSearch;
        private System.Windows.Forms.DataGridView dataGridViewMemberList;
        private System.Windows.Forms.Button btnMemberListClose;
    }
}