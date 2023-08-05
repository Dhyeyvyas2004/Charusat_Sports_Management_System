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
    public partial class Ludo : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SPInsertIntoLudo_info", gen.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", exampleInputNamel.Text);
                cmd.Parameters.AddWithValue("@Email", exampleInputEmaill);
                cmd.Parameters.AddWithValue("@Password", exampleInputPasswordl.Text);
                cmd.Parameters.AddWithValue("@Gender", exampleSelectGenderl.Text);
                cmd.Parameters.AddWithValue("@Photo upload", exampleSelectPhotol.InnerText);
                cmd.Parameters.AddWithValue("@City", exampleInputCityl.Text);
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
            exampleInputNamel.Text = string.Empty;
        }
    }
}


      
