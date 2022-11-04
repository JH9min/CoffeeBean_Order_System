using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace HW2
{
    public partial class Form1 : Form
    {
        private Button btn_current;




        bool MenuCollapes = true;
        public Form1()
        {

            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }




        private void menu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (MenuCollapes)
            {
                sub_menu.Width += 30;
                if (sub_menu.Width == sub_menu.MaximumSize.Width)
                {
                    MenuCollapes = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sub_menu.Width -= 30;
                if (sub_menu.Width == sub_menu.MinimumSize.Width)
                {
                    MenuCollapes = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void activate_admin()
        {
            switch(GlobalVariable.authority)
            {
                case 0:
                    pn_cart.Enabled = true;
                    pn_cart.Visible = true;
                    break;
                case 1:
                    pn_stock.Visible = true;
                    pn_stock.Enabled = true;
                    pn_order.Visible = true;
                    pn_order.Enabled = true;
                    pn_cart.Enabled = true;
                    pn_cart.Visible = true;
                    break;
                case 2:case 3:

                    pn_member.Visible = true;
                    pn_member.Enabled = true;
                    pn_stock.Visible = true;
                    pn_stock.Enabled = true;
                    pn_order.Visible = true;
                    pn_order.Enabled = true;
                    pn_cart.Enabled = true;
                    pn_cart.Visible = true;
                    break;
                default:
                    pn_cart.Enabled = false;
                    pn_cart.Visible = false;
                    pn_stock.Visible = false;
                    pn_stock.Enabled = false;
                    pn_order.Visible = false;
                    pn_order.Enabled = false;
                    pn_member.Visible = false;
                    pn_member.Enabled = false;
                    break;
            }


        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (btn_current != btnSender)
                {
                    DisableButton();
                    home.Visible = true;
                    Color color = Color.FromArgb(204, 144, 103);
                    btn_current = (Button)btnSender;
                    btn_current.BackColor = color;
                    btn_current.ForeColor = Color.FromArgb(71, 53, 43);
                    btn_current.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control btn_previous in sub_menu.Controls)
            {
                if (btn_previous.GetType() == typeof(Panel))
                {
                    btn_previous.Controls[0].BackColor = Color.FromArgb(87, 85, 83);
                    btn_previous.Controls[0].ForeColor = Color.White;
                    btn_previous.Controls[0].Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                }
            }
        }

        private void OpenChildForm(Form child_form ,object  btn_sender)
        {

                if (GlobalVariable.form_active != null)
                {
                    GlobalVariable.form_active.Close();
                }
                ActiveButton(btn_sender);
                GlobalVariable.form_active = child_form;
                child_form.TopLevel = false;
                child_form.FormBorderStyle = FormBorderStyle.None;
                child_form.Dock = DockStyle.Fill;
                this.main_panel.Controls.Add(child_form);
                this.main_panel.Tag = child_form;
                title.Text = child_form.Text;
                child_form.Show();
                child_form.BringToFront();


        }
        private void OpenChildFormAccount(Forms.FormAccount child_form, object btn_sender)
        {

            if (GlobalVariable.form_active != null)
            {
                GlobalVariable.form_active.Close();
            }
            ActiveButton(btn_sender);
            GlobalVariable.form_active = child_form;
            child_form.TopLevel = false;
            child_form.FormBorderStyle = FormBorderStyle.None;
            child_form.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(child_form);
            this.main_panel.Tag = child_form;
            title.Text = child_form.Text;
            child_form.Show();
            child_form.BringToFront();
            child_form.authority += new Forms.FormAccount.admin(activate_admin);
        }
        private void OpenChildFormUser(Forms.FormUser child_form, object btn_sender)
        {

            if (GlobalVariable.form_active != null)
            {
                GlobalVariable.form_active.Close();
            }
            ActiveButton(btn_sender);
            GlobalVariable.form_active = child_form;
            child_form.TopLevel = false;
            child_form.FormBorderStyle = FormBorderStyle.None;
            child_form.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(child_form);
            this.main_panel.Tag = child_form;
            title.Text = child_form.Text;
            child_form.Show();
            child_form.BringToFront();
            child_form.authority += new Forms.FormUser.admin(activate_admin);
        }





        private void main_form_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMenu(), sender);
        }

        private void sub_form_1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormShoppingCart(), sender);
        }

        private void sub_form_2_Click(object sender, EventArgs e)
        {
            if(GlobalVariable.isLogIn)
            {
                OpenChildFormUser(new Forms.FormUser(), sender);
            }
            else
            {
                OpenChildFormAccount(new Forms.FormAccount(), sender);

            }

        }

        private void home_Click(object sender, EventArgs e)
        {
            if (GlobalVariable.form_active != null)
                GlobalVariable.form_active.Close();
            reset();
        }

        private void reset()
        {
            DisableButton();
            title.Text = "HOME";
            btn_current = null;
            home.Visible= false;
        }

        private void sub_form_3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormManageOrder(), sender);
        }
        private void sub_form_4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormManagement(), sender);
        }

        private void sub_form_5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormManageMember(), sender);
        }


    }
}
