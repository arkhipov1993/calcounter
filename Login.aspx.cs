using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool checkUser = false;
        string connectionString = "Database=bh62044_calcounter;Data Source=91.219.194.4;User Id=bh62044_evgeny;Password=admin12345678";
        MySqlConnection conn = new MySqlConnection(connectionString);
        MySqlCommand command = conn.CreateCommand();
        
            //try
            //{
                command.CommandText = @"SELECT * FROM bh62044_calcounter.logins WHERE email = '" + TextBox1.Text + "' AND password = '" + TextBox2.Text + "';";
                conn.Open();
                string userEmail = "";
                string userPass = "";
                 MySqlDataReader reader = command.ExecuteReader();
                 while (reader.Read())
                 {
                     checkUser = true;

                     userEmail = reader["email"].ToString();
                     userPass = reader["password"].ToString();


                 }
                //if(userEmail == TextBox1.Text & userPass == TextBox2.Text)
                //{
                //    Session["Username"] = TextBox1.Text;
                //    Response.Redirect("loggedInPage.aspx");
                //    Response.Write(userEmail + ", " + userPass);
                //}
                if (!checkUser)
                {
                    Label1.Text = "email or password are wrong";
                    conn.Close();
                    conn.Dispose();
                    conn = null;
                }
                else
                {
                    Session["Username"] = TextBox1.Text;
                    Response.Redirect("loggedInPage.aspx");
                    Response.Write(userEmail + ", " + userPass);
                    conn.Close();
                    conn.Dispose();
                    conn = null;
                }
            
            }
            //catch (Exception ex)
            //{
                
            //    //Label1.Text = "error: " + ex;
            //}
            
            }
            

 
            
               
               

