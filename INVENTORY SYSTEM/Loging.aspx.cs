using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace INVENTORY_SYSTEM
{
    public partial class Loging : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA; initial catalog=INVENTORY; integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnloging_Click(object sender, EventArgs e)
        {
            con Open(),

cmd = new SqlCommand("select username, password from users where username: txtusername Text + "and password = '" +

SqlDataAdapter da = new SqlDataAdapter(cmd),
DataTable dt = new DataTable();
da Fill(dt),
if (dt.Rows Count > 0)
Response.Redirect("index aspx");

            31

32

else

                33

34

lblinfo Text = "Invalid username and password";

            35

36

con Close(),

37

txtusername Text = "";

            38

39

txtpassword.Text = "";

        }
    }
}