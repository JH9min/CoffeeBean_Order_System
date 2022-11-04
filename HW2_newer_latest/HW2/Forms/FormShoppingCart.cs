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
using System.Diagnostics;
using System.Xml.Linq;
using System.Data.SqlClient;


namespace HW2.Forms
{
    public partial class FormShoppingCart : Form
    {
        String listboxColumns = "{0,2}.   {1}     {2,3}份         NT${3,5}元";
        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";



        public FormShoppingCart()
        {
            InitializeComponent();
        }

        private void TotalPrice()
        {
            decimal total = 0;

            foreach(object item in listBox_itemOrderList.Items)
            {
                
                string totalPrice_sum=item as string;
                totalPrice_sum=totalPrice_sum.Trim().Split('$')[1];
                totalPrice_sum = totalPrice_sum.Substring(0, totalPrice_sum.Length - 1);
                int t = Convert.ToInt32(totalPrice_sum);

                total += t;
            }



            if (total == 0)
            {
                lb_total.Text = "OOPS!!\nNothing's here";
            }
            else
            {      
                lb_total.Text = "NT$" + total.ToString();

            }
        }






        private void FormShoppingCart_Load(object sender, EventArgs e)
        {
            cart_load();
        }



        private void cart_load()
        {
            GlobalVariable.listIndexOfOrder.Clear();
            listBox_itemOrderList.Items.Clear();
            lb_user_name.Text = GlobalVariable.member;
            if (lb_user_name.Text != "")
            {

                strDBconnectionString = GlobalVariable.MySqlConnect(scsb, strDBconnectionString);

                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = "select id,item,num,packPrice,discount from Cart as c inner join Stock as s on s.item_id=c.item_id where c.cartOwner=@user_id;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@user_id", GlobalVariable.current_user);
                SqlDataReader dr = cmd.ExecuteReader();


                int i = 1;

                while (dr.Read())
                {
                    string selectedProduct = dr["item"].ToString();
                    int selectedAmount = Convert.ToInt32(dr["num"]);
                    int selectedPackPrice = Convert.ToInt32(dr["packPrice"]);

                    decimal selectedDisc = selectedPackPrice * (1 - Convert.ToDecimal(dr["discount"]));

                    GlobalVariable.listIndexOfOrder.Add(dr["id"].ToString());


                    listBox_itemOrderList.Items.Add(String.Format(listboxColumns, i, padRightEx(selectedProduct, 20), selectedAmount, Math.Round(selectedDisc)));

                    i++;
                }


                dr.Close();
                con.Close();

                TotalPrice();

            }
        }

        

        private void btn_selected_Click(object sender, EventArgs e)
        {
            if (listBox_itemOrderList.SelectedIndex > -1)
            {

                int selIndex = listBox_itemOrderList.SelectedIndex;
                listBox_itemOrderList.Items.RemoveAt(selIndex);

                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = "delete from Cart where id=@id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@id", GlobalVariable.listIndexOfOrder[selIndex]);

                cmd.ExecuteNonQuery();
                GlobalVariable.listIndexOfOrder.RemoveAt(selIndex);

                con.Close();
                cart_load();

            }
            else
            {
                MessageBox.Show("You Have selected nothing.\nPlease select one order.","Delete Failed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            listBox_itemOrderList.Items.Clear();
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "delete from Cart where cartOwner=@cartOwner";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@cartOwner",GlobalVariable.current_user);
            cmd.ExecuteNonQuery();

            con.Close();
            cart_load();

        }

        private static string padRightEx(string str,int bytecount)
        {
            Encoding coding = Encoding.UTF8;
            int count = 0;
            foreach(char c in str.ToCharArray())
            {
                if(coding.GetByteCount(c.ToString())>1)
                {
                    count++;
                }
            }
            string result = str.PadRight(bytecount - count);
            return result;
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "insert into [Order](totalPrice,orderer_id,orderDate,status) select sum(packPrice*(1-discount)),cartOwner,GETDATE(),'processing' from Cart as c,Stock as s where c.item_id=s.item_id and  cartOwner=@cartOwner group by cartOwner;"
                + "insert into [OrderDetail](order_id,item_id,num,packPrice)　 select o.order_id,c.item_id,c.num,c.packPrice*(1-discount) from [Order] as o,Stock as s,Cart as c　where order_id=( select top 1 order_id from [Order] order by order_id Desc)　and cartOwner=@cartOwner and s.item_id=c.item_id;"
                +"delete from Cart where cartOwner=@cartOwner;"
                +"update Stock  set stock=(stock-o.num) from OrderDetail as o where Stock.item_id=o.item_id and o.order_id=(select top 1 order_id from [Order] order by order_id Desc)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@cartOwner", GlobalVariable.current_user);
            cmd.ExecuteNonQuery();
            cart_load();
            
            MessageBox.Show("Order Succeeded!");

        }
    }
}
