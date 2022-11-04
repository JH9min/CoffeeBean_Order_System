using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW2.Forms
{
    public partial class FormAccount : Form
    {

        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";

        bool txtIsEnter_1=false;
        bool txtIsEnter_2=false;
        bool txtIsEnter_3 = false;
        bool txtIsEnter_4 = false;
        bool txtIsEnter_5 = false;

        public delegate void admin();

        public event admin authority;

        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            strDBconnectionString = GlobalVariable.MySqlConnect(scsb, strDBconnectionString);
            panel_register.Visible=false;
            panel_register.Enabled = false;
            panel_log_succeed.Visible = false;
            panel_log_succeed.Enabled = false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            bool isAccount=GlobalVariable.txt_check(txt_account_register, "^[\u4e00-\u9FFF_A-Za-z0-9]+$");
            bool isPassword=GlobalVariable.txt_check(txt_password_register, "^[A-Za-z0-9]+$");
            bool isMobile=GlobalVariable.txt_check(txt_mobile_register, "^09[0-9]{8}$");
            bool isEmail=GlobalVariable.txt_check(txt_email_register, "\\w{1,63}@[a-zA-Z0-9]{2,63}\\.[a-zA-Z]{2,63}(\\.[a-zA-Z]{2,63})?$");

            


            if(isAccount&&isEmail&&isMobile&isPassword)
            {
                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = "select * from Member where name=@name;";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@name", txt_account_register.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    strSQL = "select * from Member as m,MemberSecurity as ms where name=@name and password=@password and m.user_id=ms.user_id;";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@name", txt_account_register.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password_register.Text);

                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {


                        lb_username.Text = dr["name"].ToString();
                        GlobalVariable.member = lb_username.Text;
                        GlobalVariable.current_user = (int)dr["user_id"];
                        GlobalVariable.isLogIn = true;
                        GlobalVariable.authority = Convert.ToInt32(dr["authority"]);

                        if (dr["email"].ToString() != txt_email_register.Text || dr["address"].ToString() != txt_address.Text || dr["mobile"].ToString()!=txt_mobile_register.Text)
                        {
                            dr.Close();
                            DialogResult r= MessageBox.Show("Your enter Info is different from your old Info.\nDo you want to update them?", "Info Change", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if(r==DialogResult.Yes)
                            {
                                
                                strSQL = "update Member set mobile=@mobile,email=@email,address=@address,lastLogInDate=@lastLogInDate where user_id=@id";
                                cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@mobile", txt_mobile_register.Text);
                                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                                cmd.Parameters.AddWithValue("@email",txt_email_register.Text);
                                cmd.Parameters.AddWithValue("@id",GlobalVariable.current_user);
                                cmd.Parameters.AddWithValue("@lastLogInDate", DateTime.Now);
                                cmd.ExecuteNonQuery();

                            }
                            else
                            {
                                strSQL = "update Member set lastLogInDate=@lastLogInDate where user_id=@id";
                                cmd.Parameters.AddWithValue("@lastLogInDate", DateTime.Now);
                                cmd.Parameters.AddWithValue("@id", GlobalVariable.current_user);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        else
                        {
                            dr.Close();
                            strSQL = "update Member set lastLogInDate=@lastLogInDate where user_id=@id";
                            cmd.Parameters.AddWithValue("@lastLogInDate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@id", GlobalVariable.current_user);
                            cmd.ExecuteNonQuery();
                        }

                        authority();
                        panel_log_succeed.BringToFront();
                        panel_log_succeed.Visible = true;
                        panel_log_succeed.Enabled=true;
                        panel_register.Enabled = false;
                        panel_register.Visible=false;
                    }
                    else
                    {
                        MessageBox.Show("This user name had been registered.\nPlease try another one.", "Regiter Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else
                {
                    dr.Close();
                    strSQL = "insert into Member values(@name,@mobile,@email,@address,@lastLoginDate,0);"+"insert into MemberSecurity values((select top 1 m.user_id from Member as m order by m.user_id desc),@password)";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@name", txt_account_register.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password_register.Text);
                    cmd.Parameters.AddWithValue("@mobile", txt_mobile_register.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email_register.Text);
                    cmd.Parameters.AddWithValue("@address", txt_address.Text);
                    cmd.Parameters.AddWithValue("@lastLoginDate", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    strSQL = "select *  from Member as m, MemberSecurity as ms where name=@name and password=@password and m.[user_id]=ms.[user_id];";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@name", txt_account_register.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password_register.Text);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    lb_username.Text =txt_account_register.Text;
                    GlobalVariable.member = lb_username.Text;
                    GlobalVariable.current_user = (int)dr["user_id"];
                    GlobalVariable.isLogIn = true;
                    GlobalVariable.authority = 0;
                    authority();
                    this.panel_log_succeed.BringToFront();
                    panel_log_succeed.Visible = true;
                    panel_log_succeed.Enabled = true;
                    panel_register.Enabled = false;
                    panel_register.Visible = false;
                    dr.Close();
                }


                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter the correct info.", "Regiter Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool isAccount = GlobalVariable.txt_check(txt_account, "^[\u4e00-\u9FFF_A-Za-z0-9]+$");
            bool isPassword = GlobalVariable.txt_check(txt_password, "^[A-Za-z0-9]+$");

            if(isAccount&& isPassword)
            {
                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = "select * from Member as m,MemberSecurity as ms where m.user_id=ms.user_id and name=@user and password=@password; ";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@user", txt_account.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                SqlDataReader dr= cmd.ExecuteReader();

                if (dr.Read())
                {

                    lb_username.Text = dr["name"].ToString();
                    GlobalVariable.member = lb_username.Text;
                    GlobalVariable.current_user =(int)dr["user_id"];
                    GlobalVariable.isLogIn = true;
                    GlobalVariable.authority = Convert.ToInt32(dr["authority"]);
                    panel_log_succeed.Visible = true;
                    panel_log_succeed.Enabled = true;
                    panel_log_succeed.BringToFront();
                    panel_log_front.Enabled = false;
                    panel_log_front.Visible = false;

                    authority();
                    dr.Close();
                    strSQL = "update Member set lastLogInDate=@lastLoginDate where user_id=@id";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@lastLoginDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id", GlobalVariable.current_user);
                    cmd.ExecuteNonQuery();
                    con.Close();


                }
                else
                {
                    dr.Close();
                    con.Close();
                    MessageBox.Show("Wrong password or you have not register.\nPlease try again.", "LogIn Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Please enter correct formatted Info.", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

        }

        private void btn_go_register_Click(object sender, EventArgs e)
        {
            AcceptButton = null;
            panel_register.Visible = true;
            panel_register.Enabled = true;
            panel_register.BringToFront();
            panel_log_front.Visible = false;
            panel_log_front.Enabled = false;
        }

        //-----------------txt函式------------------------

        private void txt_account_register_Enter(object sender, EventArgs e)
        {
            if(txtIsEnter_1==false)
            {
                txt_account_register.Text = "";
                txtIsEnter_1=true;
            }
            GlobalVariable.label_check(txt_account_register, label1);
        }

        private void txt_account_register_Leave(object sender, EventArgs e)
        {
            if(txt_account_register.Text=="")
            {
                txt_account_register.Text = "Account";
                txtIsEnter_1 = false;
            }
            GlobalVariable.label_check(txt_account_register, label1);
        }

        private void txt_password_register_Enter(object sender, EventArgs e)
        {
            if (txtIsEnter_2 == false)
            {
                txt_password_register.Text = "";
                txt_password_register.UseSystemPasswordChar = true;
                txtIsEnter_2 = true;
            }
            GlobalVariable.label_check(txt_password_register, label2);
        }

        private void txt_password_register_Leave(object sender, EventArgs e)
        {
            if (txt_password_register.Text == "")
            {
                txt_password_register.UseSystemPasswordChar=false;
                txt_password_register.Text = "Password";
                txtIsEnter_2 = false;
            }
            GlobalVariable.label_check(txt_password_register, label2);
        }

        private void txt_mobile_register_Enter(object sender, EventArgs e)
        {
            if (txtIsEnter_3 == false)
            {
                txt_mobile_register.Text = "";
                txtIsEnter_3 = true;
            }
            GlobalVariable.label_check(txt_mobile_register, label4);
        }

        private void txt_mobile_register_Leave(object sender, EventArgs e)
        {
            if (txt_mobile_register.Text == "")
            {
                txt_mobile_register.Text = "Mobile";
                txtIsEnter_3 = false;
                
            }
            GlobalVariable.label_check(txt_mobile_register, label4);
        }

        private void txt_email_register_Enter(object sender, EventArgs e)
        {
            if (txtIsEnter_4 == false)
            {
                txt_email_register.Text = "";
                txtIsEnter_4 = true;
            }
            GlobalVariable.label_check(txt_email_register, label6);
        }

        private void txt_email_register_Leave(object sender, EventArgs e)
        {
            if (txt_email_register.Text == "")
            {
                txt_email_register.Text = "Email";
                txtIsEnter_4 = false;
            }
            GlobalVariable.label_check(txt_email_register, label6);
        }

        private void txt_address_Enter(object sender, EventArgs e)
        {
            if (txtIsEnter_5 == false)
            {
                txt_address.Text = "";
                txtIsEnter_5 = true;
            }
            GlobalVariable.label_check(txt_address, label8);
        }

        private void txt_address_Leave(object sender, EventArgs e)
        {
            if (txt_address.Text == "")
            {
                txt_address.Text = "Address";
                txtIsEnter_5 = false;
            }
            GlobalVariable.label_check(txt_address, label8);
        }


        

        private void txt_account_Enter(object sender, EventArgs e)
        {
            if (txtIsEnter_1 == false)
            {
                txt_account.Text = "";
                txtIsEnter_1 = true;
            }
            GlobalVariable.label_check(txt_account, lb_ac_login);
        }

        private void txt_account_Leave(object sender, EventArgs e)
        {
            if (txt_account.Text == "")
            {
                txt_account.Text = "Account";
                txtIsEnter_1 = false;
            }
            GlobalVariable.label_check(txt_account, lb_ac_login);
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txtIsEnter_2 == false)
            {
                txt_password.Text = "";
                txt_password.UseSystemPasswordChar = true;
                txtIsEnter_2 = true;
            }
            GlobalVariable.label_check(txt_password, lb_pw_login);
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.UseSystemPasswordChar = false;
                txt_password.Text = "Password";
                txtIsEnter_2 = false;
            }
            GlobalVariable.label_check(txt_password, lb_pw_login);
        }

    }
}
