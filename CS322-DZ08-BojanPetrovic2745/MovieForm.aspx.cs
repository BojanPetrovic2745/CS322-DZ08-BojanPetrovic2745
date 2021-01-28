using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS322_DZ08_BojanPetrovic2745
{

    public partial class MovieForm : System.Web.UI.Page
    {
        private SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bojan\Movie.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into filmovi values('" + title.Text + "','" + genre.Text + "','" + year.Text + "')";
            cmd.ExecuteNonQuery();

            con.Close();
        }

        protected void Label_Changed(object sender, EventArgs e)
        {
            con = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bojan\Movie.mdf;Integrated Security=True;Connect Timeout=30");

            SqlCommand command = new SqlCommand(
                "SELECT * FROM dbo.filmovi", con);
            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                while (reader.Read())
                { 
                    ListBox1.Items.Add(reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetInt32(3));

                }
                reader.NextResult();
            }
            reader.Close();
            con.Close();
        }
    }
}