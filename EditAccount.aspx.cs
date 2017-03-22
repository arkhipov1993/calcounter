using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class EditAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"] != null)
        {
            //Label1.Text = "You logged in to account " + Session["Username"] + " !";

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string connectionString = "Database=bh62044_calcounter;Data Source=91.219.194.4;User Id=bh62044_evgeny;Password=admin12345678";
        MySqlConnection conn = new MySqlConnection(connectionString);
        MySqlCommand command = conn.CreateCommand();
        command.CommandText = @"UPDATE bh62044_calcounter.logins SET age=" + TextBox6.Text + ",weight=" + TextBox7.Text + ",height=" + TextBox8.Text + ",purpose='" + DropDownList1.SelectedValue + "' WHERE email='" + Session["Username"] + "';";
        conn.Open();
        command.ExecuteNonQuery();
        conn.Close();
        conn.Dispose();
        conn = null;
        Button1.Visible = false;
        Label1.Visible = true;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("loggedInPage.aspx");
    }
}