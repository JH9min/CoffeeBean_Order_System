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
    public partial class FormManageMember : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";


        public FormManageMember()
        {
            InitializeComponent();
        }

        private void FormManageMember_Load(object sender, EventArgs e)
        {

            check_authority();
            cbx_searchColumn.Items.Add("User ID");
            cbx_searchColumn.Items.Add("Name");
            cbx_searchColumn.Items.Add("Mobile");
            cbx_searchColumn.Items.Add("Email");
            cbx_searchColumn.Items.Add("Address");
            cbx_searchColumn.SelectedIndex = 0;
            strDBconnectionString = GlobalVariable.MySqlConnect(scsb, strDBconnectionString);
            string strSQL = "select * from Member";
            GenerateMemberInfoList(strSQL, dgv_member, "");
        }

        void GenerateMemberInfoList(string strSQL, DataGridView dgv, string searchTarget)
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(strSQL, con);
            if (searchTarget != "")
            {
                cmd.Parameters.AddWithValue("@SearchTarget", searchTarget);
            }

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            dr.Close();
            con.Close();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_member.DataSource = null;
            string strSearchColumn = "";
            switch (cbx_searchColumn.SelectedIndex)
            {

                case 1:
                    strSearchColumn = "[name]";
                    break;
                case 2:
                    strSearchColumn = "mobile";
                    break;
                case 3:
                    strSearchColumn = "email";
                    break;
                case 4:
                    strSearchColumn = "[address]";
                    break;
                default:
                    strSearchColumn = "user_id";
                    break;

            }

            string strSQL = "select * from Member where " + strSearchColumn + " like '%" + txt_search.Text + "%' order by user_id;";
            GenerateMemberInfoList(strSQL, dgv_member, "");

            btn_insert.Enabled = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearAll();
            dgv_member.DataSource=null;
            cbx_searchColumn.SelectedIndex = 0;
            string strSQL = "select * from Member";
            GenerateMemberInfoList(strSQL, dgv_member, "");
            btn_insert.Enabled = true;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select name from Member where name=@name";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if(!dr.Read())
            {
                dr.Close();
                con.Close();
                bool isAccount = GlobalVariable.txt_check(txt_name, "^[\u4e00-\u9FFF_A-Za-z0-9]+$");
                bool isMobile = GlobalVariable.txt_check(txt_mobile, "^09[0-9]{8}$");
                bool isEmail = GlobalVariable.txt_check(txt_email, "\\w{1,63}@[a-zA-Z0-9]{2,63}\\.[a-zA-Z]{2,63}(\\.[a-zA-Z]{2,63})?$");
                bool isAddress = GlobalVariable.txt_check(txt_address, "^[\u4e00-\u9FFF_A-Za-z0-9]+$");

                if(isAccount && isEmail && isMobile & isAddress)
                {
                    if (rdb_clerk.Checked || rdb_manager.Checked)
                    {
                        int authority_insert = 1;
                        con = new SqlConnection(strDBconnectionString);
                        con.Open();
                        strSQL = "insert into Member values(@name,@mobile,@email,@address,@lastLogInDate,@authority);" + "insert into MemberSecurity values((select top 1 user_id from Member order by user_id desc),@password)";
                        cmd = new SqlCommand(strSQL, con);

                        cmd.Parameters.AddWithValue("@name", txt_name.Text);
                        cmd.Parameters.AddWithValue("@password", txt_password.Text);
                        cmd.Parameters.AddWithValue("@mobile", txt_mobile.Text);
                        cmd.Parameters.AddWithValue("@email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@address", txt_address.Text);
                        cmd.Parameters.AddWithValue("@lastLogInDate", DateTime.Now);
                        if (rdb_manager.Checked)
                        {
                            authority_insert = 2;
                        }
                        cmd.Parameters.AddWithValue("@authority", authority_insert);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        strSQL = "select * from Member;";
                        GenerateMemberInfoList(strSQL, dgv_member, "");
                    }
                    else
                    {
                        MessageBox.Show("Please select authrity to insert.", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the correct formatted Info..", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("The name had been registered", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

   




        }

        void ClearAll()
        {
            lb_id.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_mobile.Text = string.Empty;
            txt_name.Text = string.Empty;
            lb_authority.Text = string.Empty;
            txt_search.Text = string.Empty;
            dtp_logInDate.Value = DateTime.Now;
            txt_search.Text = string.Empty;
            cbx_searchColumn.SelectedIndex = 0;

        }

        private void dgv_member_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lb_id.Text= dgv_member.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_name.Text= dgv_member.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_mobile.Text= dgv_member.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_email.Text= dgv_member.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_address.Text= dgv_member.Rows[e.RowIndex].Cells[4].Value.ToString();
                int authority_read = 0;
                authority_read= Convert.ToInt32(dgv_member.Rows[e.RowIndex].Cells[6].Value);
                switch (authority_read)
                {
                    case 0:
                        lb_authority.Text = "Guest";
                        break;
                    case 1:
                        lb_authority.Text = "Clerk";
                        break;
                    case 2:
                        lb_authority.Text = "Manager";
                        break;
                    case 3:
                        lb_authority.Text = "Admin";
                        break;
                }
                dtp_logInDate.Value= Convert.ToDateTime(dgv_member.Rows[e.RowIndex].Cells[5].Value);
                btn_insert.Enabled = false;
            }
        }

        private void check_authority()
        {
            if(GlobalVariable.authority!=3)
            {
                btn_delete.Enabled=false;
                btn_delete.Visible=false;
            }
            else
            {
                btn_delete.Enabled=true;
                btn_delete.Visible=true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(lb_id.Text)!=GlobalVariable.current_user)
            {
                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = "delete from Member where user_id=@id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(lb_id.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                ClearAll();
                strSQL = "select * from Member;";
                GenerateMemberInfoList(strSQL, dgv_member, "");
            }
            else
            {
                MessageBox.Show("YOU CAN NOT DELETE YOURSELF.","Delete Failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}
