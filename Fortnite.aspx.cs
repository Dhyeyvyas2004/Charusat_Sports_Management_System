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
    public partial class Fortnite : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SPInsertIntoFortnite_info", gen.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", exampleInputNameft.Text);
                cmd.Parameters.AddWithValue("@Email", exampleInputEmailft);
                cmd.Parameters.AddWithValue("@Password", exampleInputPasswordft.Text);
                cmd.Parameters.AddWithValue("@Gender", exampleSelectGenderft.Text);
                cmd.Parameters.AddWithValue("@Photo upload", exampleSelectPhotoft.InnerText);
                cmd.Parameters.AddWithValue("@City", exampleInputCityft.Text);
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
            exampleInputNameft.Text = string.Empty;
        }
    }
}