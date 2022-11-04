namespace HW2.Forms
{
    partial class FormShoppingCart
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
            this.btn_clear_all = new System.Windows.Forms.Button();
            this.lb_user_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.btn_selected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.listBox_itemOrderList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clear_all.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear_all.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(144)))), ((int)(((byte)(103)))));
            this.btn_clear_all.FlatAppearance.BorderSize = 3;
            this.btn_clear_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_all.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(144)))), ((int)(((byte)(103)))));
            this.btn_clear_all.Location = new System.Drawing.Point(962, 458);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(127, 32);
            this.btn_clear_all.TabIndex = 2;
            this.btn_clear_all.Text = "CLEAR";
            this.btn_clear_all.UseVisualStyleBackColor = false;
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // lb_user_name
            // 
            this.lb_user_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_user_name.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.lb_user_name.Location = new System.Drawing.Point(220, 39);
            this.lb_user_name.Name = "lb_user_name";
            this.lb_user_name.Size = new System.Drawing.Size(198, 86);
            this.lb_user_name.TabIndex = 7;
            this.lb_user_name.Text = "NAME";
            this.lb_user_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "TOTAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_total
            // 
            this.lb_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_total.Location = new System.Drawing.Point(23, 76);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(218, 224);
            this.lb_total.TabIndex = 10;
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_selected
            // 
            this.btn_selected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(144)))), ((int)(((byte)(103)))));
            this.btn_selected.FlatAppearance.BorderSize = 0;
            this.btn_selected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selected.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_selected.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_selected.Location = new System.Drawing.Point(825, 458);
            this.btn_selected.Name = "btn_selected";
            this.btn_selected.Size = new System.Drawing.Size(127, 32);
            this.btn_selected.TabIndex = 1;
            this.btn_selected.Text = "DELETE";
            this.btn_selected.UseVisualStyleBackColor = false;
            this.btn_selected.Click += new System.EventHandler(this.btn_selected_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(53)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(101, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 86);
            this.label1.TabIndex = 12;
            this.label1.Text = "USER:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_order
            // 
            this.btn_order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.btn_order.FlatAppearance.BorderSize = 0;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_order.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_order.Location = new System.Drawing.Point(825, 497);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(264, 32);
            this.btn_order.TabIndex = 3;
            this.btn_order.Text = "BUY";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // listBox_itemOrderList
            // 
            this.listBox_itemOrderList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox_itemOrderList.BackColor = System.Drawing.Color.White;
            this.listBox_itemOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_itemOrderList.Font = new System.Drawing.Font("細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_itemOrderList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.listBox_itemOrderList.FormattingEnabled = true;
            this.listBox_itemOrderList.ItemHeight = 21;
            this.listBox_itemOrderList.Location = new System.Drawing.Point(108, 128);
            this.listBox_itemOrderList.Name = "listBox_itemOrderList";
            this.listBox_itemOrderList.Size = new System.Drawing.Size(697, 399);
            this.listBox_itemOrderList.TabIndex = 2;
            this.listBox_itemOrderList.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.lb_total);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(825, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 324);
            this.panel1.TabIndex = 15;
            // 
            // FormShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1183, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selected);
            this.Controls.Add(this.lb_user_name);
            this.Controls.Add(this.listBox_itemOrderList);
            this.Controls.Add(this.btn_clear_all);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormShoppingCart";
            this.Text = "SHOPPING CART";
            this.Load += new System.EventHandler(this.FormShoppingCart_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clear_all;
        private System.Windows.Forms.Label lb_user_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button btn_selected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.ListBox listBox_itemOrderList;
        private System.Windows.Forms.Panel panel1;
    }
}