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

namespace HW2.Forms
{
    public partial class FormManageOrder : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";

        public FormManageOrder()
        {
            InitializeComponent();
        }

        private void FormManageOrder_Load(object sender, EventArgs e)
        {

            cbx_searchColumn.Items.Add("Order ID");
            cbx_searchColumn.Items.Add("Orderer");
            cbx_searchColumn.Items.Add("Mobile");
            cbx_searchColumn.Items.Add("Email");
            cbx_searchColumn.Items.Add("Address");
            cbx_searchColumn.SelectedIndex = 0;

            cbx_status.Items.Add("processing");
            cbx_status.Items.Add("completed");
            cbx_status.SelectedIndex = 0;
            strDBconnectionString = GlobalVariable.MySqlConnect(scsb, strDBconnectionString);
            string strSQL = "select distinct o.order_id,totalPrice,status,o.orderDate,o.orderer_id,m.[name],m.mobile,m.email,m.[address] from [Order] as o,OrderDetail as d,Member as m where o.order_id=d.order_id and m.[user_id]=o.orderer_id order by o.order_id;";
            GenerateMemberInfoList(strSQL,dgv_order,"");
            
        }


        void GenerateMemberInfoList(string strSQL, DataGridView dgv,string searchTarget)
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(strSQL, con);
            if(searchTarget!="")
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

        void ClearAll()
        {
            lb_order_id.Text = string.Empty;
            lb_orderer.Text = string.Empty;
            lb_address.Text = string.Empty;
            lb_amount.Text = string.Empty;
            lb_email.Text = string.Empty;
            lb_item.Text = string.Empty;
            lb_mobile.Text = string.Empty;
            lb_revenue.Text = string.Empty;
            lb_sum.Text = string.Empty;
            dtp_orderDate.Value = DateTime.Now;
            txt_search.Text=string.Empty;

        }
        

        private void dgv_order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgv_order.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelID);

                if (isID)
                {
                    SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string strSQL = "select distinct o.order_id,totalPrice,o.status,o.orderDate,o.orderer_id,m.[name],m.mobile,m.email,m.[address] from [Order] as o,OrderDetail as d,Member as m where o.order_id=d.order_id and m.[user_id]=o.orderer_id and o.order_id=@SearchID order by o.order_id;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelID);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lb_order_id.Text = dr["order_id"].ToString();
                        lb_orderer.Text = dr["name"].ToString();
                        lb_mobile.Text = dr["mobile"].ToString();
                        lb_email.Text = dr["email"].ToString();
                        lb_address.Text = dr["address"].ToString();
                        lb_revenue.Text = dr["totalPrice"].ToString();
                        if (dr["status"].ToString() == "completed")
                            cbx_status.SelectedIndex = 1;
                        else
                            cbx_status.SelectedIndex = 0;
                        dtp_orderDate.Value = Convert.ToDateTime(dr["orderDate"]);
                        dr.Close();
                        con.Close();
                        strSQL = "select d.id, o.order_id,d.item_id,s.item,d.num,packPrice from [Order] as o,OrderDetail as d,Stock as s where o.order_id=d.order_id and s.item_id=d.item_id  and o.order_id=@SearchTarget order by o.order_id;";
                        
                        GenerateMemberInfoList(strSQL, dgv_orderDetail, lb_order_id.Text);


                    }
                    else
                    {
                        dr.Close();
                        con.Close();
                        MessageBox.Show("查無此人");

                    }

                    
                    
                }
            }
        }

        private void dgv_orderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgv_orderDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
                string strSelectedItem = dgv_orderDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
                string strSelectedAmount = dgv_orderDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
                string strSelectedSum = dgv_orderDetail.Rows[e.RowIndex].Cells[5].Value.ToString();


                lb_item.Tag = strSelectedID;
                lb_item.Text = strSelectedItem;
                lb_amount.Text = strSelectedAmount;
                lb_sum.Text = strSelectedSum;
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearAll();
            dgv_orderDetail.DataSource = null;
            cbx_searchColumn.SelectedIndex = 0;
            string strSQL = "select distinct o.order_id,totalPrice,status,o.orderDate,o.orderer_id,m.[user_id],m.[name],m.mobile,m.email,m.[address] from [Order] as o,OrderDetail as d,Member as m where o.order_id=d.order_id and m.[user_id]=o.orderer_id order by o.order_id;";
            GenerateMemberInfoList(strSQL, dgv_order, "");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_order.DataSource = null;
            dgv_orderDetail.DataSource=null;
            string strSearchColumn="";
            switch  (cbx_searchColumn.SelectedIndex)
            {


                case 1:
                    strSearchColumn = "m.[name]";
                    break;
                case 2:
                    strSearchColumn = "m.mobile";
                    break ;
                case 3:
                    strSearchColumn = "m.email";
                    break;
                case 4:
                    strSearchColumn = "m.[address]";
                    break;
                default:
                    strSearchColumn = "o.order_id";
                    break;

            }

            string strSQL = "select distinct o.order_id,totalPrice,status,o.orderDate,o.orderer_id,m.[user_id],m.[name],m.mobile,m.email,m.[address] from [Order] as o,OrderDetail as d,Member as m where o.order_id=d.order_id and m.[user_id]=o.orderer_id and "+strSearchColumn+" like '%"+txt_search.Text+"%' order by o.order_id;";
            GenerateMemberInfoList(strSQL, dgv_order,"");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string strSQL = "update [Order] set status=@status where order_id=@id";
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            SqlCommand cmd =new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@status", cbx_status.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@id",lb_order_id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            strSQL = "select distinct o.order_id,totalPrice,status,o.orderDate,o.orderer_id,m.[user_id],m.[name],m.mobile,m.email,m.[address] from [Order] as o,OrderDetail as d,Member as m where o.order_id=d.order_id and m.[user_id]=o.orderer_id order by o.order_id;";
            GenerateMemberInfoList(strSQL, dgv_order, "");
            ClearAll();
        }

        private void cbx_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtp_orderDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
