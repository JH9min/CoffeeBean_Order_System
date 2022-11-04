namespace HW2.Forms
{
    partial class FormUser
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.btn_rlog_out = new System.Windows.Forms.Button();
            this.panel_member = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_detail = new System.Windows.Forms.Panel();
            this.pn_recent = new System.Windows.Forms.Panel();
            this.btn_edit_user = new System.Windows.Forms.Button();
            this.panel_logout_success = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList_product = new System.Windows.Forms.ImageList(this.components);
            this.panel_member.SuspendLayout();
            this.panel_logout_success.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(1156, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "USER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_username.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.lb_username.Location = new System.Drawing.Point(1082, 195);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(242, 33);
            this.lb_username.TabIndex = 9;
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_rlog_out
            // 
            this.btn_rlog_out.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rlog_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(146)))), ((int)(((byte)(106)))));
            this.btn_rlog_out.FlatAppearance.BorderSize = 0;
            this.btn_rlog_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rlog_out.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_rlog_out.ForeColor = System.Drawing.Color.White;
            this.btn_rlog_out.Location = new System.Drawing.Point(1088, 608);
            this.btn_rlog_out.Name = "btn_rlog_out";
            this.btn_rlog_out.Size = new System.Drawing.Size(246, 37);
            this.btn_rlog_out.TabIndex = 11;
            this.btn_rlog_out.TabStop = false;
            this.btn_rlog_out.Text = "LOG OUT";
            this.btn_rlog_out.UseVisualStyleBackColor = false;
            this.btn_rlog_out.Click += new System.EventHandler(this.btn_rlog_out_Click);
            // 
            // panel_member
            // 
            this.panel_member.Controls.Add(this.label4);
            this.panel_member.Controls.Add(this.label1);
            this.panel_member.Controls.Add(this.pn_detail);
            this.panel_member.Controls.Add(this.pn_recent);
            this.panel_member.Controls.Add(this.btn_edit_user);
            this.panel_member.Controls.Add(this.btn_rlog_out);
            this.panel_member.Controls.Add(this.lb_username);
            this.panel_member.Controls.Add(this.label5);
            this.panel_member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_member.Location = new System.Drawing.Point(0, 0);
            this.panel_member.Name = "panel_member";
            this.panel_member.Size = new System.Drawing.Size(1481, 793);
            this.panel_member.TabIndex = 15;
            this.panel_member.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_member_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(155, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "Order History";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(1056, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 552);
            this.label1.TabIndex = 19;
            // 
            // pn_detail
            // 
            this.pn_detail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn_detail.AutoScroll = true;
            this.pn_detail.Location = new System.Drawing.Point(820, 139);
            this.pn_detail.Name = "pn_detail";
            this.pn_detail.Size = new System.Drawing.Size(200, 506);
            this.pn_detail.TabIndex = 0;
            // 
            // pn_recent
            // 
            this.pn_recent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn_recent.AutoScroll = true;
            this.pn_recent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.pn_recent.Location = new System.Drawing.Point(160, 139);
            this.pn_recent.Name = "pn_recent";
            this.pn_recent.Size = new System.Drawing.Size(640, 506);
            this.pn_recent.TabIndex = 18;
            // 
            // btn_edit_user
            // 
            this.btn_edit_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_edit_user.FlatAppearance.BorderSize = 0;
            this.btn_edit_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_user.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_edit_user.ForeColor = System.Drawing.Color.White;
            this.btn_edit_user.Location = new System.Drawing.Point(1088, 565);
            this.btn_edit_user.Name = "btn_edit_user";
            this.btn_edit_user.Size = new System.Drawing.Size(246, 37);
            this.btn_edit_user.TabIndex = 17;
            this.btn_edit_user.TabStop = false;
            this.btn_edit_user.Text = "EDIT";
            this.btn_edit_user.UseVisualStyleBackColor = false;
            this.btn_edit_user.Click += new System.EventHandler(this.btn_edit_user_Click);
            // 
            // panel_logout_success
            // 
            this.panel_logout_success.Controls.Add(this.label3);
            this.panel_logout_success.Controls.Add(this.label2);
            this.panel_logout_success.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_logout_success.Location = new System.Drawing.Point(0, 0);
            this.panel_logout_success.Name = "panel_logout_success";
            this.panel_logout_success.Size = new System.Drawing.Size(1481, 793);
            this.panel_logout_success.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 78);
            this.label3.TabIndex = 3;
            this.label3.Text = "NEXT TIME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 83);
            this.label2.TabIndex = 2;
            this.label2.Text = "SEE YOU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList_product
            // 
            this.imageList_product.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_product.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_product.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1481, 793);
            this.Controls.Add(this.panel_member);
            this.Controls.Add(this.panel_logout_success);
            this.Name = "FormUser";
            this.Text = "USER INFO";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panel_member.ResumeLayout(false);
            this.panel_logout_success.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Button btn_rlog_out;
        private System.Windows.Forms.Panel panel_member;
        private System.Windows.Forms.Panel panel_logout_success;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_edit_user;
        private System.Windows.Forms.ImageList imageList_product;
        private System.Windows.Forms.Panel pn_recent;
        private System.Windows.Forms.Panel pn_detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}