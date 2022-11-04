namespace HW2.Forms
{
    partial class FormAccount
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_go_register = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel_log_front = new System.Windows.Forms.Panel();
            this.lb_pw_login = new System.Windows.Forms.Label();
            this.lb_ac_login = new System.Windows.Forms.Label();
            this.lb_message = new System.Windows.Forms.Label();
            this.panel_log_succeed = new System.Windows.Forms.Panel();
            this.lb_username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_register = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_email_register = new System.Windows.Forms.TextBox();
            this.txt_mobile_register = new System.Windows.Forms.TextBox();
            this.txt_account_register = new System.Windows.Forms.TextBox();
            this.txt_password_register = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_log_front.SuspendLayout();
            this.panel_log_succeed.SuspendLayout();
            this.panel_register.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(179, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 80);
            this.label5.TabIndex = 7;
            this.label5.Text = "LOG IN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_account
            // 
            this.txt_account.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txt_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_account.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_account.ForeColor = System.Drawing.Color.White;
            this.txt_account.Location = new System.Drawing.Point(179, 293);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(297, 28);
            this.txt_account.TabIndex = 1;
            this.txt_account.Tag = "Account";
            this.txt_account.Text = "Account";
            this.txt_account.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_account.Enter += new System.EventHandler(this.txt_account_Enter);
            this.txt_account.Leave += new System.EventHandler(this.txt_account_Leave);
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(179, 391);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(297, 28);
            this.txt_password.TabIndex = 2;
            this.txt_password.Tag = "Password";
            this.txt_password.Text = "Password";
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // btn_go_register
            // 
            this.btn_go_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_go_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(146)))), ((int)(((byte)(106)))));
            this.btn_go_register.FlatAppearance.BorderSize = 0;
            this.btn_go_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go_register.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_go_register.ForeColor = System.Drawing.Color.White;
            this.btn_go_register.Location = new System.Drawing.Point(332, 615);
            this.btn_go_register.Name = "btn_go_register";
            this.btn_go_register.Size = new System.Drawing.Size(144, 32);
            this.btn_go_register.TabIndex = 4;
            this.btn_go_register.TabStop = false;
            this.btn_go_register.Text = "Go Register";
            this.btn_go_register.UseVisualStyleBackColor = false;
            this.btn_go_register.Click += new System.EventHandler(this.btn_go_register_Click);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(74)))), ((int)(((byte)(41)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(179, 548);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(297, 32);
            this.btn_login.TabIndex = 3;
            this.btn_login.TabStop = false;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel_log_front
            // 
            this.panel_log_front.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_log_front.Controls.Add(this.lb_pw_login);
            this.panel_log_front.Controls.Add(this.lb_ac_login);
            this.panel_log_front.Controls.Add(this.lb_message);
            this.panel_log_front.Controls.Add(this.txt_account);
            this.panel_log_front.Controls.Add(this.txt_password);
            this.panel_log_front.Controls.Add(this.btn_go_register);
            this.panel_log_front.Controls.Add(this.btn_login);
            this.panel_log_front.Controls.Add(this.label5);
            this.panel_log_front.Location = new System.Drawing.Point(278, 15);
            this.panel_log_front.Name = "panel_log_front";
            this.panel_log_front.Size = new System.Drawing.Size(659, 742);
            this.panel_log_front.TabIndex = 16;
            // 
            // lb_pw_login
            // 
            this.lb_pw_login.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_pw_login.ForeColor = System.Drawing.Color.Maroon;
            this.lb_pw_login.Location = new System.Drawing.Point(482, 390);
            this.lb_pw_login.Name = "lb_pw_login";
            this.lb_pw_login.Size = new System.Drawing.Size(19, 28);
            this.lb_pw_login.TabIndex = 18;
            this.lb_pw_login.Text = "*";
            this.lb_pw_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_ac_login
            // 
            this.lb_ac_login.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_ac_login.ForeColor = System.Drawing.Color.Maroon;
            this.lb_ac_login.Location = new System.Drawing.Point(482, 293);
            this.lb_ac_login.Name = "lb_ac_login";
            this.lb_ac_login.Size = new System.Drawing.Size(19, 28);
            this.lb_ac_login.TabIndex = 17;
            this.lb_ac_login.Text = "*";
            this.lb_ac_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_message
            // 
            this.lb_message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_message.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_message.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_message.Location = new System.Drawing.Point(175, 622);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(151, 20);
            this.lb_message.TabIndex = 16;
            this.lb_message.Text = "Have no account?";
            this.lb_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_log_succeed
            // 
            this.panel_log_succeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_log_succeed.Controls.Add(this.lb_username);
            this.panel_log_succeed.Controls.Add(this.label3);
            this.panel_log_succeed.Location = new System.Drawing.Point(278, 12);
            this.panel_log_succeed.Name = "panel_log_succeed";
            this.panel_log_succeed.Size = new System.Drawing.Size(659, 745);
            this.panel_log_succeed.TabIndex = 16;
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_username.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_username.Location = new System.Drawing.Point(170, 345);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(326, 80);
            this.lb_username.TabIndex = 11;
            this.lb_username.Text = "ID";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(165, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 96);
            this.label3.TabIndex = 8;
            this.label3.Text = "WELCOM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_register
            // 
            this.panel_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_register.Controls.Add(this.label8);
            this.panel_register.Controls.Add(this.label6);
            this.panel_register.Controls.Add(this.label4);
            this.panel_register.Controls.Add(this.label2);
            this.panel_register.Controls.Add(this.label1);
            this.panel_register.Controls.Add(this.txt_address);
            this.panel_register.Controls.Add(this.txt_email_register);
            this.panel_register.Controls.Add(this.txt_mobile_register);
            this.panel_register.Controls.Add(this.txt_account_register);
            this.panel_register.Controls.Add(this.txt_password_register);
            this.panel_register.Controls.Add(this.btn_register);
            this.panel_register.Controls.Add(this.label7);
            this.panel_register.Location = new System.Drawing.Point(278, 12);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(659, 745);
            this.panel_register.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(484, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(484, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(484, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(484, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(484, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_address.ForeColor = System.Drawing.Color.White;
            this.txt_address.Location = new System.Drawing.Point(181, 469);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(297, 28);
            this.txt_address.TabIndex = 9;
            this.txt_address.Tag = "Address";
            this.txt_address.Text = "Address";
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_address.Enter += new System.EventHandler(this.txt_address_Enter);
            this.txt_address.Leave += new System.EventHandler(this.txt_address_Leave);
            // 
            // txt_email_register
            // 
            this.txt_email_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txt_email_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email_register.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_email_register.ForeColor = System.Drawing.Color.White;
            this.txt_email_register.Location = new System.Drawing.Point(181, 415);
            this.txt_email_register.Name = "txt_email_register";
            this.txt_email_register.Size = new System.Drawing.Size(297, 28);
            this.txt_email_register.TabIndex = 8;
            this.txt_email_register.Tag = "Email";
            this.txt_email_register.Text = "Email";
            this.txt_email_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_email_register.Enter += new System.EventHandler(this.txt_email_register_Enter);
            this.txt_email_register.Leave += new System.EventHandler(this.txt_email_register_Leave);
            // 
            // txt_mobile_register
            // 
            this.txt_mobile_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mobile_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txt_mobile_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mobile_register.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_mobile_register.ForeColor = System.Drawing.Color.White;
            this.txt_mobile_register.Location = new System.Drawing.Point(181, 361);
            this.txt_mobile_register.Name = "txt_mobile_register";
            this.txt_mobile_register.Size = new System.Drawing.Size(297, 28);
            this.txt_mobile_register.TabIndex = 7;
            this.txt_mobile_register.Tag = "Mobile";
            this.txt_mobile_register.Text = "Mobile";
            this.txt_mobile_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mobile_register.Enter += new System.EventHandler(this.txt_mobile_register_Enter);
            this.txt_mobile_register.Leave += new System.EventHandler(this.txt_mobile_register_Leave);
            // 
            // txt_account_register
            // 
            this.txt_account_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_account_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txt_account_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_account_register.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_account_register.ForeColor = System.Drawing.Color.White;
            this.txt_account_register.Location = new System.Drawing.Point(181, 255);
            this.txt_account_register.Name = "txt_account_register";
            this.txt_account_register.Size = new System.Drawing.Size(297, 28);
            this.txt_account_register.TabIndex = 5;
            this.txt_account_register.Tag = "Account";
            this.txt_account_register.Text = "Account";
            this.txt_account_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_account_register.Enter += new System.EventHandler(this.txt_account_register_Enter);
            this.txt_account_register.Leave += new System.EventHandler(this.txt_account_register_Leave);
            // 
            // txt_password_register
            // 
            this.txt_password_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_password_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txt_password_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password_register.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_password_register.ForeColor = System.Drawing.Color.White;
            this.txt_password_register.Location = new System.Drawing.Point(181, 308);
            this.txt_password_register.Name = "txt_password_register";
            this.txt_password_register.Size = new System.Drawing.Size(297, 28);
            this.txt_password_register.TabIndex = 6;
            this.txt_password_register.Tag = "Password";
            this.txt_password_register.Text = "Password";
            this.txt_password_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password_register.Enter += new System.EventHandler(this.txt_password_register_Enter);
            this.txt_password_register.Leave += new System.EventHandler(this.txt_password_register_Leave);
            // 
            // btn_register
            // 
            this.btn_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(146)))), ((int)(((byte)(106)))));
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(182, 568);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(294, 32);
            this.btn_register.TabIndex = 10;
            this.btn_register.TabStop = false;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(161, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 80);
            this.label7.TabIndex = 7;
            this.label7.Text = "REGISTER";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel_log_front);
            this.panel4.Controls.Add(this.panel_log_succeed);
            this.panel4.Controls.Add(this.panel_register);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1215, 795);
            this.panel4.TabIndex = 12;
            // 
            // FormAccount
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1215, 795);
            this.Controls.Add(this.panel4);
            this.Name = "FormAccount";
            this.Text = "ACCOUNT";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.panel_log_front.ResumeLayout(false);
            this.panel_log_front.PerformLayout();
            this.panel_log_succeed.ResumeLayout(false);
            this.panel_register.ResumeLayout(false);
            this.panel_register.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_go_register;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel_log_front;
        private System.Windows.Forms.Panel panel_log_succeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.TextBox txt_account_register;
        private System.Windows.Forms.TextBox txt_password_register;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email_register;
        private System.Windows.Forms.TextBox txt_mobile_register;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lb_pw_login;
        private System.Windows.Forms.Label lb_ac_login;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}