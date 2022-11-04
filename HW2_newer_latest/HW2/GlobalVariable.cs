using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace HW2
{
    internal class GlobalVariable
    {
        public static string member = "";
        public static bool isLogIn = false; 
        public static int current_user=-1;
        public static int authority=-1;


        public static Form form_active;

        public static List<string> listIndexOfOrder = new List<string>();

        public static string MySqlConnect(SqlConnectionStringBuilder scsb,string strDBconnectionString)
        {

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = ".";//SERVER NAME or DOMAIN NAME or IP ADDRESS
            scsb.InitialCatalog = "mydb";//DB NAME
            scsb.IntegratedSecurity = true;
            strDBconnectionString = scsb.ToString();
            return strDBconnectionString;
        }

        public static void label_check(TextBox t, Label l)
        {
            if (t.Text == "" || t.Text == t.Tag.ToString())
            {
                l.Text = "*";
            }
            else
            {
                l.Text = "";
            }
        }


        public static bool txt_check(TextBox sender, string requirement)
        {
            bool result = false;
            if (Regex.IsMatch(sender.Text, requirement) && sender.Text != sender.Tag.ToString())
            {
                result = true;
            }
            Console.WriteLine(result);
            return result;
        }

    }
}
