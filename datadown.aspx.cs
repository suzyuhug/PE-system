using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class datadown : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {


            if (Session["USERID"] != null)
            {
                string conn = "server=10.194.48.150\\MySQL;database=Rework;uid=sa;pwd=Aa123456";
                SqlConnection sqlconn = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlconn;
                cmd.CommandText = "sp_datadown";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dp.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();

          
            }
            else
            {
                Response.Redirect("/Account/login.aspx");
            }
        }
        catch (Exception)
        {

        }

    }


  

}