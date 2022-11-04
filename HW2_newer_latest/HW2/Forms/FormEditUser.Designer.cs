namespace HW2.Forms
{
    partial class FormEditUser
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
            this.panel_register = new System.Windows.Forms.Panel();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_mobile = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_register.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_register
            // 
            this.panel_register.Controls.Add(this.lb_address);
            this.panel_register.Controls.Add(this.lb_mobile);
            this.panel_register.Controls.Add(this.lb_email);
            this.panel_register.Controls.Add(this.lb_name);
            this.panel_register.Controls.Add(this.label8);
            this.panel_register.Controls.Add(this.label6);
            this.panel_register.Controls.Add(this.label4);
            this.panel_register.Controls.Add(this.label1);
            this.panel_register.Controls.Add(this.txt_address);
            this.panel_register.Controls.Add(this.txt_email);
            this.panel_register.Controls.Add(this.txt_mobile);
            this.panel_register.Controls.Add(this.txt_account);
            this.panel_register.Controls.Add(this.btn_save);
            this.panel_register.Controls.Add(this.label7);
            this.panel_register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_register.Location = new System.Drawing.Point(0, 0);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(495, 655);
            this.panel_register.TabIndex = 18;
            // 
            // lb_address
            // 
            this.lb_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_address.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.lb_address.Location = new System.Drawing.Point(64, 381);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(159, 29);
            this.lb_address.TabIndex = 34;
            this.lb_address.Text = "Address:";
            this.lb_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_mobile
            // 
            this.lb_mobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_mobile.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_mobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.lb_mobile.Location = new System.Drawing.Point(64, 247);
            this.lb_mobile.Name = "lb_mobile";
            this.lb_mobile.Size = new System.Drawing.Size(159, 29);
            this.lb_mobile.TabIndex = 33;
            this.lb_mobile.Text = "Mobile:";
            this.lb_mobile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_email
            // 
            this.lb_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_email.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.lb_email.Location = new System.Drawing.Point(64, 314);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(159, 29);
            this.lb_email.TabIndex = 32;
            this.lb_email.Text = "Email:";
            this.lb_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_name
            // 
            this.lb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_name.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.lb_name.Location = new System.Drawing.Point(64, 175);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(159, 29);
            this.lb_name.TabIndex = 30;
            this.lb_name.Text = "User Name:";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(427, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(427, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(427, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(427, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_address.ForeColor = System.Drawing.Color.White;
            this.txt_address.Location = new System.Drawing.Point(229, 383);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(192, 28);
            this.txt_address.TabIndex = 4;
            this.txt_address.Tag = "Address";
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(229, 316);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(192, 28);
            this.txt_email.TabIndex = 3;
            this.txt_email.Tag = "Email";
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txt_mobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mobile.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_mobile.ForeColor = System.Drawing.Color.White;
            this.txt_mobile.Location = new System.Drawing.Point(229, 249);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(192, 28);
            this.txt_mobile.TabIndex = 2;
            this.txt_mobile.Tag = "Mobile";
            this.txt_mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_account
            // 
            this.txt_account.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txt_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_account.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_account.ForeColor = System.Drawing.Color.White;
            this.txt_account.Location = new System.Drawing.Point(229, 177);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(192, 28);
            this.txt_account.TabIndex = 1;
            this.txt_account.Tag = "Account";
            this.txt_account.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(146)))), ((int)(((byte)(106)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(70, 584);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(351, 32);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(486, 80);
            this.label7.TabIndex = 7;
            this.label7.Text = "Edit Your Info";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 655);
            this.Controls.Add(this.panel_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditUser";
            this.Load += new System.EventHandler(this.FormEditUser_Load);
            this.panel_register.ResumeLayout(false);
            this.panel_register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_mobile;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_name;
    }
}