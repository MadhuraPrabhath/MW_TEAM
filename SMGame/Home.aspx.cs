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
    public partial class Home : System.Web.UI.Page
    {
        string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
                BindData1();
                BindData2();
            }

            //SqlConnection connection;

            //SqlCommand command;


            // connection = new SqlConnection(connetionString);
            // try
            // {
            //    connection.Open();
            //    string name = "shehan";
            //   string password = "123";
            //   string sql = "Select * from SMUser where UserName='" + name + "' And Password='" + password + "'";
            //  SqlDataAdapter daAdapte = new SqlDataAdapter(sql, connection);
            //   DataSet ds = new DataSet();
            //  daAdapte.Fill(ds);
            //   DataTable dt = ds.Tables[0];
            //   foreach (DataRow row in dt.Rows)
            //   {
            //       lblAddress.Text = row[5].ToString();
            //      lblName.Text = row[1].ToString();
            //    lblContNum.Text = row[4].ToString();
            //  }
            //command = new SqlCommand(sql, connection);
            //dataReader = command.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    lblAddress.Text = "";
            //    lblName.Text = "";
            //    lblContNum.Text = "";
            //}
            //dataReader.Close();
            //command.Dispose();
            //daAdapte.Dispose();
            // connection.Close();

            //  }
            //   catch (Exception ex)
            //  {
            //     //MessageBox.Show("Can not open connection ! ");
            // }




            SqlConnection connection;

            SqlCommand command;


            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();

                string name = HttpContext.Current.Session["username"].ToString();
                //string email = HttpContext.Current.Session["useremail"].ToString(); 


                string sql = "Select * from SMUser where UserName='" + name + "'";


                SqlDataAdapter daAdapte = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                daAdapte.Fill(ds);
                DataTable dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    lblName.Text = name;
                    // lblemail.Text = email;


                }


                daAdapte.Dispose();
                connection.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
            }
        }


























        public void BindData()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con;
            con = new SqlConnection(connetionString);
            string name = HttpContext.Current.Session["username"].ToString();

            cmd.CommandText = "Select * from BankAccount where username='" + name + "'";
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
            Grid.DataSource = ds;
            Grid.DataBind();
            con.Close();
        }

        public void BindData1()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con;
            con = new SqlConnection(connetionString);
            cmd.CommandText = "SELECT a.SectorName, a.StockPrice, a.StockQuantity, a.CompanyName"
                                    + " FROM dbo.StockMarket a";
            //+ " INNER JOIN dbo.Sectors s ON a.SectorID=s.SectorID"
            // + " INNER JOIN dbo.Company c ON a.CompanyID=c.CompanyID";
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
            DataGrid1.DataSource = ds;
            DataGrid1.DataBind();
            con.Close();
        }

        public void BindData2()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con;
            con = new SqlConnection(connetionString);
            cmd.CommandText = "Select * from UserStock";
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
            DataGrid2.DataSource = ds;
            DataGrid2.DataBind();
            con.Close();
        }
        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            DataGrid1.CurrentPageIndex = e.NewPageIndex;
            BindData1();
        }
        protected void DataGrid1_EditCommand(object source, DataGridCommandEventArgs e)
        {
            DataGrid1.EditItemIndex = e.Item.ItemIndex;
            BindData1();
        }
        protected void DataGrid1_CancelCommand(object source, DataGridCommandEventArgs e)
        {
            DataGrid1.EditItemIndex = -1;
            BindData1();
        }
        protected void DataGrid1_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            //con = new SqlConnection(ConfigurationManager.AppSettings["connect"]);
            //cmd.Connection = con;
            //int EmpId = (int)Grid.DataKeys[(int)e.Item.ItemIndex];
            //cmd.CommandText = "Delete from Employee where EmpId=" + EmpId;
            //cmd.Connection.Open();
            //cmd.ExecuteNonQuery();
            //cmd.Connection.Close();
            //Grid.EditItemIndex = -1;
            //BindData();
        }
        protected void DataGrid1_UpdateCommand(object source, DataGridCommandEventArgs e)
        {
            //con = new SqlConnection(ConfigurationManager.AppSettings["connect"]);
            //cmd.Parameters.Add("@EmpId", SqlDbType.Int).Value = ((TextBox)e.Item.Cells[0].Controls[0]).Text;
            //cmd.Parameters.Add("@F_Name", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[1].Controls[0]).Text;
            //cmd.Parameters.Add("@L_Name", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[2].Controls[0]).Text;
            //cmd.Parameters.Add("@City", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[3].Controls[0]).Text;
            //cmd.Parameters.Add("@EmailId", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[4].Controls[0]).Text;
            //cmd.Parameters.Add("@EmpJoining", SqlDbType.DateTime).Value = DateTime.Now.ToString();
            //cmd.CommandText = "Update Employee set F_Name=@F_Name,L_Name=@L_Name,City=@City,EmailId=@EmailId,EmpJoining=@EmpJoining where EmpId=@EmpId";
            //cmd.Connection = con;
            //cmd.Connection.Open();
            //cmd.ExecuteNonQuery();
            //cmd.Connection.Close();
            //Grid.EditItemIndex = -1;
            //BindData();
        }

        protected void Grid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            Grid.CurrentPageIndex = e.NewPageIndex;
            BindData();
        }
        protected void Grid_EditCommand(object source, DataGridCommandEventArgs e)
        {
            Grid.EditItemIndex = e.Item.ItemIndex;
            BindData();
        }
        protected void Grid_CancelCommand(object source, DataGridCommandEventArgs e)
        {
            Grid.EditItemIndex = -1;
            BindData();
        }
        protected void Grid_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            //con = new SqlConnection(ConfigurationManager.AppSettings["connect"]);
            //cmd.Connection = con;
            //int EmpId = (int)Grid.DataKeys[(int)e.Item.ItemIndex];
            //cmd.CommandText = "Delete from Employee where EmpId=" + EmpId;
            //cmd.Connection.Open();
            //cmd.ExecuteNonQuery();
            //cmd.Connection.Close();
            //Grid.EditItemIndex = -1;
            //BindData();
        }
        protected void Grid_UpdateCommand(object source, DataGridCommandEventArgs e)
        {
            //con = new SqlConnection(ConfigurationManager.AppSettings["connect"]);
            //cmd.Parameters.Add("@EmpId", SqlDbType.Int).Value = ((TextBox)e.Item.Cells[0].Controls[0]).Text;
            //cmd.Parameters.Add("@F_Name", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[1].Controls[0]).Text;
            //cmd.Parameters.Add("@L_Name", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[2].Controls[0]).Text;
            //cmd.Parameters.Add("@City", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[3].Controls[0]).Text;
            //cmd.Parameters.Add("@EmailId", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[4].Controls[0]).Text;
            //cmd.Parameters.Add("@EmpJoining", SqlDbType.DateTime).Value = DateTime.Now.ToString();
            //cmd.CommandText = "Update Employee set F_Name=@F_Name,L_Name=@L_Name,City=@City,EmailId=@EmailId,EmpJoining=@EmpJoining where EmpId=@EmpId";
            //cmd.Connection = con;
            //cmd.Connection.Open();
            //cmd.ExecuteNonQuery();
            //cmd.Connection.Close();
            //Grid.EditItemIndex = -1;
            //BindData();
        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            //SqlConnection con;
            //con = new SqlConnection(ConfigurationManager.AppSettings["connect"]);
            //con.Open();
            //SqlCommand cmd;
            //cmd = new SqlCommand("Insert into Employee (EmpId,F_Name,L_Name,City,EmailId,EmpJoining) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con);
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = "";
            //TextBox2.Text = "";
            //TextBox3.Text = "";
            //TextBox4.Text = "";
            //TextBox5.Text = "";
            //TextBox6.Text = "";
        }
        protected void btnOk_Click(object sender, EventArgs e)
        {
            //BindData1();
        }

        protected void GetUserDetails(object sender, EventArgs e)
        {
        }





    }
}