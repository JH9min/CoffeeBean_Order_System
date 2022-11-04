namespace HW2.Forms
{
    partial class FormManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagement));
            this.panel_stock = new System.Windows.Forms.Panel();
            this.btn_changeMode = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_clear_insert = new System.Windows.Forms.Button();
            this.btn_select_insert = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lv_product = new System.Windows.Forms.ListView();
            this.imageList_product = new System.Windows.Forms.ImageList(this.components);
            this.panel_stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_stock
            // 
            this.panel_stock.Controls.Add(this.btn_changeMode);
            this.panel_stock.Controls.Add(this.label6);
            this.panel_stock.Controls.Add(this.label5);
            this.panel_stock.Controls.Add(this.label4);
            this.panel_stock.Controls.Add(this.label3);
            this.panel_stock.Controls.Add(this.label2);
            this.panel_stock.Controls.Add(this.txt_discount);
            this.panel_stock.Controls.Add(this.label1);
            this.panel_stock.Controls.Add(this.txt_stock);
            this.panel_stock.Controls.Add(this.txt_price);
            this.panel_stock.Controls.Add(this.txt_name);
            this.panel_stock.Controls.Add(this.btn_change);
            this.panel_stock.Controls.Add(this.btn_insert);
            this.panel_stock.Controls.Add(this.btn_clear_insert);
            this.panel_stock.Controls.Add(this.btn_select_insert);
            this.panel_stock.Controls.Add(this.lb_id);
            this.panel_stock.Controls.Add(this.pictureBox1);
            this.panel_stock.Controls.Add(this.lv_product);
            this.panel_stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_stock.Location = new System.Drawing.Point(0, 0);
            this.panel_stock.Name = "panel_stock";
            this.panel_stock.Size = new System.Drawing.Size(1435, 769);
            this.panel_stock.TabIndex = 14;
            // 
            // btn_changeMode
            // 
            this.btn_changeMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_changeMode.BackColor = System.Drawing.Color.White;
            this.btn_changeMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btn_changeMode.FlatAppearance.BorderSize = 2;
            this.btn_changeMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changeMode.Image = ((System.Drawing.Image)(resources.GetObject("btn_changeMode.Image")));
            this.btn_changeMode.Location = new System.Drawing.Point(687, 558);
            this.btn_changeMode.Name = "btn_changeMode";
            this.btn_changeMode.Size = new System.Drawing.Size(43, 42);
            this.btn_changeMode.TabIndex = 30;
            this.btn_changeMode.UseVisualStyleBackColor = false;
            this.btn_changeMode.Click += new System.EventHandler(this.btn_changeMode_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(762, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "Discount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(762, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Stock";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(762, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(762, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(762, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Item ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_discount
            // 
            this.txt_discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_discount.BackColor = System.Drawing.Color.White;
            this.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_discount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_discount.ForeColor = System.Drawing.Color.Black;
            this.txt_discount.Location = new System.Drawing.Point(886, 443);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(148, 26);
            this.txt_discount.TabIndex = 4;
            this.txt_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(86, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 23;
            this.label1.Text = "ITEM LIST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_stock
            // 
            this.txt_stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_stock.BackColor = System.Drawing.Color.White;
            this.txt_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_stock.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_stock.ForeColor = System.Drawing.Color.Black;
            this.txt_stock.Location = new System.Drawing.Point(886, 374);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(148, 26);
            this.txt_stock.TabIndex = 3;
            this.txt_stock.Tag = "-1";
            this.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_price
            // 
            this.txt_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_price.BackColor = System.Drawing.Color.White;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_price.ForeColor = System.Drawing.Color.Black;
            this.txt_price.Location = new System.Drawing.Point(886, 306);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(148, 26);
            this.txt_price.TabIndex = 2;
            this.txt_price.Tag = "-1";
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(886, 234);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(148, 26);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_change
            // 
            this.btn_change.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btn_change.FlatAppearance.BorderSize = 0;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_change.ForeColor = System.Drawing.Color.White;
            this.btn_change.Location = new System.Drawing.Point(1044, 510);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(267, 42);
            this.btn_change.TabIndex = 7;
            this.btn_change.TabStop = false;
            this.btn_change.Text = "CHANGE";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_insert.BackColor = System.Drawing.Color.Transparent;
            this.btn_insert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btn_insert.FlatAppearance.BorderSize = 5;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btn_insert.Location = new System.Drawing.Point(767, 510);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(267, 42);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_clear_insert
            // 
            this.btn_clear_insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clear_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(66)))), ((int)(((byte)(32)))));
            this.btn_clear_insert.FlatAppearance.BorderSize = 0;
            this.btn_clear_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_insert.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear_insert.ForeColor = System.Drawing.Color.White;
            this.btn_clear_insert.Location = new System.Drawing.Point(767, 558);
            this.btn_clear_insert.Name = "btn_clear_insert";
            this.btn_clear_insert.Size = new System.Drawing.Size(544, 42);
            this.btn_clear_insert.TabIndex = 8;
            this.btn_clear_insert.TabStop = false;
            this.btn_clear_insert.Text = "CLEAR";
            this.btn_clear_insert.UseVisualStyleBackColor = false;
            this.btn_clear_insert.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_select_insert
            // 
            this.btn_select_insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_select_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_select_insert.FlatAppearance.BorderSize = 0;
            this.btn_select_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select_insert.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_select_insert.ForeColor = System.Drawing.Color.White;
            this.btn_select_insert.Location = new System.Drawing.Point(1061, 442);
            this.btn_select_insert.Name = "btn_select_insert";
            this.btn_select_insert.Size = new System.Drawing.Size(250, 37);
            this.btn_select_insert.TabIndex = 5;
            this.btn_select_insert.Text = "SELECT";
            this.btn_select_insert.UseVisualStyleBackColor = false;
            this.btn_select_insert.Click += new System.EventHandler(this.btn_selected_Click);
            // 
            // lb_id
            // 
            this.lb_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_id.BackColor = System.Drawing.Color.White;
            this.lb_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_id.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_id.Location = new System.Drawing.Point(886, 141);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(148, 26);
            this.lb_id.TabIndex = 13;
            this.lb_id.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1061, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lv_product
            // 
            this.lv_product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_product.HideSelection = false;
            this.lv_product.Location = new System.Drawing.Point(86, 141);
            this.lv_product.Name = "lv_product";
            this.lv_product.Size = new System.Drawing.Size(644, 459);
            this.lv_product.TabIndex = 0;
            this.lv_product.UseCompatibleStateImageBehavior = false;
            this.lv_product.ItemActivate += new System.EventHandler(this.lv_product_ItemActivate);
            // 
            // imageList_product
            // 
            this.imageList_product.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_product.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_product.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1435, 769);
            this.Controls.Add(this.panel_stock);
            this.Name = "FormManagement";
            this.Text = "Stock Management";
            this.Load += new System.EventHandler(this.FormManagement_Load);
            this.panel_stock.ResumeLayout(false);
            this.panel_stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_stock;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_clear_insert;
        private System.Windows.Forms.Button btn_select_insert;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lv_product;
        private System.Windows.Forms.ImageList imageList_product;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_changeMode;
    }
}