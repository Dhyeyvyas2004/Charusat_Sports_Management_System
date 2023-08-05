using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace SportDemo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("SPInsertIntoRegistrationDetails", gen.con);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            //    cmd.Parameters.AddWithValue("@Password", psw.Text);
            //    gen.con.Open();
            //    cmd.ExecuteNonQuery();
            //    gen.con.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            

        }

        protected void btnRegistraion_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Regist.aspx");
        }

    }
}