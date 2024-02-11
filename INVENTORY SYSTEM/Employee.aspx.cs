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
    public partial class Employee : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source= DESKTOP-6DVS299\\MOHA; initial catalog=INVENTORY; integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            string insert = "insert into Employee values(@EmployeName,@Phone,@Addres,@Email,@Jobtitle,@Salary,@Status,@Registerdate)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@EmployeName", txtfullname.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@Addres", txtAddres.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Jobtitle", ddlusertype.Text);
            cmd.Parameters.AddWithValue("@Salary", txtsalary.Text);
            cmd.Parameters.AddWithValue("@Status", ddlstatus.Text);
            cmd.Parameters.AddWithValue("@Registerdate", txtdate.Text);
            cmd.ExecuteNonQuery();
            lbl.Text = "xogtan waa la xareyay";
            con.Close();
        }

        protected void btnUpdet_Click(object sender, EventArgs e)
        {
            con.Open();
            string edit = "update Employee set EmployeName=@EmployeName, Phone=@Phone,Addres=@Addres,Email=@Email,Jobtitle=@Jobtitle,Salary=@Salary,Status=@Status,Registerdate=@Registerdate where Empid = '" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@EmployeName", txtfullname.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@Addres", txtAddres.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Jobtitle", ddlusertype.Text);
            cmd.Parameters.AddWithValue("@Salary", txtsalary.Text);
            cmd.Parameters.AddWithValue("@Status", ddlstatus.Text);
            cmd.Parameters.AddWithValue("@Registerdate", txtdate.Text);

            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa la bedelay !!";
            con.Close();
        }

        protected void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "delete from users where  Empid ='" + txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            lbl.Text = "Xogtaan waa latiray";
            con.Close();
        }
    }
}