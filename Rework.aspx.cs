using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Rework : System.Web.UI.Page
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
                cmd.CommandText = "sp_reworklist";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dp.Fill(ds);               
                DropDownList2.DataSource = ds.Tables[0];
                DropDownList2.DataTextField = "Buyoff";
                DropDownList2.DataValueField = "Buyoff";
                DropDownList2.DataBind();
            
                DropDownList1.DataSource = ds.Tables[1];
                DropDownList1.DataTextField = "Station";
                DropDownList1.DataValueField = "Station";
                DropDownList1.DataBind();
             
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

    protected void Button1_Click(object sender, EventArgs e)
    {
       try
        {

            string conn = "server=10.194.48.150\\MySQL;database=Rework;uid=sa;pwd=Aa123456";
            SqlConnection sqlconn = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlconn;
            cmd.CommandText = "sp_reworkinsert";
            cmd.CommandType = CommandType.StoredProcedure;
            IDataParameter[] Parameters ={
            new SqlParameter ("@sn",SqlDbType.VarChar,50),
            new SqlParameter ("@station",SqlDbType.VarChar,50),
            new SqlParameter ("@buyoff",SqlDbType.VarChar,50),
            new SqlParameter ("@des",SqlDbType.Text ),
            new SqlParameter ("@owner",SqlDbType.VarChar,50),
           
        };
            Parameters[0].Value = UserName.Text;
            Parameters[1].Value = DropDownList1.Text ;
            Parameters[2].Value = DropDownList2.Text;
            Parameters[3].Value = Password.Text;
            Parameters[4].Value = Session["USERID"].ToString ();
 
            cmd.Parameters.Add(Parameters[0]);
            cmd.Parameters.Add(Parameters[1]);
            cmd.Parameters.Add(Parameters[2]);
            cmd.Parameters.Add(Parameters[3]);
            cmd.Parameters.Add(Parameters[4]);
        sqlconn.Open();
        cmd.ExecuteNonQuery();
       sqlconn.Close();
            UserName.Text = "";Password.Text = "";
            UserName.Focus();


          
        }
        catch (Exception)
        {

            
       }
    }
}