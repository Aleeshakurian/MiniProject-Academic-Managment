using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Class1 obj = new Class1();
        obj.getconnect();
        SqlCommand cmd1 = new SqlCommand("admin_loginsp", obj.con);
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.Parameters.Add("@flag", 0);
        cmd1.Parameters.Add("username", inputemail.Text);
        cmd1.Parameters.Add("password", inputPassword.Text);
        DataTable dt1 = new DataTable();
        SqlDataAdapter adt1 = new SqlDataAdapter(cmd1);
        adt1.Fill(dt1);

        if (dt1.Rows.Count > 0)
        {
            Session["username"] = inputemail.Text;
            if (dt1.Rows[0][0].ToString().CompareTo("admin") == 0)
            {
                Response.Redirect("~/Admin/Admin_dashboard.aspx");

            }
            else
            {
                Response.Redirect("register.html");
                Session.RemoveAll();
            }


        }

    }
}