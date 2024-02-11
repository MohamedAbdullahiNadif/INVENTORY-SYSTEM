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
    public partial class orders : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA; initial catalog=INVENTORY; integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
                readddlitemname();
            
        }

        protected void btnget_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select itemname, price, quantity,from item where itemid = @id", con);
            cmd.Parameters.AddWithValue("@id", ddlitname.Text);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtqty.Text = dr["Qty"].ToString();
                txtprice.Text = dr["Price"].ToString();
            }
            else
            {
                lbl.Text = "waa lasoo waayay";
            }
            con.Close();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                string qury = "insert into order1 values(@custid,@itemid,@qty,@price,@new_qty,@Remained,@new_price,@total_balance,@registerdate)";
                SqlCommand cmd = new SqlCommand(qury, con);
                cmd.Parameters.AddWithValue("@custid", ddlname.Text);
                cmd.Parameters.AddWithValue("@itemid", ddlitname.Text);
                cmd.Parameters.AddWithValue("@qty", txtqty.Text);
                cmd.Parameters.AddWithValue("@price", txtprice.Text);
                cmd.Parameters.AddWithValue("@new_qty", txtnqty.Text);
                cmd.Parameters.AddWithValue("@Remained", txtremained.Text);
                cmd.Parameters.AddWithValue("@new_price", txtnprice.Text);
                cmd.Parameters.AddWithValue("@total_balance", txtblance.Text);
                cmd.Parameters.AddWithValue("@registerdate", txtdate.Text);
                cmd.ExecuteNonQuery();
                lbl.Text = "Xogtaan waa laxareeyay !!";
                con.Close();
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update order1 set custid=@custid,itemid=@itemid,qty=@qty,price=@price,new_qty=@new_qty,new_price=@new_price,total_balance=@total_balance,registerdate=@registerdate where orderid = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@custid", ddlname.Text);
            cmd.Parameters.AddWithValue("@itemid", ddlitname.Text);
            cmd.Parameters.AddWithValue("@qty", txtqty.Text);
            cmd.Parameters.AddWithValue("@price", txtprice.Text);
            cmd.Parameters.AddWithValue("@new_qty", txtnqty.Text);
            cmd.Parameters.AddWithValue("@new_price", txtnprice.Text);
            cmd.Parameters.AddWithValue("@total_balance", txtblance.Text);
            cmd.Parameters.AddWithValue("@registerdate", txtdate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa la bedelay !!";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from order1 where orderid = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa latiray";
            con.Close();
        }
        public void readddlitemname()
        {

            if (!IsPostBack)
            {
                String strQuery = "SELECT id,itemname  FROM item";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strQuery;
                cmd.Connection = con;
                try
                {
                    con.Open();
                    ddlitname.DataSource = cmd.ExecuteReader();
                    ddlitname.DataTextField = "itemname";
                    ddlitname.DataValueField = "id";
                    ddlitname.DataBind();
                    ddlitname.Items.Insert(0, "select itemname ");

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                    //  con.Dispose();  
                }
            }

        }
    }
}