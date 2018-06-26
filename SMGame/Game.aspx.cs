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
    public partial class Game : System.Web.UI.Page
    {
        string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string round = lblGame_Round.InnerText;
            string time = timer.InnerText;
            //bool isOk = UserCount();
            // if (isOk)
            //   btnStartGame.Enabled = true;
            // else
            //  btnStartGame.Enabled = false;

            if (!Page.IsPostBack)
            {
               // BindData();
                BindData1();
                BindData2();
                BindData3();
                BindData4();
            }

            SqlConnection connection;

            SqlCommand command;


            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                string name = HttpContext.Current.Session["username"].ToString();
                string sql = "Select * from UserStock where UserName='" + name + "'";
                SqlDataAdapter daAdapte = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                daAdapte.Fill(ds);
                DataTable dt = ds.Tables[0];
                lblGame_Name.InnerText = name;
               // lblGame_Round.InnerText = "1";
                foreach (DataRow row in dt.Rows)
                {
                    lblGame_Profit.InnerText = row[5].ToString();
                }
             
                daAdapte.Dispose();
                connection.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
            }
            lblGame_Round.InnerText = round;
            timer.InnerText = time;
        }

        public void BindData4()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con;
            con = new SqlConnection(connetionString);
            string name = HttpContext.Current.Session["username"].ToString();
            cmd.CommandText = "SELECT ROW_NUMBER() OVER(ORDER BY SUM(TotalAmount) DESC) AS Rank,UserName, SUM(TotalAmount) as TotalAmount FROM UserStorkMatket group by UserName order by SUM(TotalAmount) DESC";
            // + " INNER JOIN dbo.Sectors s ON a.SectorID=s.SectorID"
            // + " INNER JOIN dbo.Company c ON a.CompanyID=c.CompanyID  where a.UserName='" + name + "'";
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
            gvWinner.DataSource = ds;
            gvWinner.DataBind();
            con.Close();
        }
        public void BindData2()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con;
            con = new SqlConnection(connetionString);
            string name = HttpContext.Current.Session["username"].ToString();
            cmd.CommandText = "Select a.SectorName, a.StockPrice, a.StockQuantity, a.CompanyName, a.TotalAmount, a.UserName from dbo.UserStock a  where a.UserName='" + name + "'";
            // + " INNER JOIN dbo.Sectors s ON a.SectorID=s.SectorID"
            // + " INNER JOIN dbo.Company c ON a.CompanyID=c.CompanyID  where a.UserName='" + name + "'";
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
            DataGrid2.DataSource = ds;
            DataGrid2.DataBind();
            con.Close();
        }

        public void BindData3()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con;
            con = new SqlConnection(connetionString);
            cmd.CommandText = "SELECT a.SectorName, a.StockPrice, a.StockQuantity, a.CompanyName"
                                    + " FROM dbo.StockMarket a";
                                   // + " INNER JOIN dbo.Sectors s ON a.Sector=s.Sector"
                                   // + " INNER JOIN dbo.Company c ON a.Company=c.Company";
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
            DataGrid3.DataSource = ds;
            DataGrid3.DataBind();
            con.Close();
        }
        public void BindData1()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con;
            con = new SqlConnection(connetionString);
            string name = HttpContext.Current.Session["username"].ToString();
            cmd.CommandText = "Select a.SectorName, a.StockPrice, a.StockQuantity, a.CompanyName, a.TotalAmount, a.UserName from dbo.UserStorkMatket a";// where a.UserName='" + name + "'";
            // + " INNER JOIN dbo.Sectors s ON a.Sector=s.Sector"
           // + " INNER JOIN dbo.Company c ON a.Company=c.Company  where a.UserName='" + name + "'";
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
            DataGrid1.DataSource = ds;
            DataGrid1.DataBind();
            con.Close();
        }

        public bool UserCount()
        {
            //string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            SqlConnection connection;

            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;

            int count = 0;
            sql = "select * from LoginUser";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    count = count + 1;
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();

            }
            catch (Exception ex)
            {
                connection.Close();
                //MessageBox.Show("Can not open connection ! ");
            }
            if (count >= 3)
                return true;
            else
                return false;
        }

        protected void btnStartGame_Click(object sender, EventArgs e)
        {
            string script = "startTimer()";
            ClientScript.RegisterStartupScript(this.GetType(), "startTimer", script, true);
        }
        protected void btnNextRound_Click(object sender, EventArgs e)
        {
            bool isRegitered =  UpdateStock();
            BindData3();
          string script = "play()";
          ClientScript.RegisterStartupScript(this.GetType(), "startTimer", script, true);
        }

        public static bool UpdateStock()
        {
            bool isRegitered = false;
            string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE [StockMarket] SET StockPrice = ABS(CHECKSUM(NEWID())) % 100 + 100";

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
        protected void OnRowDataBound_DataGrid2(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(DataGrid2, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }

        protected void OnSelectedIndexChanged_DataGrid2(object sender, EventArgs e)
        {
            lblSector.Text = DataGrid2.SelectedRow.Cells[1].Text;
            lblCompany.Text = DataGrid2.SelectedRow.Cells[2].Text;
            lblStockQty.Text = DataGrid2.SelectedRow.Cells[3].Text;
            //Madhura has commented -- lblStockPrice.Text = DataGrid2.SelectedRow.Cells[4].Text;
            //Madhura has added below line
            txtStockPriceNew.Text = DataGrid2.SelectedRow.Cells[4].Text;

            //lblSector.Text = DataGrid2.SelectedRow.Cells[0].Text;
            //lblSector.Text = DataGrid2.SelectedRow.Cells[0].Text;
           // string message = "Row Index: " + index + "\\nName: " + name + "\\nCountry: " + country;
            ClientScript.RegisterStartupScript(this.GetType(), "MSG", "OpenModel();", true);
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            string sector = lblSector.Text;
            string company = lblCompany.Text;
            //Madhura has commented -- decimal price = Convert.ToDecimal(lblStockPrice.Text);
            int stockQty = Convert.ToInt32(lblStockQty.Text);
            int qty = Convert.ToInt32(txtStockQty.Text);
          //Madhura has added below record
            int price = Convert.ToInt32(txtStockPriceNew.Text);
            string name = HttpContext.Current.Session["username"].ToString();
            bool isSaved = Save(name, sector, company, qty, price, 2);
            if (isSaved)
            {
               // BindData1();
                bool isUpdate = Update(name, sector, company, stockQty - qty, price);
                string script = "alert('Successfully Saved.');";
                // ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                BindData2();
                BindData1();
                BindData3();
                txtStockQty2.Text = "";
                txtStockQty.Text = "";
                txtStockPriceNew.Text = "";
                txtStockQty3.Text = "";
                // ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
        }

        protected void btnBuy_Click2(object sender, EventArgs e)
        {
            string sector = lblSector2.Text;
            string company = lblCompany2.Text;
            decimal price = Convert.ToDecimal(lblStockPrice2.Text);
            int stockQty = Convert.ToInt32(lblStockQty2.Text);
            int qty = Convert.ToInt32(txtStockQty2.Text);
            string name = HttpContext.Current.Session["username"].ToString();
            bool isSaved = Save(name, sector, company, qty, price,1);
            if (isSaved)
            {
               
              //  BindData3();
                bool isUpdate = Update2(name, sector, company, stockQty - qty, price);
                string script = "alert('Successfully Saved.');";
                // ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                BindData2();
                BindData1();
                BindData3();
                txtStockQty2.Text = "";
                txtStockQty.Text = "";
                txtStockQty3.Text = "";
                // ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
        }

        protected void OnRowDataBound_DataGrid3(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(DataGrid3, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }
        protected void OnSelectedIndexChanged_DataGrid3(object sender, EventArgs e)
        {
            lblSector2.Text = DataGrid3.SelectedRow.Cells[0].Text;
            lblCompany2.Text = DataGrid3.SelectedRow.Cells[1].Text;
            lblStockQty2.Text = DataGrid3.SelectedRow.Cells[2].Text;
            lblStockPrice2.Text = DataGrid3.SelectedRow.Cells[3].Text;
            //lblSector.Text = DataGrid2.SelectedRow.Cells[0].Text;
            //lblSector.Text = DataGrid2.SelectedRow.Cells[0].Text;
            // string message = "Row Index: " + index + "\\nName: " + name + "\\nCountry: " + country;
            ClientScript.RegisterStartupScript(this.GetType(), "MSG", "OpenModel2();", true);
        }

        protected void btnBuy_Click3(object sender, EventArgs e)
        {
            string sector = lblSector3.Text;
            string company = lblCompany3.Text;
            decimal price = Convert.ToDecimal(lblStockPrice3.Text);
            int stockQty = Convert.ToInt32(lblStockQty3.Text);
            int qty = Convert.ToInt32(txtStockQty3.Text);
            string name = HttpContext.Current.Session["username"].ToString();
            bool isSaved = Save(name, sector, company, qty, price, 1);
            if (isSaved)
            {

                
                bool isUpdate = Update1(name, sector, company, stockQty - qty, price);
                string script = "alert('Successfully Saved.');";
                // ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                BindData2();
                BindData1();
                BindData3();
                txtStockQty2.Text = "";
                txtStockQty.Text = "";
                txtStockQty3.Text = "";
                //  ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
        }

        protected void OnRowDataBound_DataGrid1(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(DataGrid1, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }
        protected void OnSelectedIndexChanged_DataGrid1(object sender, EventArgs e)
        {
            lblSector3.Text = DataGrid1.SelectedRow.Cells[1].Text;
            lblCompany3.Text = DataGrid1.SelectedRow.Cells[2].Text;
            lblStockQty3.Text = DataGrid1.SelectedRow.Cells[3].Text;
            lblStockPrice3.Text = DataGrid1.SelectedRow.Cells[4].Text;
            //lblSector.Text = DataGrid2.SelectedRow.Cells[0].Text;
            //lblSector.Text = DataGrid2.SelectedRow.Cells[0].Text;
            // string message = "Row Index: " + index + "\\nName: " + name + "\\nCountry: " + country;
            ClientScript.RegisterStartupScript(this.GetType(), "MSG", "OpenModel3();", true);
        }

        public static bool Save(string username, string sector, string company, int qty, decimal price, int tpye)
        {
            bool isRegitered = false;
            string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    if (tpye == 1)
                    {
                        bool isExsist = CheckisExsistRecord(username, sector, company, qty, price, tpye);
                        if (!isExsist)
                            cmd.CommandText = "INSERT INTO UserStock (UserName, SectorName, CompanyName, StockQuantity, StockPrice, TotalAmount) VALUES ('" + username + "', '" + sector + "', '" + company + "','" + qty + "', '" + price + "','" + (qty * price) + "')";
                        else
                        {
                            //cmd.CommandText = "INSERT INTO UserStorkMatket (UserName, SectorName, CompanyName, StockQuantity, StockPrice, TotalAmount) VALUES ('" + username + "', '" + sector + "', '" + company + "','" + qty + "', '" + price + "','" + (qty * price) + "')";
                            cmd.CommandText = "UPDATE UserStock"
                                              + "  SET StockQuantity = StockQuantity + " + qty
                                              + "  WHERE UserName = '" + username + "' AND StockPrice = " + price + " AND SectorName = '" + sector + "' AND CompanyName = '" + company + "'";
                        }
                    }
                    else
                    {
                        bool isExsist = CheckisExsistRecord(username, sector, company, qty, price, tpye);
                        if (!isExsist)
                            cmd.CommandText = "INSERT INTO UserStorkMatket (UserName, SectorName, CompanyName, StockQuantity, StockPrice, TotalAmount) VALUES ('" + username + "', '" + sector + "', '" + company + "','" + qty + "', '" + price + "','" + (qty * price) + "')";
                        else
                        {
                            //cmd.CommandText = "INSERT INTO UserStorkMatket (UserName, SectorName, CompanyName, StockQuantity, StockPrice, TotalAmount) VALUES ('" + username + "', '" + sector + "', '" + company + "','" + qty + "', '" + price + "','" + (qty * price) + "')";
                            cmd.CommandText = "UPDATE UserStorkMatket"
                                              + "  SET StockQuantity = StockQuantity + " + qty
                                              + "  WHERE UserName = '" + username + "' AND StockPrice = " + price + " AND SectorName = '" + sector + "' AND CompanyName = '" + company + "'";
                        }
                    }

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

        public static bool Save2(string username, string sector, string company, int qty, decimal price)
        {
            bool isRegitered = false;
            string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO UserStock (UserName, SectorName, CompanyName, StockQuantity, StockPrice, TotalAmount) VALUES ('" + username + "', '" + sector + "', '" + company + "','" + qty + "', '" + price + "','" + (qty * price) + "')";

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

        public static bool Save1(string username, string sector, string company, int qty, decimal price)
        {
            bool isRegitered = false;
            string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO UserStock (UserName, SectorName, CompanyName, StockQuantity, StockPrice, TotalAmount) VALUES ('" + username + "', '" + sector + "', '" + company + "','" + qty + "', '" + price + "','" + (qty * price) + "')";

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
        public static bool Update(string username, string sector, string company, int qty, decimal price)
        {
            bool isRegitered = false;
            string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE UserStock"
                                       + "  SET StockQuantity = '"+ qty + "'"
                                       + " WHERE UserName = '"+ username + "' AND StockPrice = '" + price + "' AND SectorName = '" + sector + "' AND CompanyName = '" + company + "'"; 

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
        public static bool Update2(string username, string sector, string company, int qty, decimal price)
        {
            bool isRegitered = false;
            string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE StockMarket"
                                       + "  SET StockQuantity = '" + qty + "'"
                                       + " WHERE SectorName = '" + sector + "' AND StockPrice = '" + price + "' AND CompanyName = '" + company + "'";

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

        public static bool Update1(string username, string sector, string company, int qty, decimal price)
        {
            bool isRegitered = false;
            string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE UserStorkMatket"
                                       + "  SET StockQuantity = '" + qty + "'"
                                       + " WHERE UserName = '" + username + "' AND SectorName = '" + sector + "' AND CompanyName = '" + company + "'";

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

        public static bool CheckisExsistRecord(string username, string sector, string company, int qty, decimal price, int type)
        {
           string connetionString = ConfigurationManager.ConnectionStrings["ASPNETConnectionString"].ConnectionString;
            SqlConnection connection;

            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;

            bool isExsist = false;
            if(type == 1)
                sql = "Select * from UserStock WHERE UserName = '" + username + "' AND StockPrice = " + price + " AND SectorName = '" + sector + "' AND CompanyName = '" + company + "'";
            else if (type == 2)
                sql = "Select * from UserStorkMatket WHERE UserName = '" + username + "' AND StockPrice = " + price + " AND SectorName = '" + sector + "' AND CompanyName = '" + company + "'";
            //else //type = 3
            //    sql = "Select * from UserStorkMatket WHERE UserName = '" + username + "' AND StockPrice = '" + price + "' AND SectorName = '" + sector + "' AND CompanyName = '" + company + "'";

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
    }
}