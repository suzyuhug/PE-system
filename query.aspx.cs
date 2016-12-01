using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class query : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {


            if (Session["USERID"] != null)
            {
               string conn = "server=10.194.48.150\\MySQL;database=Rework;uid=sa;pwd=Aa123456";
                //string conn=ConfigurationManager.AppSettings["sql"];
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
