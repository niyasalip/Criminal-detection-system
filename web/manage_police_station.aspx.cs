using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manage_police_station : System.Web.UI.Page
{

    dbconnect db = new dbconnect();
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd.CommandText = " insert into stations values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
        db.Execute(cmd);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        cmd.CommandText = " select * from stations";
        DataGrid1.DataSource = db.get_Data(cmd);
        DataGrid1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        cmd.CommandText = "update employedetails set Station_id ='" + TextBox1.Text + "', Station_name='" + TextBox2.Text + "', Station_incharge='"  + TextBox3.Text +  "', Contact='" + TextBox2.Text + "' where Station_id='" + TextBox1.Text + "'";
        db.Execute(cmd);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        cmd.CommandText = "delete from stations where Station_id ='" + TextBox1.Text + "'";
        db.Execute(cmd);
    }
}