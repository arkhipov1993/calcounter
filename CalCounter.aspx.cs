using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

public partial class CalCounter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"] != null)
        {
            Response.Write(Session["Username"]);
            int age;
            int weight;
            int height;
            string purpose;
            int calLeft;
            int result=0;
            int calConsumed;

            Label1.Text = "Hello, welcome to the Calories counter!";
            string connectionString = "Database=acsm_1c8d208942ba5c9;Data Source=ca-cdbr-azure-east-a.cloudapp.net;User Id=bfbef46d9ab76f;Password=28bcf9c1";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = @"SELECT * FROM logins WHERE email='"+Session["Username"]+"';";
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            age = Convert.ToInt32(reader.GetString("age"));
            weight = Convert.ToInt32(reader.GetString("weight"));
            height = Convert.ToInt32(reader.GetString("height"));
            purpose = reader.GetString("purpose");
           
           // Session["calLeft"] = reader.GetString("calLeft");
           if (!reader.IsDBNull(reader.GetOrdinal("calLeft")))
            
            {
                calLeft = Convert.ToInt32(reader.GetString("calLeft"));
                calConsumed = Convert.ToInt32(reader.GetString("calConsumed"));
                TextBox1.Text = reader.GetString("calLeft");
                TextBox2.Text = reader.GetString("calConsumed");
                
            }
            else
            {
                if (purpose == "gain")
                {
                    result = (10 * weight + 6 * height - 5 * age - 161)*2;
                    calLeft=result;
                    TextBox1.Text = Convert.ToString(result);
                    command.CommandText = @"UPDATE logins SET calLeft=" + TextBox1.Text + " WHERE email='" + Session["Username"] + "';";
                    reader.Close();
                    command.ExecuteNonQuery();
                    //reader.Read();
                }
               if (purpose=="loss")
                {
                   result = (10 * weight + 5 * height - 5 * age - 161)*2-300;
                   calLeft = result;
                   TextBox1.Text = Convert.ToString(result);
                   command.CommandText = @"UPDATE logins SET calLeft=" + TextBox1.Text + " WHERE email='" + Session["Username"] + "';";
                   reader.Close();
                   command.ExecuteNonQuery();
                   //reader.Read();
                  // conn.Close();

                }
               else
               {
                   result = (10 * weight + 6 * height - 5 * age - 161)+550;
                   calLeft = result;
                   TextBox1.Text = Convert.ToString(result);
                   command.CommandText = @"UPDATE logins SET calLeft=" + TextBox1.Text + " WHERE email='" + Session["Username"] + "';";
                   reader.Close();
                   command.ExecuteNonQuery();
               }
  
            }

            conn.Close();
            conn.Dispose();
            conn = null;

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("loggedInPage.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("Login.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("addCal.aspx");
    }
}