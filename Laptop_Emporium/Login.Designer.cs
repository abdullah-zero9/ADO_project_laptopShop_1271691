namespace Laptop_Emporium
{
    partial class Login
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(465, 389);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 27);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SignUp";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(307, 377);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(124, 58);
            this.btnLogin.TabIndex = 32;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(307, 319);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 41);
            this.txtPassword.TabIndex = 29;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 36);
            this.label3.TabIndex = 30;
            this.label3.Text = "Password :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(307, 266);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(300, 41);
            this.txtUserName.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 46);
            this.label1.TabIndex = 28;
            this.label1.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 634);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}