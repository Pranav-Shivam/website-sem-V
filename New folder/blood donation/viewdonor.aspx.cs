using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class viewdonor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        show_data();
    }

    private void show_data()
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\website\New folder\blood donation\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand("select * from Donar", con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        dt.Load(dr);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        con.Close();
    }
}