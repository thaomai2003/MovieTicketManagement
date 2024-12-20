namespace MovieTicketManagementSystem
{
    partial class RegForm
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
            this.reg_signinBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_btn = new System.Windows.Forms.Button();
            this.reg_showPass = new System.Windows.Forms.CheckBox();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.reg_cPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reg_signinBtn
            // 
            this.reg_signinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.reg_signinBtn.FlatAppearance.BorderSize = 0;
            this.reg_signinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.reg_signinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.reg_signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_signinBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_signinBtn.ForeColor = System.Drawing.Color.White;
            this.reg_signinBtn.Location = new System.Drawing.Point(31, 738);
            this.reg_signinBtn.Name = "reg_signinBtn";
            this.reg_signinBtn.Size = new System.Drawing.Size(341, 45);
            this.reg_signinBtn.TabIndex = 20;
            this.reg_signinBtn.Text = "Sign in here";
            this.reg_signinBtn.UseVisualStyleBackColor = false;
            this.reg_signinBtn.Click += new System.EventHandler(this.reg_signinBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 704);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Already have an account?";
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.reg_btn.FlatAppearance.BorderSize = 0;
            this.reg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.reg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.ForeColor = System.Drawing.Color.White;
            this.reg_btn.Location = new System.Drawing.Point(31, 530);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(341, 45);
            this.reg_btn.TabIndex = 18;
            this.reg_btn.Text = "REGISTER";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // reg_showPass
            // 
            this.reg_showPass.AutoSize = true;
            this.reg_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_showPass.Location = new System.Drawing.Point(32, 473);
            this.reg_showPass.Name = "reg_showPass";
            this.reg_showPass.Size = new System.Drawing.Size(148, 24);
            this.reg_showPass.TabIndex = 17;
            this.reg_showPass.Text = "Show Password";
            this.reg_showPass.UseVisualStyleBackColor = true;
            this.reg_showPass.CheckedChanged += new System.EventHandler(this.reg_showPass_CheckedChanged);
            // 
            // reg_password
            // 
            this.reg_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_password.Location = new System.Drawing.Point(32, 325);
            this.reg_password.Name = "reg_password";
            this.reg_password.PasswordChar = '*';
            this.reg_password.Size = new System.Drawing.Size(341, 35);
            this.reg_password.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // reg_username
            // 
            this.reg_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_username.Location = new System.Drawing.Point(32, 227);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(341, 35);
            this.reg_username.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "REGISTRATION FORM";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(369, 10);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 26);
            this.close.TabIndex = 11;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // reg_cPassword
            // 
            this.reg_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_cPassword.Location = new System.Drawing.Point(32, 425);
            this.reg_cPassword.Name = "reg_cPassword";
            this.reg_cPassword.PasswordChar = '*';
            this.reg_cPassword.Size = new System.Drawing.Size(341, 35);
            this.reg_cPassword.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Confirm Password";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 795);
            this.Controls.Add(this.reg_cPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reg_signinBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.reg_showPass);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg_signinBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.CheckBox reg_showPass;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.TextBox reg_cPassword;
        private System.Windows.Forms.Label label5;
    }
}