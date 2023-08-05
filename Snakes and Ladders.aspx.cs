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
    public partial class Snakes_and_Ladders : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SPInsertIntosnakes_info", gen.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", exampleInputNames.Text);
                cmd.Parameters.AddWithValue("@Email", exampleInputEmails);
                cmd.Parameters.AddWithValue("@Password", exampleInputPasswords.Text);
                cmd.Parameters.AddWithValue("@Gender", exampleSelectGenders.Text);
                cmd.Parameters.AddWithValue("@Photo upload", exampleSelectPhotos.InnerText);
                cmd.Parameters.AddWithValue("@City", exampleInputCitys.Text);
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
            exampleInputNames.Text = string.Empty;
        }
    }
}