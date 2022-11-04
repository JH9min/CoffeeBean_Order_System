using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2.Forms
{


    public partial class FormEditUser : Form
    {
        public delegate void isChange();

        public event isChange changeSave;




        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";

        public FormEditUser()
        {
            InitializeComponent();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            strDBconnectionString = GlobalVariable.MySqlConnect(scsb, strDBconnectionString);
            GetUserInfo();
        }

        void GetUserInfo()
        {
            SqlConnection con=new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select * from Member as m,MemberSecurity where m.user_id=@SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", GlobalVariable.current_user);

            SqlDataReader dr=cmd.ExecuteReader();

            dr.Read();
            txt_account.Text = dr["name"].ToString();
            txt_mobile.Text = dr["mobile"].ToString();
            txt_email.Text = dr["email"].ToString();
            txt_address.Text = dr["address"].ToString();

            dr.Close();
            con.Close();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool isAccount = GlobalVariable.txt_check(txt_account, "^[\u4e00-\u9FFF_A-Za-z0-9]+$");
            bool isMobile = GlobalVariable.txt_check(txt_mobile, "^09[0-9]{8}$");
            bool isEmail = GlobalVariable.txt_check(txt_email, "\\w{1,63}@[a-zA-Z0-9]{2,63}\\.[a-zA-Z]{2,63}(\\.[a-zA-Z]{2,63})?$");
            bool isAddress = GlobalVariable.txt_check(txt_address, "^[\u4e00-\u9FFF_A-Za-z0-9]+$");

            if (isAccount&&isEmail&&isMobile&isAddress)
            {
                DialogResult r = MessageBox.Show("ARE YOU SURE TO CHANGE YOUR INFO?","Info Change",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(r==DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string strSQL = "update Member set [name]=@name,[mobile]=@mobile,[email]=@email,[address]=@address where user_id=@id";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@name", txt_account.Text);
                    GlobalVariable.member = txt_account.Text;
                    cmd.Parameters.AddWithValue("@mobile",txt_mobile.Text);
                    cmd.Parameters.AddWithValue("@email",txt_email.Text);
                    cmd.Parameters.AddWithValue("@address",txt_address.Text);
                    cmd.Parameters.AddWithValue("@id", GlobalVariable.current_user);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    changeSave();
                    Close();
                }

            }
            else
            {
                MessageBox.Show("Please enter correct formatted Info.","Change Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
