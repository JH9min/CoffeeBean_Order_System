namespace HW2.Forms
{
    partial class FormManageOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_orderDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.lb_order_id = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_revenue = new System.Windows.Forms.Label();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.dgv_orderDetail = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lb_orderer = new System.Windows.Forms.Label();
            this.lb_mobile = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_item = new System.Windows.Forms.Label();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lb_sum = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cbx_searchColumn = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(21, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(105, 29);
            this.name.TabIndex = 12;
            this.name.Text = "Order id.";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mobile";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Orderer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(339, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(339, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(645, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Item";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(645, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(645, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "Sum";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(645, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = "Order date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_orderDate
            // 
            this.dtp_orderDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_orderDate.CustomFormat = "yyyy/MM/dd/HH/MI/SS";
            this.dtp_orderDate.Enabled = false;
            this.dtp_orderDate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderDate.Location = new System.Drawing.Point(790, 260);
            this.dtp_orderDate.Name = "dtp_orderDate";
            this.dtp_orderDate.Size = new System.Drawing.Size(165, 33);
            this.dtp_orderDate.TabIndex = 36;
            this.dtp_orderDate.Value = new System.DateTime(2022, 10, 29, 18, 46, 29, 0);
            this.dtp_orderDate.ValueChanged += new System.EventHandler(this.dtp_orderDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 29);
            this.label9.TabIndex = 37;
            this.label9.Text = "Revenue";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.cbx_status);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.lb_order_id);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.lb_revenue);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(28, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 371);
            this.panel1.TabIndex = 39;
            // 
            // cbx_status
            // 
            this.cbx_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_status.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Location = new System.Drawing.Point(27, 234);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(227, 32);
            this.cbx_status.TabIndex = 1;
            this.cbx_status.SelectedIndexChanged += new System.EventHandler(this.cbx_status_SelectedIndexChanged);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(27, 309);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(227, 44);
            this.btn_update.TabIndex = 2;
            this.btn_update.TabStop = false;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lb_order_id
            // 
            this.lb_order_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_order_id.BackColor = System.Drawing.Color.White;
            this.lb_order_id.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_order_id.Location = new System.Drawing.Point(27, 61);
            this.lb_order_id.Name = "lb_order_id";
            this.lb_order_id.Size = new System.Drawing.Size(227, 26);
            this.lb_order_id.TabIndex = 51;
            this.lb_order_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 29);
            this.label10.TabIndex = 53;
            this.label10.Text = "Status";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_revenue
            // 
            this.lb_revenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_revenue.BackColor = System.Drawing.Color.White;
            this.lb_revenue.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_revenue.Location = new System.Drawing.Point(27, 149);
            this.lb_revenue.Name = "lb_revenue";
            this.lb_revenue.Size = new System.Drawing.Size(227, 26);
            this.lb_revenue.TabIndex = 52;
            this.lb_revenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_order
            // 
            this.dgv_order.AllowUserToAddRows = false;
            this.dgv_order.AllowUserToDeleteRows = false;
            this.dgv_order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(146)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_order.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_order.Location = new System.Drawing.Point(99, 57);
            this.dgv_order.MultiSelect = false;
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowTemplate.Height = 24;
            this.dgv_order.Size = new System.Drawing.Size(997, 297);
            this.dgv_order.TabIndex = 40;
            this.dgv_order.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellDoubleClick);
            // 
            // dgv_orderDetail
            // 
            this.dgv_orderDetail.AllowUserToAddRows = false;
            this.dgv_orderDetail.AllowUserToDeleteRows = false;
            this.dgv_orderDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_orderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(146)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_orderDetail.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_orderDetail.Location = new System.Drawing.Point(1138, 57);
            this.dgv_orderDetail.Name = "dgv_orderDetail";
            this.dgv_orderDetail.RowTemplate.Height = 24;
            this.dgv_orderDetail.Size = new System.Drawing.Size(281, 297);
            this.dgv_orderDetail.TabIndex = 41;
            this.dgv_orderDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orderDetail_CellDoubleClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(66)))), ((int)(((byte)(32)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1138, 769);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(281, 44);
            this.btn_clear.TabIndex = 42;
            this.btn_clear.TabStop = false;
            this.btn_clear.Text = "CLEAR ALL";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btn_search.FlatAppearance.BorderSize = 5;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btn_search.Location = new System.Drawing.Point(28, 278);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(226, 44);
            this.btn_search.TabIndex = 43;
            this.btn_search.TabStop = false;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lb_orderer
            // 
            this.lb_orderer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_orderer.BackColor = System.Drawing.Color.White;
            this.lb_orderer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_orderer.Location = new System.Drawing.Point(450, 83);
            this.lb_orderer.Name = "lb_orderer";
            this.lb_orderer.Size = new System.Drawing.Size(165, 26);
            this.lb_orderer.TabIndex = 44;
            this.lb_orderer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_mobile
            // 
            this.lb_mobile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_mobile.BackColor = System.Drawing.Color.White;
            this.lb_mobile.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_mobile.Location = new System.Drawing.Point(450, 143);
            this.lb_mobile.Name = "lb_mobile";
            this.lb_mobile.Size = new System.Drawing.Size(165, 26);
            this.lb_mobile.TabIndex = 45;
            this.lb_mobile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_email
            // 
            this.lb_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_email.BackColor = System.Drawing.Color.White;
            this.lb_email.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_email.Location = new System.Drawing.Point(450, 203);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(165, 26);
            this.lb_email.TabIndex = 46;
            this.lb_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_address
            // 
            this.lb_address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_address.BackColor = System.Drawing.Color.White;
            this.lb_address.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_address.Location = new System.Drawing.Point(450, 263);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(165, 26);
            this.lb_address.TabIndex = 47;
            this.lb_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_item
            // 
            this.lb_item.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_item.BackColor = System.Drawing.Color.White;
            this.lb_item.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_item.Location = new System.Drawing.Point(790, 84);
            this.lb_item.Name = "lb_item";
            this.lb_item.Size = new System.Drawing.Size(165, 26);
            this.lb_item.TabIndex = 48;
            this.lb_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_amount
            // 
            this.lb_amount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_amount.BackColor = System.Drawing.Color.White;
            this.lb_amount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_amount.Location = new System.Drawing.Point(790, 144);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(165, 26);
            this.lb_amount.TabIndex = 49;
            this.lb_amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_sum
            // 
            this.lb_sum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_sum.BackColor = System.Drawing.Color.White;
            this.lb_sum.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_sum.Location = new System.Drawing.Point(790, 204);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(165, 26);
            this.lb_sum.TabIndex = 50;
            this.lb_sum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_search.Location = new System.Drawing.Point(28, 129);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(176, 28);
            this.txt_search.TabIndex = 3;
            this.txt_search.TabStop = false;
            // 
            // cbx_searchColumn
            // 
            this.cbx_searchColumn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_searchColumn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_searchColumn.FormattingEnabled = true;
            this.cbx_searchColumn.Location = new System.Drawing.Point(133, 191);
            this.cbx_searchColumn.Name = "cbx_searchColumn";
            this.cbx_searchColumn.Size = new System.Drawing.Size(121, 32);
            this.cbx_searchColumn.TabIndex = 52;
            this.cbx_searchColumn.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(116)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbx_searchColumn);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Location = new System.Drawing.Point(1138, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 349);
            this.panel2.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(22, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 29);
            this.label11.TabIndex = 90;
            this.label11.Text = "Search";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lb_orderer);
            this.panel3.Controls.Add(this.lb_mobile);
            this.panel3.Controls.Add(this.lb_email);
            this.panel3.Controls.Add(this.lb_sum);
            this.panel3.Controls.Add(this.lb_address);
            this.panel3.Controls.Add(this.lb_item);
            this.panel3.Controls.Add(this.lb_amount);
            this.panel3.Controls.Add(this.dtp_orderDate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(99, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 433);
            this.panel3.TabIndex = 56;
            // 
            // FormManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1545, 914);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_orderDetail);
            this.Controls.Add(this.dgv_order);
            this.Name = "FormManageOrder";
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.FormManageOrder_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_orderDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.DataGridView dgv_orderDetail;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lb_orderer;
        private System.Windows.Forms.Label lb_mobile;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_item;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.Label lb_sum;
        private System.Windows.Forms.Label lb_revenue;
        private System.Windows.Forms.Label lb_order_id;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cbx_searchColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
    }
}