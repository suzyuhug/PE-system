using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
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
                cmd.CommandText = "sp_userlogin";
                cmd.CommandType = CommandType.StoredProcedure;                
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dp.Fill(ds);
              

                

            }
            else
            {

                Response.Redirect("/Account/login.aspx");

            }








        }
        catch (Exception)
        {



        }


       // Label1.Text = System.Environment.UserDomainName;
      // Label2.Text = Environment.UserName ;
     

    }
}