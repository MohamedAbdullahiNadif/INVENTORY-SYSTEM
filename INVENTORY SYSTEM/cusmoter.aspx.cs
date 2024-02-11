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
    public partial class cusmoter : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA; initial catalog=INVENTORY; integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql_query = "insert into customer values (@custname, @Tell,@Balance,@Registerdate)";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.AddWithValue("@custname", txtcustomername.Text);
            cmd.Parameters.AddWithValue("@Tell", txtTell.Text);
            cmd.Parameters.AddWithValue("@Balance", txtBalance.Text);
            cmd.Parameters.AddWithValue("@Registerdate", txtRegdate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa laxareeyay !!";
            con.Close();
        }

        protected void btnUpdet_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update customer set custname=@custname, Tell=@Tell,Balance=@Balance,Registerdate=@Registerdate where custid = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@custname", txtcustomername.Text);
            cmd.Parameters.AddWithValue("@Tell", txtTell.Text);
            cmd.Parameters.AddWithValue("@Balance", txtBalance.Text);
            cmd.Parameters.AddWithValue("@Registerdate", txtRegdate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa la bedelay !!";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from customer where custid= '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa latiray";
            con.Close();
        }
    }
}