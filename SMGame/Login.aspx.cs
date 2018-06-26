using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMGame
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.InnerText = "";
            string name = txtLgUserName.Text;
            string password = txtLgPassword.Text;

            bool isExsist = GetLoginDetails(name, password);
            if (isExsist)
            {
                HttpContext.Current.Session["username"] = name;
                SetLog(name);
                Response.Redirect("Home.aspx");
            }
            else
                lblError.InnerText = "Invalid Username or Password";
        }

        public static bool GetLoginDetails(string name, string password)
        {
            string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            SqlConnection connection;

            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;

            bool isExsist = false;
            sql = "Select * from SMUser where UserName='" + name + "' And Password='" + password + "'";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    isExsist = true;
                   
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
            }
            return isExsist;
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtLgUserName.Text = "";
            txtLgPassword.Text = "";
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string msg = "";
            string username = txtRgUserName.Text;
            string password = txtRgPassword.Text;
            string passwordConf = txtRgCmPassword.Text;
            string email = txtRgEmail.Text;
            string bankname = txtBankName.Text;
            string accNumber = txtAccountNo.Text;

            if (password != passwordConf)
                msg = "Password Not Matched";


            bool isRegitered = SetRegister(username, password, email, bankname, accNumber);

            if (isRegitered)
            {
                msg = "Successfully Registered";

                txtRgUserName.Text = "";
                txtRgPassword.Text = "";
                txtRgCmPassword.Text = "";
                txtRgEmail.Text = "";
                txtBankName.Text = "";
                txtAccountNo.Text = "";
            }
        }

        public static bool SetRegister(string username, string password, string email, string bankname, string accNumber)
        {
            bool isRegitered = false;
            string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO SMUser (Email, Password, UserName, Name) VALUES ('" + email + "', '" + password + "', '" + username + "', 'Oleen Perera')";

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        isRegitered = true;
                    }
                    catch (SqlException e)
                    {
                        conn.Close();
                        isRegitered = false;
                    }

                }
            }
            return isRegitered;
        }

        public static void SetLog(string username)
        {
            string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO LoginUser (UserName) VALUES ('" + username + "')";

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                    }
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtRgUserName.Text = "";
            txtRgPassword.Text = "";
            txtRgCmPassword.Text = "";
            txtRgEmail.Text = "";
            txtBankName.Text = "";
            txtAccountNo.Text = "";
        }
    }
}