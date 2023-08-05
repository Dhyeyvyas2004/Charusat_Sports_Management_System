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
    public partial class Pubg : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SPInsertIntoPubg_info", gen.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", exampleInputNamep.Text);
                cmd.Parameters.AddWithValue("@Email", exampleInputEmailp);
                cmd.Parameters.AddWithValue("@Password", exampleInputPasswordp.Text);
                cmd.Parameters.AddWithValue("@Gender", exampleSelectGenderp.Text);
                cmd.Parameters.AddWithValue("@Photo upload", exampleSelectPhotop.InnerText);
                cmd.Parameters.AddWithValue("@City", exampleInputCityp.Text);
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
            exampleInputNamep.Text = string.Empty;
        }
    }
}