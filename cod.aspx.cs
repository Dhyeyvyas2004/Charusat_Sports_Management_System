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
    public partial class cod : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SPInsertIntocodInfo", gen.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", exampleInputNamecod.Text);
                cmd.Parameters.AddWithValue("@Email", exampleInputEmaicod);
                cmd.Parameters.AddWithValue("@Password", exampleInputPasswordcod.Text);
                cmd.Parameters.AddWithValue("@Gender", exampleSelectGendercod.Text);
                cmd.Parameters.AddWithValue("@Photo upload", exampleSelectPhotocod.InnerText);
                cmd.Parameters.AddWithValue("@City", exampleInputCitycod.Text);
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
            exampleInputNamecod.Text = string.Empty;
        }
    }
}
