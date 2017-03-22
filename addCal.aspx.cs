using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

public partial class addCal : System.Web.UI.Page
{
    int calCounter;
    int productCal;
    int calLeft;
    int calConsumed;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["Username"] != null)
        {
            Label1.Text = "Session was created successfully!";
            string connectionString = "Database=bh62044_calcounter;Data Source=91.219.194.4;User Id=bh62044_evgeny;Password=admin12345678";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand command = conn.CreateCommand();



            command.CommandText = @"SELECT productName FROM bh62044_calcounter.products;";
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DropDownList1.Items.Add(reader.GetString("productName"));
            }
            reader.Close();

           

            conn.Close();
            conn.Dispose();
            conn = null;
            

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("CalCounter.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
          
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string connectionString = "Database=bh62044_calcounter;Data Source=91.219.194.4;User Id=bh62044_evgeny;Password=admin12345678";
        MySqlConnection conn = new MySqlConnection(connectionString);
        MySqlCommand command = conn.CreateCommand();
        command.CommandText = @"SELECT * FROM bh62044_calcounter.products WHERE productName='" + DropDownList1.Text + "';";
        conn.Open();
        MySqlDataReader reader = command.ExecuteReader();
        reader.Read();
        productCal = Convert.ToInt32(reader.GetString("productCal"));
        calCounter = (productCal * Convert.ToInt32(TextBox1.Text))/100;
        Label1.Text = calCounter.ToString();
        reader.Close();
        //code above works


        command.CommandText = @"SELECT * FROM bh62044_calcounter.logins WHERE email='" + Session["username"] + "';";
        reader=command.ExecuteReader();
       // command.ExecuteNonQuery();
        reader.Read();

        calConsumed = Convert.ToInt32(reader.GetString("calConsumed")) + calCounter;
        calLeft = Convert.ToInt32(reader.GetString("calLeft"));

        Label1.Text = calConsumed.ToString();
        reader.Close();

        command.CommandText = @"UPDATE bh62044_calcounter.logins SET calConsumed=" + calConsumed + " WHERE email='" + Session["Username"] + "';";
        reader = command.ExecuteReader();
        reader.Close();



        conn.Close();
        conn.Dispose();
        conn = null;
        Button2.Enabled = false;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        Session.RemoveAll();
        Response.Redirect("Login.aspx");
    }
}