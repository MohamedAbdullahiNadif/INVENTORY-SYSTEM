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
    public partial class Itome : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA; initial catalog=INVENTORY; integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into item values (@itemname, @price,@quantity,@Registerdate)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@itemname", txtitemname.Text);
            cmd.Parameters.AddWithValue("@price", txtprice.Text);
            cmd.Parameters.AddWithValue("@quantity", txtqty.Text);
            cmd.Parameters.AddWithValue("@Registerdate", txtregdate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa laxareeyay !!";
            con.Close();
        }

        protected void btnUpdet_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update item set itemname=@itemname, price=@price,quantity=@quantity,Registerdate=@Registerdate where itemid = '" + txt.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@itemname", txtitemname.Text);
            cmd.Parameters.AddWithValue("@price", txtprice.Text);
            cmd.Parameters.AddWithValue("@quantity", txtqty.Text);
            cmd.Parameters.AddWithValue("@Registerdate", txtregdate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa la bedelay !!";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
        
        }

        
    }

    }