using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using PEsystem;
using System.Data.SqlClient;
using System.Data;

public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

    protected void LogIn(object sender, EventArgs e)
    {
        try
        {      
        string conn = "server=10.194.48.150\\MySQL;database=Rework;uid=sa;pwd=Aa123456";
        SqlConnection sqlconn = new SqlConnection(conn);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = sqlconn;
        cmd.CommandText = "sp_userlogin";
        cmd.CommandType = CommandType.StoredProcedure;
        IDataParameter[] Parameters ={
            new SqlParameter ("@PEmployee",SqlDbType.VarChar,50),
            new SqlParameter ("@PPassWord",SqlDbType.VarChar,50),           
        };
        Parameters[0].Value = UserName.Text ;
        Parameters[1].Value = Password.Text ;     
        cmd.Parameters.Add(Parameters[0]);
        cmd.Parameters.Add(Parameters[1]);    
        SqlDataAdapter dp = new SqlDataAdapter(cmd);
        DataSet ds =new DataSet();
        dp.Fill(ds);
        Label1.Text = ds.Tables[0].Rows[0][1].ToString();
           String s = ds.Tables[0].Rows[0][0].ToString();

            if (s == "1")
            {
                Session["USERID"] = UserName.Text ;
                Response.Redirect("/Default.aspx");
              

                
            }
            else
            {

                UserName.Text = "";


            }
     

        }
        catch (Exception)
        {

          

        }



    }
}