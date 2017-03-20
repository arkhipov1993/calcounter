using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class loggedInPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"]!=null)
        {
            Label1.Text = "You logged in to account "+Session["Username"]+" !";

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("Login.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("CalCounter.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditAccount.aspx");
    }
}