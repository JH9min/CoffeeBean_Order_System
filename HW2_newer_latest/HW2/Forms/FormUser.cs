using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace HW2.Forms
{
    public partial class FormUser : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";
        List<string> listOrderDate = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listID = new List<int>();
        List<string>listStatus=new List<string>();
        public int productID = 0;

        string strFormat = "order id: {0,-10}\nTotal price: {1,-10}                                                     Status: {3}\nOrder Date:{2}";
        string strFormat_detail = "item: {0,-10}\nAmount: {1,-5}\nTotal price: {2,-5}";

        public delegate void admin();

        public event admin authority;




        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            strDBconnectionString = GlobalVariable.MySqlConnect(scsb, strDBconnectionString);
            lb_username.Text = GlobalVariable.member;
            int num = Load_datatable();
            showRecentHistory(num);


        }

        private void btn_rlog_out_Click(object sender, EventArgs e)
        {
            GlobalVariable.isLogIn = false;
            panel_logout_success.BringToFront();
            GlobalVariable.member = "";
            GlobalVariable.current_user = -1;
            GlobalVariable.authority = -1;
            authority();
        }



        private void btn_edit_user_Click(object sender, EventArgs e)
        {
            Forms.FormEditUser formEditUser = new Forms.FormEditUser();
            formEditUser.changeSave += new Forms.FormEditUser.isChange(updateName);
            formEditUser.ShowDialog();

        }
        private void updateName()
        {
            lb_username.Text= GlobalVariable.member;
        }

        private int Load_datatable()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select * from [Order] where orderer_id=@user order by order_id desc;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@user", GlobalVariable.current_user);
            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;

            while (dr.Read())
            {
                listID.Add((int)dr["order_id"]);
                listOrderDate.Add(dr["orderDate"].ToString());
                listPrice.Add((int)dr["totalPrice"]);
                listStatus.Add(dr["status"].ToString());
                i++;
            }

            dr.Close();
            con.Close();
            return i;

        }

        private void showRecentHistory(int num)
        {
            if(num!=0)
            {
                for (int i = 0; i < num; i++)
                {
                    Panel panel_his = new Panel();
                    Button btn = new Button();

                    panel_his.Controls.Add(btn);


                    panel_his.Name = listID[i].ToString();
                    panel_his.BackColor = Color.FromArgb(255, 255, 255);
                    panel_his.Size = new Size(600, 100);
                    panel_his.Location = new Point(20, 20 + 110 * i);


                    btn.Text = string.Format(strFormat, listID[i], listPrice[i], listOrderDate[i], listStatus[i]);
                    btn.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                    btn.ForeColor = Color.FromArgb(57, 35, 20);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Dock = DockStyle.Fill;
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Tag = listID[i].ToString();

                    btn.Click += new EventHandler(history_click);


                    pn_recent.Controls.Add(panel_his);
                }
            }
            else
            {
                Panel panel_his = new Panel();
                Label lbl = new Label();

                panel_his.Controls.Add(lbl);

                panel_his.BackColor = Color.FromArgb(255, 255, 255);
                panel_his.Size = new Size(600, 100);
                panel_his.Location = new Point(20, 20);

                lbl.Dock=DockStyle.Fill;
                lbl.Font= new Font("微軟正黑體",20, FontStyle.Bold);
                lbl.ForeColor = Color.FromArgb(57, 35, 20);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Text = "Never order before.";

                pn_recent.Controls.Add(panel_his);

            }

        }


        private void history_click(object sender, EventArgs e)
        {
            pn_detail.Controls.Clear();

            Button btn = (Button)sender;
            string o_id = btn.Tag.ToString();

            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select s.item,d.num,packPrice from OrderDetail as d,Stock as s where d.item_id=s.item_id and order_id=@id;";
            SqlCommand cmd = new SqlCommand(strSQL,con);
            cmd.Parameters.AddWithValue("@id",o_id);
            SqlDataReader dr=cmd.ExecuteReader();

            int i = 0;

            while(dr.Read())
            {
                Panel panel_his = new Panel();
                Label label = new Label();

                panel_his.Controls.Add(label);



                panel_his.BackColor = Color.FromArgb(255, 255, 255);
                panel_his.Size = new Size(180, 100);
                panel_his.Location = new Point(10, 20 + 110 * i);


                label.Text = string.Format(strFormat_detail, dr["item"].ToString(), dr["num"].ToString(), dr["packPrice"].ToString());
                label.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(57, 35, 20);
                label.FlatStyle = FlatStyle.Flat;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Tag = listID.ToString();

                pn_detail.Controls.Add(panel_his);
                i++;
            }


        }

        private void panel_member_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
