namespace HW2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.sub_menu = new System.Windows.Forms.Panel();
            this.pn_member = new System.Windows.Forms.Panel();
            this.sub_form_5 = new System.Windows.Forms.Button();
            this.pn_stock = new System.Windows.Forms.Panel();
            this.sub_form_4 = new System.Windows.Forms.Button();
            this.pn_order = new System.Windows.Forms.Panel();
            this.sub_form_3 = new System.Windows.Forms.Button();
            this.pn_cart = new System.Windows.Forms.Panel();
            this.sub_form_1 = new System.Windows.Forms.Button();
            this.pn_account = new System.Windows.Forms.Panel();
            this.sub_form_2 = new System.Windows.Forms.Button();
            this.pn_shop = new System.Windows.Forms.Panel();
            this.main_form = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bar_title = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sub_menu.SuspendLayout();
            this.pn_member.SuspendLayout();
            this.pn_stock.SuspendLayout();
            this.pn_order.SuspendLayout();
            this.pn_cart.SuspendLayout();
            this.pn_account.SuspendLayout();
            this.pn_shop.SuspendLayout();
            this.panel7.SuspendLayout();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.bar_title.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(83)))));
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menu.Size = new System.Drawing.Size(239, 83);
            this.menu.TabIndex = 1;
            this.menu.TabStop = false;
            this.menu.Text = "        Menu";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 1;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // sub_menu
            // 
            this.sub_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(83)))));
            this.sub_menu.Controls.Add(this.pn_member);
            this.sub_menu.Controls.Add(this.pn_stock);
            this.sub_menu.Controls.Add(this.pn_order);
            this.sub_menu.Controls.Add(this.pn_cart);
            this.sub_menu.Controls.Add(this.pn_account);
            this.sub_menu.Controls.Add(this.pn_shop);
            this.sub_menu.Controls.Add(this.panel7);
            this.sub_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sub_menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sub_menu.Location = new System.Drawing.Point(0, 0);
            this.sub_menu.MaximumSize = new System.Drawing.Size(240, 0);
            this.sub_menu.MinimumSize = new System.Drawing.Size(52, 0);
            this.sub_menu.Name = "sub_menu";
            this.sub_menu.Size = new System.Drawing.Size(52, 711);
            this.sub_menu.TabIndex = 1;
            // 
            // pn_member
            // 
            this.pn_member.Controls.Add(this.sub_form_5);
            this.pn_member.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_member.Enabled = false;
            this.pn_member.Location = new System.Drawing.Point(0, 388);
            this.pn_member.Name = "pn_member";
            this.pn_member.Size = new System.Drawing.Size(52, 61);
            this.pn_member.TabIndex = 5;
            this.pn_member.Visible = false;
            // 
            // sub_form_5
            // 
            this.sub_form_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(83)))));
            this.sub_form_5.FlatAppearance.BorderSize = 0;
            this.sub_form_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_form_5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sub_form_5.ForeColor = System.Drawing.Color.White;
            this.sub_form_5.Image = ((System.Drawing.Image)(resources.GetObject("sub_form_5.Image")));
            this.sub_form_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sub_form_5.Location = new System.Drawing.Point(0, 0);
            this.sub_form_5.Name = "sub_form_5";
            this.sub_form_5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sub_form_5.Size = new System.Drawing.Size(270, 61);
            this.sub_form_5.TabIndex = 4;
            this.sub_form_5.TabStop = false;
            this.sub_form_5.Text = "        User";
            this.sub_form_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sub_form_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sub_form_5.UseVisualStyleBackColor = false;
            this.sub_form_5.Click += new System.EventHandler(this.sub_form_5_Click);
            // 
            // pn_stock
            // 
            this.pn_stock.Controls.Add(this.sub_form_4);
            this.pn_stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_stock.Enabled = false;
            this.pn_stock.Location = new System.Drawing.Point(0, 327);
            this.pn_stock.Name = "pn_stock";
            this.pn_stock.Size = new System.Drawing.Size(52, 61);
            this.pn_stock.TabIndex = 7;
            this.pn_stock.Visible = false;
            // 
            // sub_form_4
            // 
            this.sub_form_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(83)))));
            this.sub_form_4.FlatAppearance.BorderSize = 0;
            this.sub_form_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_form_4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sub_form_4.ForeColor = System.Drawing.Color.White;
            this.sub_form_4.Image = ((System.Drawing.Image)(resources.GetObject("sub_form_4.Image")));
            this.sub_form_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sub_form_4.Location = new System.Drawing.Point(0, 0);
            this.sub_form_4.Name = "sub_form_4";
            this.sub_form_4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sub_form_4.Size = new System.Drawing.Size(270, 61);
            this.sub_form_4.TabIndex = 4;
            this.sub_form_4.TabStop = false;
            this.sub_form_4.Text = "        Stock";
            this.sub_form_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sub_form_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sub_form_4.UseVisualStyleBackColor = false;
            this.sub_form_4.Click += new System.EventHandler(this.sub_form_4_Click);
            // 
            // pn_order
            // 
            this.pn_order.Controls.Add(this.sub_form_3);
            this.pn_order.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_order.Enabled = false;
            this.pn_order.Location = new System.Drawing.Point(0, 266);
            this.pn_order.Name = "pn_order";
            this.pn_order.Size = new System.Drawing.Size(52, 61);
            this.pn_order.TabIndex = 6;
            this.pn_order.Visible = false;
            // 
            // sub_form_3
            // 
            this.sub_form_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(83)))));
            this.sub_form_3.FlatAppearance.BorderSize = 0;
            this.sub_form_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_form_3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sub_form_3.ForeColor = System.Drawing.Color.White;
            this.sub_form_3.Image = ((System.Drawing.Image)(resources.GetObject("sub_form_3.Image")));
            this.sub_form_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sub_form_3.Location = new System.Drawing.Point(0, 0);
            this.sub_form_3.Name = "sub_form_3";
            this.sub_form_3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sub_form_3.Size = new System.Drawing.Size(270, 61);
            this.sub_form_3.TabIndex = 4;
            this.sub_form_3.TabStop = false;
            this.sub_form_3.Text = "        Order";
            this.sub_form_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sub_form_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sub_form_3.UseVisualStyleBackColor = false;
            this.sub_form_3.Click += new System.EventHandler(this.sub_form_3_Click);
            // 
            // pn_cart
            // 
            this.pn_cart.Controls.Add(this.sub_form_1);
            this.pn_cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_cart.Enabled = false;
            this.pn_cart.Location = new System.Drawing.Point(0, 205);
            this.pn_cart.Name = "pn_cart";
            this.pn_cart.Size = new System.Drawing.Size(52, 61);
            this.pn_cart.TabIndex = 3;
            this.pn_cart.Visible = false;
            // 
            // sub_form_1
            // 
            this.sub_form_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(83)))));
            this.sub_form_1.FlatAppearance.BorderSize = 0;
            this.sub_form_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_form_1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sub_form_1.ForeColor = System.Drawing.Color.White;
            this.sub_form_1.Image = ((System.Drawing.Image)(resources.GetObject("sub_form_1.Image")));
            this.sub_form_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sub_form_1.Location = new System.Drawing.Point(0, 0);
            this.sub_form_1.Name = "sub_form_1";
            this.sub_form_1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.sub_form_1.Size = new System.Drawing.Size(270, 61);
            this.sub_form_1.TabIndex = 2;
            this.sub_form_1.TabStop = false;
            this.sub_form_1.Text = "         Cart";
            this.sub_form_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sub_form_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sub_form_1.UseVisualStyleBackColor = false;
            this.sub_form_1.Click += new System.EventHandler(this.sub_form_1_Click);
            // 
            // pn_account
            // 
            this.pn_account.Controls.Add(this.sub_form_2);
            this.pn_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_account.Location = new System.Drawing.Point(0, 144);
            this.pn_account.Name = "pn_account";
            this.pn_account.Size = new System.Drawing.Size(52, 61);
            this.pn_account.TabIndex = 4;
            // 
            // sub_form_2
            // 
            this.sub_form_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(83)))));
            this.sub_form_2.FlatAppearance.BorderSize = 0;
            this.sub_form_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_form_2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sub_form_2.ForeColor = System.Drawing.Color.White;
            this.sub_form_2.Image = ((System.Drawing.Image)(resources.GetObject("sub_form_2.Image")));
            this.sub_form_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sub_form_2.Location = new System.Drawing.Point(0, 0);
            this.sub_form_2.Name = "sub_form_2";
            this.sub_form_2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sub_form_2.Size = new System.Drawing.Size(270, 61);
            this.sub_form_2.TabIndex = 3;
            this.sub_form_2.TabStop = false;
            this.sub_form_2.Text = "        Account";
            this.sub_form_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sub_form_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sub_form_2.UseVisualStyleBackColor = false;
            this.sub_form_2.Click += new System.EventHandler(this.sub_form_2_Click);
            // 
            // pn_shop
            // 
            this.pn_shop.Controls.Add(this.main_form);
            this.pn_shop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_shop.Location = new System.Drawing.Point(0, 83);
            this.pn_shop.Name = "pn_shop";
            this.pn_shop.Size = new System.Drawing.Size(52, 61);
            this.pn_shop.TabIndex = 2;
            // 
            // main_form
            // 
            this.main_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(85)))), ((int)(((byte)(83)))));
            this.main_form.FlatAppearance.BorderSize = 0;
            this.main_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_form.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_form.ForeColor = System.Drawing.Color.White;
            this.main_form.Image = ((System.Drawing.Image)(resources.GetObject("main_form.Image")));
            this.main_form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_form.Location = new System.Drawing.Point(0, 0);
            this.main_form.Name = "main_form";
            this.main_form.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.main_form.Size = new System.Drawing.Size(270, 61);
            this.main_form.TabIndex = 0;
            this.main_form.TabStop = false;
            this.main_form.Text = "        Shop";
            this.main_form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.main_form.UseVisualStyleBackColor = false;
            this.main_form.Click += new System.EventHandler(this.main_form_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(38)))), ((int)(((byte)(17)))));
            this.panel7.Controls.Add(this.menu);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(52, 83);
            this.panel7.TabIndex = 2;
            // 
            // main_panel
            // 
            this.main_panel.AutoScroll = true;
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Controls.Add(this.pictureBox1);
            this.main_panel.Controls.Add(this.pictureBox3);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 83);
            this.main_panel.Name = "main_panel";
            this.main_panel.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.main_panel.Size = new System.Drawing.Size(984, 628);
            this.main_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(52, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.pictureBox3.Size = new System.Drawing.Size(932, 628);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // bar_title
            // 
            this.bar_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.bar_title.Controls.Add(this.panel6);
            this.bar_title.Controls.Add(this.panel5);
            this.bar_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar_title.Location = new System.Drawing.Point(0, 0);
            this.bar_title.Name = "bar_title";
            this.bar_title.Size = new System.Drawing.Size(984, 83);
            this.bar_title.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.title);
            this.panel6.Location = new System.Drawing.Point(160, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(705, 83);
            this.panel6.TabIndex = 2;
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(705, 83);
            this.title.TabIndex = 0;
            this.title.Text = "HOME";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.home);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(131, 83);
            this.panel5.TabIndex = 1;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.home.Location = new System.Drawing.Point(52, 0);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.home.Size = new System.Drawing.Size(79, 83);
            this.home.TabIndex = 0;
            this.home.TabStop = false;
            this.home.Text = " HOME";
            this.home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home.UseVisualStyleBackColor = false;
            this.home.Visible = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.main_panel);
            this.panel1.Controls.Add(this.bar_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 711);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.sub_menu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "Form1";
            this.Text = "ISAPN COFFEE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sub_menu.ResumeLayout(false);
            this.pn_member.ResumeLayout(false);
            this.pn_stock.ResumeLayout(false);
            this.pn_order.ResumeLayout(false);
            this.pn_cart.ResumeLayout(false);
            this.pn_account.ResumeLayout(false);
            this.pn_shop.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.bar_title.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel sub_menu;
        private System.Windows.Forms.Button sub_form_1;
        private System.Windows.Forms.Button main_form;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pn_cart;
        private System.Windows.Forms.Panel pn_shop;
        private System.Windows.Forms.Panel bar_title;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button sub_form_2;
        private System.Windows.Forms.Panel pn_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button sub_form_5;
        private System.Windows.Forms.Panel pn_member;
        private System.Windows.Forms.Panel pn_order;
        public System.Windows.Forms.Button sub_form_3;
        private System.Windows.Forms.Panel pn_stock;
        public System.Windows.Forms.Button sub_form_4;
    }
}

