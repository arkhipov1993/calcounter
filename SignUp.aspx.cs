using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string firstName = TextBox1.Text;
        string lastName = TextBox2.Text;
        string email = TextBox3.Text;
        string password = TextBox4.Text;
        string age = TextBox6.Text;
        string weight = TextBox7.Text;
        string height = TextBox8.Text;
        string purpose = DropDownList1.Text;
        string stringConnection;
        stringConnection = "Database=acsm_1c8d208942ba5c9;Data Source=ca-cdbr-azure-east-a.cloudapp.net;User Id=bfbef46d9ab76f;Password=28bcf9c1";
        using (MySqlConnection conn = new MySqlConnection(stringConnection))
        {
            string request = "INSERT INTO logins(firstName, lastName, email, password, age, weight, height, purpose) VALUES (@firstName, @lastName, @email, @password, @age, @weight, @height, @purpose)";
            using (MySqlCommand cmd = new MySqlCommand(request))
            {
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@height", height);
                cmd.Parameters.AddWithValue("@purpose", purpose);
                
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                
                
            }
            Response.Redirect("login.aspx");
            
        }
        //try
        //{
       
        //command.CommandText = @"INSERT INTO `logins` (`firstName`, `lastName`,`email`,`password`) VALUES ('" + TextBox1.Text + "', '" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
        
        //string userEmail = "";
        //string userPass = "";
        //MySqlDataReader reader = command.ExecuteReader();
        //while (reader.Read())
        //{
        //    checkUser = true;

        //    userEmail = reader["email"].ToString();
        //    userPass = reader["password"].ToString();


        //}
        //if(userEmail == TextBox1.Text & userPass == TextBox2.Text)
        //{
        //    Session["Username"] = TextBox1.Text;
        //    Response.Redirect("loggedInPage.aspx");
        //    Response.Write(userEmail + ", " + userPass);
        //}
        //if (!checkUser)
        //{
        //    Label1.Text = "email or password are wrong";
        //    conn.Close();
        //}
        //else
        //{
        //    Session["Username"] = TextBox1.Text;
        //    Response.Redirect("loggedInPage.aspx");
        //    Response.Write(userEmail + ", " + userPass);
        //    conn.Close();
        //}
        //string stringConnection;
        //stringConnection = "Database=acsm_1c8d208942ba5c9;Data Source=ca-cdbr-azure-east-a.cloudapp.net;User Id=bfbef46d9ab76f;Password=28bcf9c1";
        //MySqlConnection conn = new MySqlConnection(stringConnection);
        //conn.Open();
        //string checkUser = "SELECT * from logins where email='" + TextBox1.Text + "' and password='" + TextBox2.Text + "';";
        //MySqlCommand comm = new MySqlCommand(checkUser, conn);
        //int temp = Convert.ToInt32(comm.ExecuteScalar().ToString().Replace(" ", ""));

        //if (temp == 1)
        //{
        //    conn.Close();
        //    Session["Username"] = TextBox1.Text;
        //    Response.Redirect("loggedInPage.aspx");
        //}
        //else
        //{
        //    conn.Close();
        //    Label1.Text = "Login or password is not correct! Try again.";
        //}
    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}