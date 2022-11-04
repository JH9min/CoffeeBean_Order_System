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
using System.Globalization;

namespace HW2.Forms
{
    public partial class FormMenu : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";


        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listID = new List<int>();
        List<int>listStock=new List<int>();
        List<decimal> listDisc = new List<decimal>();
        List<Button> buttonList = new List<Button>();
        List<ComboBox> comboBoxList = new List<ComboBox>();

        public int productID = 0;

        string image_dir = @"C:\Users\iSpan\Desktop\HW2_newer_latest\icon_modded\";
        //string image_dir = @"C:\Users\Joe Houng\Desktop\change\C#\HW2_newer_latest\icon_modded\";
        string image_name = "";


        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            strDBconnectionString = GlobalVariable.MySqlConnect(scsb, strDBconnectionString);
            int product_num= Load_datatable();
            show_product(product_num);
            Panel p=new Panel();
            p.Dock = DockStyle.Bottom;
            p.Height = 100;
            Controls.Add(p);
            
        }




        private int Load_datatable()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select * from Stock where stock>0;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;

            while (dr.Read())
            {
                listID.Add((int)dr["item_id"]);
                listPname.Add(dr["item"].ToString());
                listPrice.Add((int)dr["price"]);
                listStock.Add((int)dr["stock"]);
                listDisc.Add((decimal)dr["discount"]);
                image_name = dr["image"].ToString();
                imageList_product.Images.Add(Image.FromFile(image_dir + image_name));
                i++;
            }

            dr.Close();
            con.Close();

            Console.WriteLine(i.ToString());
            return i;

        }


        private void show_product(int num)
        {
            int rows = num / 6;
            if (num%6!=0||rows==0)
            {
                rows+=1;
            }

            List<int> q_t=new List<int>();

            int index = 0;
            for(int i = 0; i < rows; i++)
            {

                if ((i+1)*6<=num)
                {
                    for(int j = 0; j < 6; j++)
                    {

                        Panel panel_back = new Panel();
                        PictureBox pic = new PictureBox();
                        Label lb_1 = new Label();
                        Label lb_2 = new Label();
                        ComboBox cbx = new ComboBox();
                        Button btn = new Button();

                        if (listDisc[index] != 0)
                        {
                            Label sale = new Label();
                            panel_back.Controls.Add(sale);
                            sale.BackColor = Color.FromArgb(215, 159, 107);
                            sale.ForeColor = Color.White;
                            sale.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                            sale.TextAlign = ContentAlignment.MiddleCenter;
                            sale.Location = new Point(20, 180);
                            sale.Size = new Size(100, 30);
                            sale.FlatStyle = FlatStyle.Flat;
                            int d = Convert.ToInt32(listDisc[index] * 100);

                            sale.Text = String.Format("{0}% OFF", d.ToString());
                        }

                        panel_back.Controls.Add(pic);
                        panel_back.Controls.Add(lb_1);
                        panel_back.Controls.Add(lb_2);
                        panel_back.Controls.Add(cbx);
                        panel_back.Controls.Add(btn);

                        if (num > 0)
                        {
                            panel_back.Visible = true;
                        }
                        else
                        {
                            panel_back.Visible = false;
                        }

                        panel_back.Name = index.ToString();
                        panel_back.BackColor = Color.FromArgb(255, 255, 255);
                        panel_back.Size = new Size(260, 340);
                        panel_back.Location = new Point(100 + 280 * j, 100 + 360 * i);



                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.Size = new Size(220, 210);
                        pic.Location = new Point(20, 10);
                        pic.Image = imageList_product.Images[index];


                        lb_1.Text = listPname[index];
                        lb_1.Size = new Size(220, 20);
                        lb_1.Location = new Point(20, 240);
                        lb_1.Name = "txtItem_" + index;
                        lb_1.Text = listPname[index];
                        lb_1.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                        lb_1.ForeColor = Color.FromArgb(57, 35, 20);
                        lb_1.TextAlign = ContentAlignment.MiddleCenter;

                        lb_2.Text = listPname[index];
                        lb_2.Size = new Size(220, 20);
                        lb_2.Location = new Point(20, 260);
                        lb_2.Name = "txtPrice_" + index;
                        lb_2.Text = "NT$ " + listPrice[index].ToString() + "半磅";
                        lb_2.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                        lb_2.ForeColor = Color.FromArgb(57, 35, 20);
                        lb_2.TextAlign = ContentAlignment.MiddleCenter;

                        cbx.BackColor = Color.FromArgb(138, 138, 138);
                        cbx.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                        cbx.ForeColor = Color.White;
                        cbx.Name = "cb_" + index;
                        for (int q = 1; q < listStock[index]; q++)
                        {
                            q_t.Add(q);
                            if (q == 10)
                                break;
                        }
                        foreach (int q in q_t)
                        {
                            cbx.Items.Add(q);
                        }
                        q_t.Clear();
                        cbx.Location = new Point(20, 300);
                        cbx.Size = new Size(130, 30);
                        cbx.FlatStyle = FlatStyle.Flat;
                        comboBoxList.Add(cbx);


                        btn.Name = "btn_" + index;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = Color.FromArgb(138, 138, 138);
                        btn.ForeColor = Color.White;
                        btn.Location = new Point(160, 300);
                        btn.Size = new Size(80, 30);
                        btn.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                        btn.Text = "ORDER";
                        btn.Click += new EventHandler(btn_click);


                        index++;
                        Controls.Add(panel_back);

                    }
                }

                else
                {
                    for(int j =0;j<num%6;j++)
                    {
                        Panel panel_back = new Panel();
                        PictureBox pic = new PictureBox();
                        Label lb_1 = new Label();
                        Label lb_2 = new Label();
                        ComboBox cbx = new ComboBox();
                        Button btn = new Button();

                        if (listDisc[index] != 0)
                        {
                            Label sale = new Label();
                            panel_back.Controls.Add(sale);
                            sale.BackColor = Color.FromArgb(215, 159, 107);
                            sale.ForeColor = Color.White;
                            sale.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                            sale.TextAlign = ContentAlignment.MiddleCenter;
                            sale.Location = new Point(20, 180);
                            sale.Size = new Size(100, 30);
                            sale.FlatStyle = FlatStyle.Flat;
                            int d = Convert.ToInt32(listDisc[index] * 100);

                            sale.Text = String.Format("{0}% OFF", d.ToString());
                        }

                        panel_back.Controls.Add(pic);
                        panel_back.Controls.Add(lb_1);
                        panel_back.Controls.Add(lb_2);
                        panel_back.Controls.Add(cbx);
                        panel_back.Controls.Add(btn);

                        if (num > 0)
                        {
                            panel_back.Visible = true;
                        }
                        else
                        {
                            panel_back.Visible = false;
                        }

                        panel_back.Name = index.ToString();
                        panel_back.BackColor = Color.FromArgb(255, 255, 255);
                        panel_back.Size = new Size(260, 340);
                        panel_back.Location = new Point(100 + 280 * j, 100 + 360 * i);



                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.Size = new Size(220, 210);
                        pic.Location = new Point(20, 10);
                        pic.Image = imageList_product.Images[index];


                        lb_1.Text = listPname[index];
                        lb_1.Size = new Size(220, 20);
                        lb_1.Location = new Point(20, 240);
                        lb_1.Name = "txtItem_" + index;
                        lb_1.Text = listPname[index];
                        lb_1.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                        lb_1.ForeColor = Color.FromArgb(57, 35, 20);
                        lb_1.TextAlign = ContentAlignment.MiddleCenter;

                        lb_2.Text = listPname[index];
                        lb_2.Size = new Size(220, 20);
                        lb_2.Location = new Point(20, 260);
                        lb_2.Name = "txtPrice_" + index;
                        lb_2.Text = "NT$ " + listPrice[index].ToString() + "半磅";
                        lb_2.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                        lb_2.ForeColor = Color.FromArgb(57, 35, 20);
                        lb_2.TextAlign = ContentAlignment.MiddleCenter;

                        cbx.BackColor = Color.FromArgb(138, 138, 138);
                        cbx.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                        cbx.ForeColor = Color.White;
                        cbx.Name = "cb_" + index;
                        for (int q = 1; q < listStock[index]; q++)
                        {
                            q_t.Add(q);
                            if (q == 10)
                                break;
                        }
                        foreach (int q in q_t)
                        {
                            cbx.Items.Add(q);
                        }
                        q_t.Clear();
                        cbx.Location = new Point(20, 300);
                        cbx.Size = new Size(130, 30);
                        cbx.FlatStyle = FlatStyle.Flat;
                        comboBoxList.Add(cbx);


                        btn.Name = "btn_" + index;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = Color.FromArgb(138, 138, 138);
                        btn.ForeColor = Color.White;
                        btn.Location = new Point(160, 300);
                        btn.Size = new Size(80, 30);
                        btn.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                        btn.Text = "ORDER";
                        btn.Click += new EventHandler(btn_click);


                        index++;
                        Controls.Add(panel_back);

                    }
                }

            }
            imageList_product.Images.Clear();
        }


        private void btn_click(object sender,EventArgs e)
        {
            if (GlobalVariable.member == "")
            {
                MessageBox.Show("You have log in first.\nPlease log in and try again.", "Order Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Button btn = (Button)sender;
                int i = Convert.ToInt32(btn.Name.Split('_')[1]);
                //MessageBox.Show(listPname[i] + "\n" + listPrice[i] + "\n" + comboBoxList[i].SelectedIndex);

                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = "insert into Cart values(@item_id,@num,@packPrice,@cartOwner)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@cartOwner", GlobalVariable.current_user);
                cmd.Parameters.AddWithValue("@item_id", listID[i]);
                //cmd.Parameters.AddWithValue("@price", listPrice[i]);
                cmd.Parameters.AddWithValue("@num", comboBoxList[i].SelectedIndex+1);
                cmd.Parameters.AddWithValue("@packPrice", listPrice[i] * (comboBoxList[i].SelectedIndex+1));


                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Order Succeed!", "succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }



    }
}
