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
    public partial class Users : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA; initial catalog=INVENTORY; integrated security=true");


        protected void Page_Load(object sender, EventArgs e)
        {
            readDDLData();
            refreshData();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql_query = "insert into users values (@empid, @username,@password,@usertitel,@date)";
            SqlCommand cmd = new SqlCommand(sql_query, conn);
            cmd.Parameters.AddWithValue("@empid", ddlempname.Text);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            cmd.Parameters.AddWithValue("@usertitel", ddlusertype.Text);
            cmd.Parameters.AddWithValue("@date", txtdate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa laxareeyay !!";
            conn.Close();
        }

        public void refreshData()
        {
            conn.Open();
            string sql = "Select * from users";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gr.DataBind();
            conn.Close();

        }


        protected void btnupdet_Click(object sender, EventArgs e)
        {
            conn.Open();
            string up = "update users set empid=@empid, username=@username,password=@password,Usertitel=@Usertitel,Registerdate=@Registerdate where userid = '" + txtid.Text + "' ";
            SqlCommand cmd = new SqlCommand(up, conn);
            cmd.Parameters.AddWithValue("@empid", ddlempname.Text);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            cmd.Parameters.AddWithValue("@Usertitel", ddlusertype.Text);
            cmd.Parameters.AddWithValue("@Registerdate", txtdate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa la badalay !!";
            conn.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            conn.Open();
            string del = "delete from users where userid='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, conn);
            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa latiray";
            conn.Close();
        }

        protected void ddlempname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void readDDLData()
        {
            conn.Open();
            string sql = "Select empid, EmployeName from Employee";
            SqlDataAdapter adpt = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddlempname.DataSource = dt;
            ddlempname.DataBind();
            ddlempname.DataTextField = "EmployeName";
            ddlempname.DataValueField = "empid";
            ddlempname.DataBind();
            conn.Close();
        }

 

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select @empid, @username,@password,@usertitel,@date from users where userid = @id", conn);
            cmd.Parameters.AddWithValue("@id", lbl.Text);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ddlempname.Text = dr["empid"].ToString();
                txtusername.Text = dr["username"].ToString();
                txtpassword.Text = dr["paswword"].ToString();
                ddlusertype.Text = dr["usertitle"].ToString();
                txtdate.Text = dr["registerdate"].ToString();
            }
            else
            {
                lbl.Text = "waa lasoo waayay";
            }
            conn.Close();
        }
    }
    }