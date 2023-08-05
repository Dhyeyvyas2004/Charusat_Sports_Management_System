using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace SportDemo
{
    public partial class Cricket : System.Web.UI.Page
    {
        General gen = new General();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
        }
            protected void btnSubmit_Click(object sender, EventArgs e)
            {
                try
                {
                SqlCommand cmd = new SqlCommand("SPInsertIntoCricketinfo", gen.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", exampleInputName1.Text);
                cmd.Parameters.AddWithValue("@Email", exampleInputEmail3);
                cmd.Parameters.AddWithValue("@Password", exampleInputPassword4.Text);
                cmd.Parameters.AddWithValue("@Gender", exampleSelectGender.Text);
                cmd.Parameters.AddWithValue("@City", exampleInputCity1.Text);
                gen.con.Open();
                cmd.ExecuteNonQuery();
                gen.con.Close();
                }
                catch (Exception ex)
                {

                }
            }
            protected void btnReset_Click(object sender, EventArgs e)
            {
                exampleInputName1.Text = string.Empty;
            }
    }
}
