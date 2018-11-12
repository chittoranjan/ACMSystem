namespace ACM
{
    partial class LogInForm
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
            this.txtBoxUserId = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogInCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Id";
            // 
            // txtBoxUserId
            // 
            this.txtBoxUserId.Location = new System.Drawing.Point(583, 107);
            this.txtBoxUserId.Name = "txtBoxUserId";
            this.txtBoxUserId.Size = new System.Drawing.Size(181, 20);
            this.txtBoxUserId.TabIndex = 0;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(689, 200);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pass Word";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(583, 145);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(181, 20);
            this.txtBoxPassword.TabIndex = 1;
            // 
            // btnLogInCancel
            // 
            this.btnLogInCancel.Location = new System.Drawing.Point(608, 200);
            this.btnLogInCancel.Name = "btnLogInCancel";
            this.btnLogInCancel.Size = new System.Drawing.Size(75, 23);
            this.btnLogInCancel.TabIndex = 3;
            this.btnLogInCancel.Text = "Cancel";
            this.btnLogInCancel.UseVisualStyleBackColor = true;
            this.btnLogInCancel.Click += new System.EventHandler(this.btnLogInCancel_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnLogInCancel);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogInForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUserId;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnLogInCancel;
    }
}

