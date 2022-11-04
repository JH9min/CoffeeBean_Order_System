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
    public partial class FormManagement : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";
        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listID = new List<int>();
        List<int> listStock = new List<int>();
        List<decimal> listDisc=new List<decimal>();

        public int productID = 0;

        bool ischangeImage = false;

        string image_dir = @"C:\Users\iSpan\Desktop\HW2_newer_latest\icon_modded\";
        //string image_dir = @"C:\Users\Joe Houng\Desktop\change\C#\HW2_newer_latest\icon_modded\";
        string image_name = "";


        bool txtIsEnter_1=false;


        public FormManagement()
        {
            InitializeComponent();
        }

        private void FormManagement_Load(object sender, EventArgs e)
        {
            strDBconnectionString = GlobalVariable.MySqlConnect(scsb,strDBconnectionString);
            Load_datatable();
            showListviewModeImage();
            if (productID != 0)
            {
                showProductInfo();
            }
        }

        void Load_datatable()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select * from Stock;";
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
            Console.WriteLine(i);
            dr.Close();
            con.Close();


        }


        void showListviewModeImage()
        {
            lv_product.Clear();
            lv_product.View = View.LargeIcon;
            imageList_product.ImageSize = new Size(80, 120);
            lv_product.LargeImageList = imageList_product;
            lv_product.SmallImageList = imageList_product;

            for (int i = 0; i < imageList_product.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
                item.Text = listPname[i];
                item.Tag = listID[i];
                lv_product.Items.Add(item);
            }

        }
        
        void showListviewModeLIst()
        {
            lv_product.Clear();
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 25);
            lv_product.SmallImageList = imgList;

            lv_product.Clear();
            lv_product.LargeImageList = null;

            lv_product.Font= new Font("微軟正黑體", 14, FontStyle.Regular);
            lv_product.View = View.Details;
            lv_product.Columns.Add("ID", 100);
            lv_product.Columns.Add("Name", 200);
            lv_product.Columns.Add("Price", 100);
            lv_product.Columns.Add("Stock", 100);
            lv_product.Columns.Add("Discoount", 120);
            lv_product.FullRowSelect = true;
            lv_product.GridLines = true;


            for (int i = 0; i < listID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listID[i].ToString();
                item.SubItems.Add(listPname[i].ToString());
                item.SubItems.Add(listPrice[i].ToString());
                item.SubItems.Add(listStock[i].ToString());
                item.SubItems.Add(listDisc[i].ToString());
                item.Tag = listID[i];
                lv_product.Items.Add(item);
            }
        }
        


        void showProductInfo()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select * from Stock where item_id=@searchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@searchID", productID);
            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                lb_id.Text = dr["item_id"].ToString();
                txt_name.Text = dr["item"].ToString();
                txt_price.Text = dr["price"].ToString();
                txt_stock.Text = dr["stock"].ToString();
                txt_discount.Text = dr["discount"].ToString();
                image_name = dr["image"].ToString();
                pictureBox1.Image = Image.FromFile(image_dir + image_name);
                i++;

            }


        }

        private void btn_selected_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();//檔案對話框
            f.Filter = "Type(*.jpg,*.jpeg,*.png)|*.jpeg;*.jpg;*.png";
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);
                Random r = new Random();
                //image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + r.Next(1000, 10000).ToString() + fileExt;//定新名字
                image_name = f.SafeFileName;
                Console.WriteLine(image_name);


            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lb_id.Text = "";
            txt_name.Clear();
            txt_price.Clear();
            txt_stock.Clear();
            pictureBox1.Image = null;
            productID = 0;

        }


        private void btn_insert_Click(object sender, EventArgs e)
        {
            bool isPrice = GlobalVariable.txt_check(txt_price, "^[0-9]*$");
            bool isStock = GlobalVariable.txt_check(txt_stock, "^[0-9]*$");
            if (txt_name.Text != "" && txt_price.Text != "" && txt_stock.Text != "" && pictureBox1.Image != null&&isStock&&isPrice)
            {
                if (ischangeImage)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    ischangeImage = false;
                }
                

                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = "insert into Stock values(@NewName, @NewPrice,@NewStock,@NewImage,@NewDisc,@NewLoadDate,@NewLoader);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt_name.Text);
                int price = 0;
                Int32.TryParse(txt_price.Text, out price);
                cmd.Parameters.AddWithValue("@NewPrice", price);
                cmd.Parameters.AddWithValue("@NewStock", txt_stock.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_name);
                cmd.Parameters.AddWithValue("@NewDisc", txt_discount.Text);
                cmd.Parameters.AddWithValue("@NewLoadDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@NewLoader", GlobalVariable.current_user);


                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insert succeeded !","Success",MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Please enter correct formatted Info.","Insert Failed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Reload();
        }

        private void lv_product_ItemActivate(object sender, EventArgs e)
        {
            productID = Convert.ToInt32(lv_product.SelectedItems[0].Tag);
            showProductInfo();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            bool isPrice = GlobalVariable.txt_check(txt_price, "^[0-9]*$");
            bool isStock = GlobalVariable.txt_check(txt_stock, "^[0-9]*$");
            if (txt_name.Text != "" && txt_price.Text != "" && txt_stock.Text != "" && pictureBox1.Image != null && isStock && isPrice)
            {
                if (ischangeImage)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    ischangeImage = false;
                }

                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = "update Stock set item=@NewName, price=@NewPrice,stock=@NewStock,image=@NewImage,loadDate=@NewLoadDate,loader_id=@NewLoader where item_id=@id;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@id", productID);
                cmd.Parameters.AddWithValue("@NewName", txt_name.Text);
                int price = 0;
                Int32.TryParse(txt_price.Text, out price);
                cmd.Parameters.AddWithValue("@NewPrice", price);
                cmd.Parameters.AddWithValue("@NewStock", txt_stock.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_name);
                cmd.Parameters.AddWithValue("@NewDisc", txt_discount.Text);
                cmd.Parameters.AddWithValue("@NewLoadDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@NewLoader",GlobalVariable.current_user);


                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update succeeded !", "Success", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Please enter the correct formatted Info.","Update Failed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Reload();
        }



        private void Reload()
        {
            listID.Clear();
            listPname.Clear();
            listPrice.Clear();
            listDisc.Clear();
            listStock.Clear();
            imageList_product.Images.Clear();
            Load_datatable();

            if (lv_product.View == View.Details)
            {
                showListviewModeLIst();
            }
            else
            {
                showListviewModeImage();
            }
        }

        private void btn_changeMode_Click(object sender, EventArgs e)
        {
            if(lv_product.View == View.Details)
            {
                lv_product.View = View.LargeIcon;
            }
            else
            {
                lv_product.View = View.Details;
            }
            Reload();
        }
    }
}
