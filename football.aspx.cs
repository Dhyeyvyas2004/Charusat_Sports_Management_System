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
    public partial class football : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SPInsertIntofootball_info", gen.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", exampleInputNamef.Text);
                cmd.Parameters.AddWithValue("@Email", exampleInputEmailf);
                cmd.Parameters.AddWithValue("@Password", exampleInputPasswordf.Text);
                cmd.Parameters.AddWithValue("@Gender", exampleSelectGenderf.Text);
                cmd.Parameters.AddWithValue("@Photo upload", exampleSelectPhotof.InnerText);
                cmd.Parameters.AddWithValue("@City", exampleInputCityf.Text);
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
            exampleInputNamef.Text = string.Empty;
        }
    }
}