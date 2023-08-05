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
    public partial class Carrom : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SPInsertIntoCarrom_info", gen.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", exampleInputNamecm.Text);
                cmd.Parameters.AddWithValue("@Email", exampleInputEmailcm);
                cmd.Parameters.AddWithValue("@Password", exampleInputPasswordcm.Text);
                cmd.Parameters.AddWithValue("@Gender", exampleSelectGendercm.Text);
                cmd.Parameters.AddWithValue("@Photo upload", exampleSelectPhotocm.InnerText);
                cmd.Parameters.AddWithValue("@City", exampleInputCitycm.Text);
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
            exampleInputNamecm.Text = string.Empty;
        }
    }
}